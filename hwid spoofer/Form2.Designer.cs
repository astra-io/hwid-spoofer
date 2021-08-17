
namespace hwid_spoofer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.diskguid = new System.Windows.Forms.Label();
            this.mac_label = new System.Windows.Forms.Label();
            this.SaveMac = new System.Windows.Forms.Button();
            this.SavePCName = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.guid_label = new System.Windows.Forms.Label();
            this.pid_label = new System.Windows.Forms.Label();
            this.hwid_label = new System.Windows.Forms.Label();
            this.SpoofPGuid = new System.Windows.Forms.Button();
            this.SpoofPID = new System.Windows.Forms.Button();
            this.SaveHWID = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SaveDGuid = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveDGuid);
            this.panel1.Controls.Add(this.diskguid);
            this.panel1.Controls.Add(this.mac_label);
            this.panel1.Controls.Add(this.SaveMac);
            this.panel1.Controls.Add(this.SavePCName);
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.guid_label);
            this.panel1.Controls.Add(this.pid_label);
            this.panel1.Controls.Add(this.hwid_label);
            this.panel1.Controls.Add(this.SpoofPGuid);
            this.panel1.Controls.Add(this.SpoofPID);
            this.panel1.Controls.Add(this.SaveHWID);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 412);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // diskguid
            // 
            this.diskguid.AutoSize = true;
            this.diskguid.ForeColor = System.Drawing.Color.DarkGray;
            this.diskguid.Location = new System.Drawing.Point(337, 113);
            this.diskguid.Name = "diskguid";
            this.diskguid.Size = new System.Drawing.Size(59, 13);
            this.diskguid.TabIndex = 16;
            this.diskguid.Text = "Disk Guid: ";
            // 
            // mac_label
            // 
            this.mac_label.AutoSize = true;
            this.mac_label.ForeColor = System.Drawing.Color.DarkGray;
            this.mac_label.Location = new System.Drawing.Point(336, 171);
            this.mac_label.Name = "mac_label";
            this.mac_label.Size = new System.Drawing.Size(36, 13);
            this.mac_label.TabIndex = 15;
            this.mac_label.Text = "MAC: ";
            // 
            // SaveMac
            // 
            this.SaveMac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveMac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveMac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SaveMac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SaveMac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SaveMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMac.ForeColor = System.Drawing.Color.DarkGray;
            this.SaveMac.Location = new System.Drawing.Point(13, 219);
            this.SaveMac.Name = "SaveMac";
            this.SaveMac.Size = new System.Drawing.Size(288, 33);
            this.SaveMac.TabIndex = 14;
            this.SaveMac.Text = "Save MAC";
            this.SaveMac.UseVisualStyleBackColor = false;
            this.SaveMac.Click += new System.EventHandler(this.SaveMac_Click);
            // 
            // SavePCName
            // 
            this.SavePCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SavePCName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePCName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SavePCName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SavePCName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SavePCName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePCName.ForeColor = System.Drawing.Color.DarkGray;
            this.SavePCName.Location = new System.Drawing.Point(12, 180);
            this.SavePCName.Name = "SavePCName";
            this.SavePCName.Size = new System.Drawing.Size(288, 33);
            this.SavePCName.TabIndex = 13;
            this.SavePCName.Text = "Save PC Name";
            this.SavePCName.UseVisualStyleBackColor = false;
            this.SavePCName.Click += new System.EventHandler(this.SavePCName_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.Color.DarkGray;
            this.name_label.Location = new System.Drawing.Point(337, 142);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(58, 13);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "PC Name: ";
            // 
            // guid_label
            // 
            this.guid_label.AutoSize = true;
            this.guid_label.ForeColor = System.Drawing.Color.DarkGray;
            this.guid_label.Location = new System.Drawing.Point(337, 84);
            this.guid_label.Name = "guid_label";
            this.guid_label.Size = new System.Drawing.Size(85, 13);
            this.guid_label.TabIndex = 11;
            this.guid_label.Text = "Processor Guid: ";
            // 
            // pid_label
            // 
            this.pid_label.AutoSize = true;
            this.pid_label.ForeColor = System.Drawing.Color.DarkGray;
            this.pid_label.Location = new System.Drawing.Point(337, 55);
            this.pid_label.Name = "pid_label";
            this.pid_label.Size = new System.Drawing.Size(64, 13);
            this.pid_label.TabIndex = 10;
            this.pid_label.Text = "Product ID: ";
            // 
            // hwid_label
            // 
            this.hwid_label.AutoSize = true;
            this.hwid_label.ForeColor = System.Drawing.Color.DarkGray;
            this.hwid_label.Location = new System.Drawing.Point(337, 25);
            this.hwid_label.Name = "hwid_label";
            this.hwid_label.Size = new System.Drawing.Size(43, 13);
            this.hwid_label.TabIndex = 9;
            this.hwid_label.Text = "HWID: ";
            // 
            // SpoofPGuid
            // 
            this.SpoofPGuid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SpoofPGuid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpoofPGuid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpoofPGuid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SpoofPGuid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofPGuid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofPGuid.ForeColor = System.Drawing.Color.DarkGray;
            this.SpoofPGuid.Location = new System.Drawing.Point(12, 103);
            this.SpoofPGuid.Name = "SpoofPGuid";
            this.SpoofPGuid.Size = new System.Drawing.Size(288, 33);
            this.SpoofPGuid.TabIndex = 8;
            this.SpoofPGuid.Text = "Save Processor Guid";
            this.SpoofPGuid.UseVisualStyleBackColor = false;
            this.SpoofPGuid.Click += new System.EventHandler(this.SavePGuid_Click);
            // 
            // SpoofPID
            // 
            this.SpoofPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SpoofPID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpoofPID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpoofPID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SpoofPID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofPID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofPID.ForeColor = System.Drawing.Color.DarkGray;
            this.SpoofPID.Location = new System.Drawing.Point(13, 64);
            this.SpoofPID.Name = "SpoofPID";
            this.SpoofPID.Size = new System.Drawing.Size(288, 33);
            this.SpoofPID.TabIndex = 7;
            this.SpoofPID.Text = "Save Product ID";
            this.SpoofPID.UseVisualStyleBackColor = false;
            // 
            // SaveHWID
            // 
            this.SaveHWID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveHWID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveHWID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SaveHWID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SaveHWID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SaveHWID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveHWID.ForeColor = System.Drawing.Color.DarkGray;
            this.SaveHWID.Location = new System.Drawing.Point(13, 25);
            this.SaveHWID.Name = "SaveHWID";
            this.SaveHWID.Size = new System.Drawing.Size(288, 33);
            this.SaveHWID.TabIndex = 5;
            this.SaveHWID.Text = "Save HWID";
            this.SaveHWID.UseVisualStyleBackColor = false;
            this.SaveHWID.Click += new System.EventHandler(this.SaveHWID_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(320, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 290);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 290);
            this.panel8.TabIndex = 4;
            // 
            // SaveDGuid
            // 
            this.SaveDGuid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveDGuid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveDGuid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SaveDGuid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SaveDGuid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SaveDGuid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDGuid.ForeColor = System.Drawing.Color.DarkGray;
            this.SaveDGuid.Location = new System.Drawing.Point(13, 141);
            this.SaveDGuid.Name = "SaveDGuid";
            this.SaveDGuid.Size = new System.Drawing.Size(288, 33);
            this.SaveDGuid.TabIndex = 17;
            this.SaveDGuid.Text = "Save Disk Guid";
            this.SaveDGuid.UseVisualStyleBackColor = false;
            this.SaveDGuid.Click += new System.EventHandler(this.SaveDGuid_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 400);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label diskguid;
        private System.Windows.Forms.Label mac_label;
        private System.Windows.Forms.Button SaveMac;
        private System.Windows.Forms.Button SavePCName;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label guid_label;
        private System.Windows.Forms.Label pid_label;
        private System.Windows.Forms.Label hwid_label;
        private System.Windows.Forms.Button SpoofPGuid;
        private System.Windows.Forms.Button SpoofPID;
        private System.Windows.Forms.Button SaveHWID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button SaveDGuid;
    }
}