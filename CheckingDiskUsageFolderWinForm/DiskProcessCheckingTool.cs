using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingDiskUsageFolderWinForm
{
    public partial class DiskProcessCheckingTool : Form
    {
        public DiskProcessCheckingTool()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            SelectFolderAndDisplayPath();
        }

        private async void CheckDiskProcessFolder_Click(object sender, EventArgs e)
        {
            string folderPath = folderPathTextBox.Text;
            foreach (var file in Directory.EnumerateFiles(folderPath))
            {
                await OpenFileAndCheckDiskUsage(file);

                // Hỏi người dùng có muốn kiểm tra file tiếp theo không
                var result = MessageBox.Show("Do you want to open next file?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    // Nếu người dùng chọn No, dừng vòng lặp và đóng chương trình
                    break;
                }
            }
            MessageBox.Show($"Checking process disk usage of folder {folderPath} completed!");
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
                    folderPathTextBox.Text = selectedFolderPath; // Hiển thị đường dẫn trong TextBox
                }
                else
                {
                    MessageBox.Show("Please choose a folder");
                }
            }
        }


        public async Task OpenFileAndCheckDiskUsage(string filePath)
        {
            string defaultPath = GetDefaultAppPath(filePath);

            // Mở file bằng ứng dụng mặc định
            ProcessStartInfo startInfo = new ProcessStartInfo(defaultPath);
            startInfo.Arguments = $"\"{filePath}\"";
            Process process = Process.Start(startInfo);

            // Kiểm tra xem process có phải là null không
            if (process == null)
            {
                MessageBox.Show("Cannot open file");
                return;
            }

            // Xác định ứng dụng mà hệ thống sử dụng để mở file
            string appName = process.ProcessName;
            long diskUsage = 0;
            // Kiểm tra sử dụng đĩa của quá trình ứng dụng mỗi giây trong 3 giây
            for (int i = 0; i < 3; i++)
            {
                await Task.Delay(1000); // Đợi 1 giây
                PerformanceCounter pc = new PerformanceCounter("Process", "IO Data Bytes/sec", appName);
                diskUsage += pc.RawValue / 1000000;

            }


            if (diskUsage > 0)
            {
                MessageBox.Show($"This {filePath} is not stable with disk usage: {diskUsage} Mb/s");
            }
            else
            {
                MessageBox.Show($"This {filePath} is stable with disk usage: {diskUsage} Mb/s");
            }
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
    }
}
