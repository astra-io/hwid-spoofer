using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hwid_spoofer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            refresh_info();
        }

        // Refresh info
        void refresh_info()
        {
            // Mac
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }


            // Processor Guid
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String pId = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                pId = mo.Properties["processorID"].Value.ToString();
                break;
            }


            // Disk Guid
            ManagementClass mdc = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mdc2 = mdc.GetInstances();
            string dId = string.Empty;
            foreach (ManagementObject strt in mdc2)
            {
                dId += Convert.ToString(strt["VolumeSerialNumber"]);
            }

            hwid_label.Text = "HWID: " + "hwid";
            pid_label.Text = "Product ID: " + "pid";
            guid_label.Text = "Processor GUID: " + pId;
            diskguid.Text = "Disk GUID: " + dId;
            name_label.Text = "PC Name: " + Environment.MachineName.ToString();
            mac_label.Text = "MAC: " + macAddresses;
        }

        // Move Window
        int m, mx, my;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }



        // Close
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Minimize
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Load Windows
        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void SaveWindow_Click(object sender, EventArgs e)
        {
            load_window(new Form2());
        }

        private void SpoofWindow_Click(object sender, EventArgs e)
        {
            load_window(new Form3());

        }

        private void SpoofPCName_Click(object sender, EventArgs e)
        {

        }

        private void SaveDGuid_Click(object sender, EventArgs e)
        {

        }

        private Form ActiveForm = null;
        private void load_window(Form ChildForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
