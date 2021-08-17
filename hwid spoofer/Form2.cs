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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace hwid_spoofer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            refresh_info();
        }

        public class data
        {
            public string mac { get; set; }
            public string pcname { get; set; }
            public string diskguid { get; set; }
            public string processorguid { get; set; }
        }


        // Save Mac
        private void SaveMac_Click(object sender, EventArgs e)
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            List<data> _data = new List<data>();
            _data.Add(new data()
            {
                mac = macAddresses
            });

            string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"saves.json", json);
            MessageBox.Show("Sucefully saved MAC Number: " + macAddresses);
        }


        // Save PC Name
        private void SavePCName_Click(object sender, EventArgs e)
        {
            List<data> _data = new List<data>();
            _data.Add(new data()
            {
                pcname = Environment.MachineName.ToString()
            });

            string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"saves.json", json);
            MessageBox.Show("Sucefully saved PC Name: " + Environment.MachineName.ToString());
        }


        // Save Disk Guid
        private void SaveDGuid_Click(object sender, EventArgs e)
        {
            ManagementClass mdc = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mdc2 = mdc.GetInstances();
            string dId = string.Empty;
            foreach (ManagementObject strt in mdc2)
            {
                dId += Convert.ToString(strt["VolumeSerialNumber"]);
            }

            List<data> _data = new List<data>();
            _data.Add(new data()
            {
                diskguid = dId
            });

            string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"saves.json", json);
            MessageBox.Show("Sucefully saved Disk GUID: " + dId);
        }


        // Save processor guid
        private void SavePGuid_Click(object sender, EventArgs e)
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String pId = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                pId = mo.Properties["processorID"].Value.ToString();
                break;
            }


            List<data> _data = new List<data>();
            _data.Add(new data()
            {
                processorguid = pId
            });

            string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"saves.json", json);
            MessageBox.Show("Sucefully saved Processor GUID: " + pId);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveHWID_Click(object sender, EventArgs e)
        {

        }

        
    }
}
