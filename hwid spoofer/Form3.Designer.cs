
namespace hwid_spoofer
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.SpoofPCName = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.guid_label = new System.Windows.Forms.Label();
            this.pid_label = new System.Windows.Forms.Label();
            this.hwid_label = new System.Windows.Forms.Label();
            this.SpoofGuid = new System.Windows.Forms.Button();
            this.SpoofPID = new System.Windows.Forms.Button();
            this.SpoofHWID = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SpoofPCName);
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.guid_label);
            this.panel1.Controls.Add(this.pid_label);
            this.panel1.Controls.Add(this.hwid_label);
            this.panel1.Controls.Add(this.SpoofGuid);
            this.panel1.Controls.Add(this.SpoofPID);
            this.panel1.Controls.Add(this.SpoofHWID);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 439);
            this.panel1.TabIndex = 1;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Spoof MAC";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SpoofPCName
            // 
            this.SpoofPCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SpoofPCName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpoofPCName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpoofPCName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SpoofPCName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofPCName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofPCName.ForeColor = System.Drawing.Color.DarkGray;
            this.SpoofPCName.Location = new System.Drawing.Point(13, 181);
            this.SpoofPCName.Name = "SpoofPCName";
            this.SpoofPCName.Size = new System.Drawing.Size(288, 33);
            this.SpoofPCName.TabIndex = 13;
            this.SpoofPCName.Text = "Spoof PC Name";
            this.SpoofPCName.UseVisualStyleBackColor = false;
            this.SpoofPCName.Click += new System.EventHandler(this.SpoofPCName_Click);
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
            // SpoofGuid
            // 
            this.SpoofGuid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SpoofGuid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpoofGuid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpoofGuid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SpoofGuid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofGuid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofGuid.ForeColor = System.Drawing.Color.DarkGray;
            this.SpoofGuid.Location = new System.Drawing.Point(13, 103);
            this.SpoofGuid.Name = "SpoofGuid";
            this.SpoofGuid.Size = new System.Drawing.Size(288, 33);
            this.SpoofGuid.TabIndex = 8;
            this.SpoofGuid.Text = "Spoof Processor Guid";
            this.SpoofGuid.UseVisualStyleBackColor = false;
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
            this.SpoofPID.Text = "Spoof Product ID";
            this.SpoofPID.UseVisualStyleBackColor = false;
            // 
            // SpoofHWID
            // 
            this.SpoofHWID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SpoofHWID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpoofHWID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpoofHWID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.SpoofHWID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofHWID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofHWID.ForeColor = System.Drawing.Color.DarkGray;
            this.SpoofHWID.Location = new System.Drawing.Point(13, 25);
            this.SpoofHWID.Name = "SpoofHWID";
            this.SpoofHWID.Size = new System.Drawing.Size(288, 33);
            this.SpoofHWID.TabIndex = 5;
            this.SpoofHWID.Text = "Spoof HWID";
            this.SpoofHWID.UseVisualStyleBackColor = false;
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
            this.SaveDGuid.Location = new System.Drawing.Point(13, 142);
            this.SaveDGuid.Name = "SaveDGuid";
            this.SaveDGuid.Size = new System.Drawing.Size(288, 33);
            this.SaveDGuid.TabIndex = 18;
            this.SaveDGuid.Text = "Save Disk Guid";
            this.SaveDGuid.UseVisualStyleBackColor = false;
            this.SaveDGuid.Click += new System.EventHandler(this.SaveDGuid_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 400);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label diskguid;
        private System.Windows.Forms.Label mac_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SpoofPCName;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label guid_label;
        private System.Windows.Forms.Label pid_label;
        private System.Windows.Forms.Label hwid_label;
        private System.Windows.Forms.Button SpoofGuid;
        private System.Windows.Forms.Button SpoofPID;
        private System.Windows.Forms.Button SpoofHWID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button SaveDGuid;
    }
}