using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckingDiskUsageFolderWinForm
{
    public partial class Rotary2040RPController : Form
    {
        public Rotary2040RPController()
        {
            InitializeComponent();

            findConnectedPorts();
        }

        #region Events
        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            SelectFolderAndDisplayPath();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string folderPath = txbFolderPath.Text;
            foreach (var file in Directory.EnumerateFiles(folderPath))
            {
                bool continueChecking = await OpenFileAndCheckDiskUsage(file);
                if (!continueChecking)
                {
                    break;
                }
            }
            txbDisplayDiskUsage.Text = "Disk usage of current file:";
            MessageBox.Show($"Checking process disk usage of folder {folderPath} completed!");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbCOMPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                serialPort1.DtrEnable = true;
                serialPort1.Open();
                pbSettings.Value = 100;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnResetCOMPort_Click(object sender, EventArgs e)
        {
            cbCOMPort.Text = "";
            cbCOMPort.Items.Clear();
            findConnectedPorts();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txbSendData.Text);
            txbSendData.Text = null;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            pbSettings.Value = 0;
        }

        private void btnSetCopy_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("C" + txbSetCopy.Text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            txbReadData.Clear();
        }
        #endregion


        #region Methods
        public void findConnectedPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbCOMPort.Items.Add(port);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incomingText = serialPort1.ReadExisting();

            //GlobalVariable.incomingTextPublic = serialPort1.ReadExisting();
            //incomingText = serialPort1.ReadExisting();

            //backgroundWorker1.RunWorkerAsync();
            writeIncomingData(incomingText);
        }

        private void writeIncomingData(string text)
        {

            BeginInvoke(new EventHandler(async delegate
            {
                //ReceiverTextBox.ResetText();
                //ReceiverTextBox.AppendText(text);
                //ReceiverTextBox.ScrollToCaret();

                txbReadData.Clear();

                //backgroundWorker1.RunWorkerAsync();

                txbReadData.Text = text;
                txbReadData.ScrollToCaret();
            }));
        }



        private void SelectFolderAndDisplayPath()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Cấu hình additional options cho FolderBrowserDialog nếu cần
                folderBrowserDialog.Description = "Select the folder to check disk usage";
                folderBrowserDialog.ShowNewFolderButton = false;

                // Hiển thị folder browser dialog để người dùng chọn folder
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK) // Kiểm tra xem người dùng có chọn một folder không
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath; // Lấy đường dẫn của folder đã chọn
                    txbFolderPath.Text = selectedFolderPath; // Hiển thị đường dẫn trong TextBox
                }
                else
                {
                    MessageBox.Show("Please choose a folder");
                }
            }
        }

        public async Task<bool> OpenFileAndCheckDiskUsage(string filePath)
        {
            string defaultPath = GetDefaultAppPath(filePath);

            // Mở file bằng ứng dụng mặc định
            ProcessStartInfo startInfo = new ProcessStartInfo(defaultPath);
            startInfo.Arguments = $"\"{filePath}\"";
            Process process = Process.Start(startInfo);

            await Task.Delay(1000);

            // Kiểm tra xem process có phải là null không
            if (process == null || process.HasExited)
            {
                MessageBox.Show("Cannot open file");
                return false;
            }

            //Kiểm tra xem có cửa sổ pop-up nào không
            bool hasPopup = await CheckForPopup(process);
            if (hasPopup)
            {
                await SelectNoOption(process);
            }

            // Xác định ứng dụng mà hệ thống sử dụng để mở file
            string appName = process.ProcessName;
            long diskUsage = 0;

            // Kiểm tra sử dụng đĩa của quá trình ứng dụng mỗi giây trong 1 giây
            await Task.Delay(1000); // Đợi 1 giây
            PerformanceCounter pc = new PerformanceCounter("Process", "IO Data Bytes/sec", appName);
            diskUsage += pc.RawValue / 1000000;

            txbDisplayDiskUsage.Text = string.Format("Disk usage of current file: {0} Mb/s", diskUsage);

            //// Add code here to kill the process after checking disk usage
            //if (!process.HasExited)
            //{
            //    process.Kill();
            //    process.WaitForExit(); // Ensure the process has been terminated
            //}

            // Hỏi người dùng có muốn kiểm tra file tiếp theo không
            var result = MessageBox.Show("Do you want to open next file?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Add code here to kill the process after checking disk usage
                if (!process.HasExited)
                {
                    process.Kill();
                    process.WaitForExit(); // Ensure the process has been terminated
                }
            }

            return result == DialogResult.Yes;
        }

        public string GetDefaultAppPath(string filePath)
        {
            string defaultPath = "";
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"File is not existed: {filePath}");

            }

            // Lấy phần mở rộng của file
            string extension = Path.GetExtension(filePath).ToLower();

            // Lấy ứng dụng mặc định từ Registry
            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(extension))
            {
                if (key != null)
                {
                    object value = key.GetValue("");
                    if (value != null)
                    {
                        string defaultAppKey = value.ToString() + "\\shell\\open\\command";
                        RegistryKey commandKey = null;
                        using (RegistryKey tempKey = Registry.ClassesRoot.OpenSubKey(defaultAppKey))
                        {
                            if (tempKey == null)
                            {
                                // Nếu không tìm thấy key, thử tìm trong key của ứng dụng mặc định
                                string defaultAppKey2 = value.ToString() + "\\shell";
                                using (RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(defaultAppKey2))
                                {
                                    if (key2 != null)
                                    {
                                        string subkeyName = key2.GetSubKeyNames()[0]; // Lấy tên của subkey đầu tiên
                                        defaultAppKey2 += "\\" + subkeyName + "\\command";
                                        commandKey = Registry.ClassesRoot.OpenSubKey(defaultAppKey2);
                                    }
                                }
                            }
                            else
                            {
                                commandKey = tempKey;
                            }

                            if (commandKey != null)
                            {
                                // Lấy giá trị mặc định, đây là đường dẫn đến ứng dụng mặc định
                                string defaultAppPath = commandKey.GetValue("").ToString();

                                int index = defaultAppPath.ToLower().IndexOf(".exe");
                                if (index != -1)
                                {
                                    defaultPath = defaultAppPath.Substring(0, index + 5);
                                }
                            }
                        }
                    }
                }
            }

            return defaultPath;
        }

        public async Task<bool> CheckForPopup(Process process)
        {
            await Task.Delay(1000); // Wait for the process to start and for any potential pop-ups to appear

            if (process == null || process.HasExited)
            {
                return false;
            }

            // Get the main window handle of the process
            IntPtr mainWindowHandle = process.MainWindowHandle;

            if(mainWindowHandle != IntPtr.Zero)
            {
                // Get the AutomationElement corresponding to the main window
                AutomationElement mainWindow = AutomationElement.FromHandle(mainWindowHandle);

                // Find all windows that are children of the main window
                AutomationElementCollection childWindows = mainWindow.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));

                // If there are any child windows, then a pop-up has appeared
                return childWindows.Count > 0;
            }

            return false;
        }

        public async Task SelectNoOption(Process process)
        {
            await Task.Delay(1000); // Wait for the process to start and for any potential pop-ups to appear

            if (process == null || process.HasExited)
            {
                return;
            }

            // Get the main window handle of the process
            IntPtr mainWindowHandle = process.MainWindowHandle;

            // Get the AutomationElement corresponding to the main window
            AutomationElement mainWindow = AutomationElement.FromHandle(mainWindowHandle);

            // Find all windows that are children of the main window
            AutomationElementCollection childWindows = mainWindow.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));

            foreach (AutomationElement window in childWindows)
            {
                // Find all buttons that are children of the window
                AutomationElementCollection buttons = window.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Button));

                foreach (AutomationElement button in buttons)
                {
                    // If the button's name is "No", invoke it
                    if (button.Current.Name == "No")
                    {
                        InvokePattern invokePattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                        invokePattern.Invoke();
                    }
                }
            }
        }
        #endregion

    }
}
