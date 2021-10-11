
namespace PRG282_Project
{
    partial class frmCRUDoperations
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
            this.lblCRUDFillFields = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCRUDStudentAlreadyExists = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCRUDFillFields
            // 
            this.lblCRUDFillFields.AutoSize = true;
            this.lblCRUDFillFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.lblCRUDFillFields.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRUDFillFields.ForeColor = System.Drawing.Color.Coral;
            this.lblCRUDFillFields.Location = new System.Drawing.Point(90, 91);
            this.lblCRUDFillFields.Name = "lblCRUDFillFields";
            this.lblCRUDFillFields.Size = new System.Drawing.Size(215, 13);
            this.lblCRUDFillFields.TabIndex = 28;
            this.lblCRUDFillFields.Text = "Please fill in all fields!";
            this.lblCRUDFillFields.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Niagara Engraved", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(168, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(49, 39);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "s";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCRUDStudentAlreadyExists
            // 
            this.lblCRUDStudentAlreadyExists.AutoSize = true;
            this.lblCRUDStudentAlreadyExists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.lblCRUDStudentAlreadyExists.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRUDStudentAlreadyExists.ForeColor = System.Drawing.Color.Coral;
            this.lblCRUDStudentAlreadyExists.Location = new System.Drawing.Point(90, 91);
            this.lblCRUDStudentAlreadyExists.Name = "lblCRUDStudentAlreadyExists";
            this.lblCRUDStudentAlreadyExists.Size = new System.Drawing.Size(191, 13);
            this.lblCRUDStudentAlreadyExists.TabIndex = 31;
            this.lblCRUDStudentAlreadyExists.Text = "Student Already Exists!\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.caution_CRUD;
            this.pictureBox1.Location = new System.Drawing.Point(169, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.pictureBox2.Image = global::PRG282_Project.Properties.Resources.loading_bar1;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // frmCRUDoperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 252);
            this.Controls.Add(this.lblCRUDStudentAlreadyExists);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCRUDFillFields);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(393, 252);
            this.MinimumSize = new System.Drawing.Size(393, 252);
            this.Name = "frmCRUDoperations";
            this.Text = "frmCRUDoperations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCRUDFillFields;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCRUDStudentAlreadyExists;
    }
}