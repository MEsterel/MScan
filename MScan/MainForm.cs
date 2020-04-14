using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace MScan
{
    public partial class MainForm : Form
    {
        public string FileName { get; set; }

        public MainForm()
        {
            InitializeComponent();

            
        }

        private void numerizeBtn_Click(object sender, EventArgs e)
        {
            string previousTxt = numerizeBtn.Text;
            numerizeBtn.Text = "Veuillez patienter...";

            try
            {
                string path = GenerateFileName();

                // Connect to the first available scanner
                var device = Program.DeviceInfos.Find(x => x.DeviceID == Properties.Settings.Default.DefaultDeviceID).Connect();

                // Select the scanner
                var scannerItem = device.Items[1];

                int resolution = Properties.Settings.Default.DefaultDPI;
                int width_pixel = 1250 * Properties.Settings.Default.DefaultDPI / 150;
                int height_pixel = 1700 * Properties.Settings.Default.DefaultDPI / 150;
                int color_mode = 1;
                AdjustScannerSettings(scannerItem, resolution, 0, 0, width_pixel, height_pixel, 0, 0, color_mode);

                CommonDialogClass dlg = new CommonDialogClass();
                object scanResult = dlg.ShowTransfer(scannerItem, WIA.FormatID.wiaFormatPNG, true);

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    if (!Directory.Exists(Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(path));
                    }

                    imageFile.SaveFile(path);

                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        pctBox.Image = new Bitmap(fs);
                    }
                }

                numerizeBtn.Text = "Effacer et recommencer";
            }
            catch (COMException ex)
            {
                // Display the exception in the console.
                Console.WriteLine(ex.ToString());

                // Convert the error code to UINT
                uint errorCode = (uint)ex.ErrorCode;

                // See the error codes
                if (errorCode == 0x80210006)
                {
                    Console.WriteLine("The scanner is busy or isn't ready");
                    MessageBox.Show("Le scanneur est occupé ou n'est pas prêt.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    Console.WriteLine("The scanning process has been cancelled.");
                    MessageBox.Show("La numérisation a été annulée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x8021000C)
                {
                    Console.WriteLine("There is an incorrect setting on the WIA device.");
                    MessageBox.Show("Un paramètre est incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210005)
                {
                    Console.WriteLine("The device is offline. Make sure the device is powered on and connected to the PC.");
                    MessageBox.Show("Le scanneur est déconnecté. Assurez-vous qu'il est allumé et connecté au PC.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210001)
                {
                    Console.WriteLine("An unknown error has occurred with the WIA device.");
                    MessageBox.Show("Une erreur inconnue est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                numerizeBtn.Text = previousTxt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred.");
                MessageBox.Show("Une erreur est survenue. " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numerizeBtn.Text = previousTxt;
            }
        }

        private string GenerateFileName()
        {
            if (FileName != null) // If it is not empty, a correct one has already been generated
                return FileName;

            string SaveDirectory = Properties.Settings.Default.SaveDirectory;

            //if (File.Exists(Path.Combine(SaveDirectory, "Image.png")))
            //{
            //    int i = 1;
            //    while (File.Exists(Path.Combine(SaveDirectory, "Image (" + i + ").png")))
            //    {
            //        i++;
            //    }
            //    FileName = Path.Combine(SaveDirectory, "Image (" + i + ").png");
            //}
            //else
            //{
            //    FileName = Path.Combine(SaveDirectory, "Image.png");
            //}

            FileName = "Scan " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

            FileName = FileName.Replace(".", "_");
            FileName = FileName.Replace("/", "_");
            FileName = FileName.Replace(":", "_");
            FileName += ".png";

            FileName = Path.Combine(SaveDirectory, FileName);

            return FileName;
        }

        /// <summary>
        /// Adjusts the settings of the scanner with the providen parameters.
        /// </summary>
        /// <param name="scannnerItem">Scanner Item</param>
        /// <param name="scanResolutionDPI">Provide the DPI resolution that should be used e.g 150</param>
        /// <param name="scanStartLeftPixel"></param>
        /// <param name="scanStartTopPixel"></param>
        /// <param name="scanWidthPixels"></param>
        /// <param name="scanHeightPixels"></param>
        /// <param name="brightnessPercents"></param>
        /// <param name="contrastPercents">Modify the contrast percent</param>
        /// <param name="colorMode">Set the color mode</param>
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        /// <summary>
        /// Modify a WIA property
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private void parametersBtn_Click(object sender, EventArgs e)
        {
            ParamsForm paramsForm = new ParamsForm();
            paramsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
