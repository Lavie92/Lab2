using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxFaculty.SelectedIndex = 0;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtScore.Text == "")
                {
                    throw new Exception("Không được để trống!");
                }
                int selectedRow = GetSelectedRow(txtId.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                else
                {
                    InsertUpdate(selectedRow);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtId.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rdFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = txtScore.Text;
            dgvStudent.Rows[selectedRow].Cells[4].Value = cbxFaculty.Text;
        }
    }
}
