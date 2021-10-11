
namespace PRG282_Project
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbSplashScreen = new System.Windows.Forms.PictureBox();
            this.panelDesign = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBarSplashScreen);
            this.panel1.Controls.Add(this.pbLoading);
            this.panel1.Location = new System.Drawing.Point(520, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 256);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loading...";
            // 
            // progressBarSplashScreen
            // 
            this.progressBarSplashScreen.BackColor = System.Drawing.Color.Black;
            this.progressBarSplashScreen.ForeColor = System.Drawing.Color.White;
            this.progressBarSplashScreen.Location = new System.Drawing.Point(177, 90);
            this.progressBarSplashScreen.Name = "progressBarSplashScreen";
            this.progressBarSplashScreen.Size = new System.Drawing.Size(173, 10);
            this.progressBarSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSplashScreen.TabIndex = 2;
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::PRG282_Project.Properties.Resources.loading_bar;
            this.pbLoading.Location = new System.Drawing.Point(93, 7);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(343, 204);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Enabled = true;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::PRG282_Project.Properties.Resources.bc_logo;
            this.pbLogo.Location = new System.Drawing.Point(420, 107);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(536, 197);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.Image = global::PRG282_Project.Properties.Resources.splash_screen;
            this.pbSplashScreen.Location = new System.Drawing.Point(-29, 14);
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(550, 644);
            this.pbSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSplashScreen.TabIndex = 0;
            this.pbSplashScreen.TabStop = false;
            // 
            // panelDesign
            // 
            this.panelDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.panelDesign.Location = new System.Drawing.Point(-1, 0);
            this.panelDesign.Name = "panelDesign";
            this.panelDesign.Size = new System.Drawing.Size(393, 10);
            this.panelDesign.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(264, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 11);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.panel3.Location = new System.Drawing.Point(521, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 10);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 505);
            this.label2.MinimumSize = new System.Drawing.Size(400, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(595, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Developed by: Aisheel Nair|Cameron Nagel|Obakeng Mathibedi|Megan Hendry\r\n";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDesign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbSplashScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 579);
            this.MinimumSize = new System.Drawing.Size(1000, 579);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplashScreen;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.ProgressBar progressBarSplashScreen;
        private System.Windows.Forms.Timer timerSplashScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesign;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

