using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace MScan
{
    public static class Program
    {
        public static List<DeviceInfo> DeviceInfos { get; private set; } = new List<DeviceInfo>();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadScanners();
            LoadPath();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void LoadPath()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.SaveDirectory))
            {
                Properties.Settings.Default.SaveDirectory = 
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Scanned Documents");
                Properties.Settings.Default.Save();
            }
        }

        private static void LoadScanners()
        {
            var deviceManager = new DeviceManager();

            foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
            {
                if (deviceInfo.Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                DeviceInfos.Add(deviceInfo);

                Console.WriteLine(deviceInfo.Properties["Name"].get_Value());
                Console.WriteLine("ID: " + deviceInfo.DeviceID);
                Console.WriteLine("Description: " + deviceInfo.Properties["Description"].get_Value());
                Console.WriteLine("Port: " + deviceInfo.Properties["Port"].get_Value());
                Console.WriteLine("-----------------------------");
            }

            if (String.IsNullOrEmpty(Properties.Settings.Default.DefaultDeviceID)
                    || !DeviceInfos.Exists(x => x.DeviceID == Properties.Settings.Default.DefaultDeviceID))
            {
                Properties.Settings.Default.DefaultDeviceID = DeviceInfos[0].DeviceID;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.PreferNetwork)
            {
                DeviceInfo defaultDevice = DeviceInfos.Find(x => x.DeviceID == Properties.Settings.Default.DefaultDeviceID);

                if (defaultDevice.Properties["Port"].get_Value().ToString().ToLower().Contains("usb"))
                {
                    var wirelessDevicesInfos = DeviceInfos.Where(x => !x.Properties["Port"].get_Value().ToString().ToLower().Contains("usb")).ToArray();
                    
                    if (wirelessDevicesInfos.Count() > 0)
                    {
                        Properties.Settings.Default.DefaultDeviceID = wirelessDevicesInfos[0].DeviceID;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }
    }
}
