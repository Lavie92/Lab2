using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class frmCaculator : Form
    {
        public frmCaculator()
        {
            InitializeComponent();
        }

        private void SolveClick(object sender, EventArgs e)
        {
            Button btnnSolve = (Button)sender;
            double temp = 0;
            double number1 = 0, number2 = 0;
            bool successful = false;
            successful = double.TryParse(txtNumber1.Text, out temp);
            if (successful)
            {
                number1 = temp;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi tham số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            successful = double.TryParse(txtNumber1.Text, out temp);
            if (successful)
            {
                number1 = temp;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi tham số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            successful = double.TryParse(txtNumber2.Text, out temp);
            if (successful)
            {
                number2 = temp;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi tham số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double answer = 0;
            switch (btnnSolve.Name)
            {
                case "btnSum":
                    answer += number1 + number2;
                    break;
                case "btnSub":
                    answer = number1 - number2;
                    break;
                case "btnMul":
                    answer = number1 * number2;
                    break;
                case "btnDiv":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Số bị chia không thể bằng 0", "Lỗi tham số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        answer = number1 / number2;
                    }
                    break;
                default:
                    break;
            }
            txtAnswer.Text = answer.ToString();
        }
    }
}
