using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hwid_spoofer
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            load_window(new Form3());
            
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
