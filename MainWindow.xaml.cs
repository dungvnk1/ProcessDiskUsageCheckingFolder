using System;
using System.IO;
using System.Windows;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace CheckingDiskUsageFolder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void CheckDiskUsageButton_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = FolderUrlTextBox.Text;
            foreach (var file in Directory.EnumerateFiles(folderPath))
            {
                await OpenFileAndCheckDiskUsage(file);
               
                // Hỏi người dùng có muốn kiểm tra file tiếp theo không
                MessageBoxResult result = MessageBox.Show("Do you want to open next file?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                {
                    // Nếu người dùng chọn No, dừng vòng lặp và đóng chương trình
                    break;
                }
            }
        }

        public async Task OpenFileAndCheckDiskUsage(string filePath)
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

            // Đợi cho đến khi ứng dụng khởi động
            //process.WaitForInputIdle();

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
    }
}
