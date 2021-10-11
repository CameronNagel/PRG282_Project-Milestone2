
namespace PRG282_Project
{
    partial class frmAddStudentModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudentModules));
            this.btnAddStudentModule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbModules = new System.Windows.Forms.GroupBox();
            this.tbStudentNumberModules = new System.Windows.Forms.TextBox();
            this.lblStudentNumberModules = new System.Windows.Forms.Label();
            this.cbModuleName = new System.Windows.Forms.ComboBox();
            this.cbModuleCode = new System.Windows.Forms.ComboBox();
            this.tbLinks = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblModuleLinks = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.lblModuleInformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBackToGUI = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.gbModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToGUI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudentModule
            // 
            this.btnAddStudentModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudentModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.btnAddStudentModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentModule.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentModule.Location = new System.Drawing.Point(177, 433);
            this.btnAddStudentModule.Name = "btnAddStudentModule";
            this.btnAddStudentModule.Size = new System.Drawing.Size(148, 49);
            this.btnAddStudentModule.TabIndex = 48;
            this.btnAddStudentModule.Text = "Add Modules";
            this.btnAddStudentModule.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.gbModules);
            this.panel2.Location = new System.Drawing.Point(17, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 233);
            this.panel2.TabIndex = 47;
            // 
            // gbModules
            // 
            this.gbModules.BackColor = System.Drawing.Color.White;
            this.gbModules.Controls.Add(this.tbStudentNumberModules);
            this.gbModules.Controls.Add(this.lblStudentNumberModules);
            this.gbModules.Controls.Add(this.cbModuleName);
            this.gbModules.Controls.Add(this.cbModuleCode);
            this.gbModules.Controls.Add(this.tbLinks);
            this.gbModules.Controls.Add(this.tbDescription);
            this.gbModules.Controls.Add(this.lblModuleLinks);
            this.gbModules.Controls.Add(this.lblModuleName);
            this.gbModules.Controls.Add(this.lblModuleCode);
            this.gbModules.Controls.Add(this.lblModuleInformation);
            this.gbModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbModules.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.gbModules.Location = new System.Drawing.Point(17, 13);
            this.gbModules.Name = "gbModules";
            this.gbModules.Size = new System.Drawing.Size(444, 204);
            this.gbModules.TabIndex = 42;
            this.gbModules.TabStop = false;
            this.gbModules.Text = "Student Modules";
            // 
            // tbStudentNumberModules
            // 
            this.tbStudentNumberModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStudentNumberModules.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentNumberModules.Location = new System.Drawing.Point(217, 35);
            this.tbStudentNumberModules.Name = "tbStudentNumberModules";
            this.tbStudentNumberModules.Size = new System.Drawing.Size(205, 21);
            this.tbStudentNumberModules.TabIndex = 21;
            // 
            // lblStudentNumberModules
            // 
            this.lblStudentNumberModules.AutoSize = true;
            this.lblStudentNumberModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.lblStudentNumberModules.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumberModules.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumberModules.Location = new System.Drawing.Point(28, 35);
            this.lblStudentNumberModules.Name = "lblStudentNumberModules";
            this.lblStudentNumberModules.Size = new System.Drawing.Size(119, 13);
            this.lblStudentNumberModules.TabIndex = 20;
            this.lblStudentNumberModules.Text = "Student Number";
            // 
            // cbModuleName
            // 
            this.cbModuleName.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModuleName.FormattingEnabled = true;
            this.cbModuleName.Location = new System.Drawing.Point(217, 88);
            this.cbModuleName.Name = "cbModuleName";
            this.cbModuleName.Size = new System.Drawing.Size(205, 21);
            this.cbModuleName.TabIndex = 19;
            // 
            // cbModuleCode
            // 
            this.cbModuleCode.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModuleCode.FormattingEnabled = true;
            this.cbModuleCode.Location = new System.Drawing.Point(217, 62);
            this.cbModuleCode.Name = "cbModuleCode";
            this.cbModuleCode.Size = new System.Drawing.Size(205, 21);
            this.cbModuleCode.TabIndex = 18;
            // 
            // tbLinks
            // 
            this.tbLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLinks.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLinks.Location = new System.Drawing.Point(217, 142);
            this.tbLinks.Name = "tbLinks";
            this.tbLinks.Size = new System.Drawing.Size(205, 21);
            this.tbLinks.TabIndex = 13;
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(217, 115);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(205, 21);
            this.tbDescription.TabIndex = 10;
            // 
            // lblModuleLinks
            // 
            this.lblModuleLinks.AutoSize = true;
            this.lblModuleLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.lblModuleLinks.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleLinks.ForeColor = System.Drawing.Color.White;
            this.lblModuleLinks.Location = new System.Drawing.Point(28, 150);
            this.lblModuleLinks.Name = "lblModuleLinks";
            this.lblModuleLinks.Size = new System.Drawing.Size(47, 13);
            this.lblModuleLinks.TabIndex = 3;
            this.lblModuleLinks.Text = "Links";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.lblModuleName.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.ForeColor = System.Drawing.Color.White;
            this.lblModuleName.Location = new System.Drawing.Point(28, 96);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(39, 13);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Name";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.lblModuleCode.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleCode.ForeColor = System.Drawing.Color.White;
            this.lblModuleCode.Location = new System.Drawing.Point(28, 64);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(95, 13);
            this.lblModuleCode.TabIndex = 2;
            this.lblModuleCode.Text = "Module Code";
            // 
            // lblModuleInformation
            // 
            this.lblModuleInformation.AutoSize = true;
            this.lblModuleInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.lblModuleInformation.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleInformation.ForeColor = System.Drawing.Color.White;
            this.lblModuleInformation.Location = new System.Drawing.Point(28, 123);
            this.lblModuleInformation.Name = "lblModuleInformation";
            this.lblModuleInformation.Size = new System.Drawing.Size(95, 13);
            this.lblModuleInformation.TabIndex = 1;
            this.lblModuleInformation.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.bc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pbBackToGUI
            // 
            this.pbBackToGUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackToGUI.Image = global::PRG282_Project.Properties.Resources.back_button;
            this.pbBackToGUI.Location = new System.Drawing.Point(0, 1);
            this.pbBackToGUI.Name = "pbBackToGUI";
            this.pbBackToGUI.Size = new System.Drawing.Size(35, 30);
            this.pbBackToGUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackToGUI.TabIndex = 50;
            this.pbBackToGUI.TabStop = false;
            this.pbBackToGUI.Click += new System.EventHandler(this.pbBackToGUI_Click);
            // 
            // frmAddStudentModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 540);
            this.Controls.Add(this.pbBackToGUI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddStudentModule);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(522, 579);
            this.MinimumSize = new System.Drawing.Size(522, 579);
            this.Name = "frmAddStudentModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Modules";
            this.panel2.ResumeLayout(false);
            this.gbModules.ResumeLayout(false);
            this.gbModules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToGUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudentModule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbModules;
        private System.Windows.Forms.TextBox tbStudentNumberModules;
        private System.Windows.Forms.Label lblStudentNumberModules;
        private System.Windows.Forms.ComboBox cbModuleName;
        private System.Windows.Forms.ComboBox cbModuleCode;
        private System.Windows.Forms.TextBox tbLinks;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblModuleLinks;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Label lblModuleInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBackToGUI;
    }
}