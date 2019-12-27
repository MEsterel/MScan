using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace MScan
{
    public partial class ParamsForm : Form
    {
        public ParamsForm()
        {
            InitializeComponent();

            int i = 0;

            foreach (DeviceInfo device in Program.DeviceInfos)
            {
                printersLstBox.Items.Add(device.Properties["Name"].get_Value().ToString());
                if (Properties.Settings.Default.DefaultDeviceID == device.DeviceID)
                {
                    printersLstBox.SetSelected(i, true);
                }

                i++;
            }

            pathTxt.Text = Properties.Settings.Default.SaveDirectory;

            dpiCmbBox.SelectedItem = Properties.Settings.Default.DefaultDPI.ToString();

            networkPrefChk.Checked = Properties.Settings.Default.PreferNetwork;
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultDeviceID =
                Program.DeviceInfos.Find(x => x.Properties["Name"].get_Value().ToString() 
                == printersLstBox.SelectedItem.ToString()).DeviceID;
            Properties.Settings.Default.Save();

            if (!Directory.Exists(pathTxt.Text))
            {
                try
                {
                    Directory.CreateDirectory(pathTxt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de créer le répertoire indiqué." + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Properties.Settings.Default.DefaultDPI = int.Parse(dpiCmbBox.SelectedItem.ToString());
            
            
            
            
            
            
            Close();
        }
    }
}
