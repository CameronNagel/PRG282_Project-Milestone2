
namespace PRG282_Project
{
    partial class frmExceptions
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
            this.lblFillAllFields = new System.Windows.Forms.Label();
            this.btnExceptionOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserAlreadyExists = new System.Windows.Forms.Label();
            this.lblInvalidUsernamePassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFillAllFields
            // 
            this.lblFillAllFields.AutoSize = true;
            this.lblFillAllFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.lblFillAllFields.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillAllFields.Location = new System.Drawing.Point(81, 87);
            this.lblFillAllFields.Name = "lblFillAllFields";
            this.lblFillAllFields.Size = new System.Drawing.Size(215, 13);
            this.lblFillAllFields.TabIndex = 1;
            this.lblFillAllFields.Text = "Please fill in all fields!";
            this.lblFillAllFields.Visible = false;
            // 
            // btnExceptionOK
            // 
            this.btnExceptionOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.btnExceptionOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExceptionOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(125)))), ((int)(((byte)(214)))));
            this.btnExceptionOK.FlatAppearance.BorderSize = 2;
            this.btnExceptionOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceptionOK.Font = new System.Drawing.Font("Niagara Engraved", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExceptionOK.Location = new System.Drawing.Point(157, 112);
            this.btnExceptionOK.Name = "btnExceptionOK";
            this.btnExceptionOK.Size = new System.Drawing.Size(49, 39);
            this.btnExceptionOK.TabIndex = 23;
            this.btnExceptionOK.Text = "OK";
            this.btnExceptionOK.UseVisualStyleBackColor = false;
            this.btnExceptionOK.Click += new System.EventHandler(this.btnExceptionOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.caution;
            this.pictureBox1.Location = new System.Drawing.Point(157, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.pictureBox2.Image = global::PRG282_Project.Properties.Resources.loading_bar1;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblUserAlreadyExists
            // 
            this.lblUserAlreadyExists.AutoSize = true;
            this.lblUserAlreadyExists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.lblUserAlreadyExists.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAlreadyExists.Location = new System.Drawing.Point(81, 87);
            this.lblUserAlreadyExists.Name = "lblUserAlreadyExists";
            this.lblUserAlreadyExists.Size = new System.Drawing.Size(199, 13);
            this.lblUserAlreadyExists.TabIndex = 26;
            this.lblUserAlreadyExists.Text = "Username already exists!";
            this.lblUserAlreadyExists.Visible = false;
            // 
            // lblInvalidUsernamePassword
            // 
            this.lblInvalidUsernamePassword.AutoSize = true;
            this.lblInvalidUsernamePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(176)))));
            this.lblInvalidUsernamePassword.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidUsernamePassword.Location = new System.Drawing.Point(61, 87);
            this.lblInvalidUsernamePassword.Name = "lblInvalidUsernamePassword";
            this.lblInvalidUsernamePassword.Size = new System.Drawing.Size(239, 13);
            this.lblInvalidUsernamePassword.TabIndex = 27;
            this.lblInvalidUsernamePassword.Text = "Invalid username or password!";
            this.lblInvalidUsernamePassword.Visible = false;
            // 
            // frmExceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(365, 238);
            this.Controls.Add(this.lblInvalidUsernamePassword);
            this.Controls.Add(this.lblUserAlreadyExists);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExceptionOK);
            this.Controls.Add(this.lblFillAllFields);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExceptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFillAllFields;
        private System.Windows.Forms.Button btnExceptionOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserAlreadyExists;
        private System.Windows.Forms.Label lblInvalidUsernamePassword;
    }
}