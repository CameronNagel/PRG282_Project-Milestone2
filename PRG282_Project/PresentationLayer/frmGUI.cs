using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmGUI : Form
    {
       
        public frmGUI()
        {
            InitializeComponent();
          
            
        }

        private void frmGUI_Load(object sender, EventArgs e)
        {
            PopulateSampleData();
            customDataGrid();
        }

        public void PopulateSampleData()
        {
            List<ImageList> imageList = new List<ImageList>();
           
            dgvDisplayStudentData.Rows.Add(576101, "Kevin", "De Bruyne", "image", "2000/05/15", "Male", "0788125432", "21 Park Avenue, Pretoria", "PRG281");
            dgvDisplayStudentData.Rows.Add(576222, "Raheem", "Sterling", "image", "2001/08/02", "Male", "0785542311", "10 Charlstown Road, Pretoria", "PRG281");
            dgvDisplayStudentData.Rows.Add(576541, "Jack", "Grealish", "image", "1999/06/10", "Male", "0677224309", "21 Doring Avenue, Pretoria", "PRG281");
            dgvDisplayStudentData.Rows.Add(576204, "Riyad", "Mahrez", "image", "1999/06/10", "Male", "0677224309", "21 Doring Avenue, Pretoria", "PRG281");
        }

        public void customDataGrid()
        {
            dgvDisplayStudentData.BorderStyle = BorderStyle.None;
            dgvDisplayStudentData.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvDisplayStudentData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDisplayStudentData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0,178,223);
            dgvDisplayStudentData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDisplayStudentData.ColumnHeadersDefaultCellStyle.Font = new Font("OCR-A", 9);
            dgvDisplayStudentData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 49, 64);
            dgvDisplayStudentData.ColumnHeadersDefaultCellStyle.ForeColor= Color.FromArgb(255, 255, 255);
           

        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStudent addNewStudent = new frmAddStudent();
            addNewStudent.Show();
        }
    }
}
