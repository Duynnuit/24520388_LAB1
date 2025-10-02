using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BAI_1 : Form
    {
        public BAI_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!int.TryParse(textBox1.Text.Trim(), out num1))
            {
                MessageBox.Show("Giá trị trong ô thứ nhất không phải là số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Kiểm tra textbox2
            if (!int.TryParse(textBox2.Text.Trim(), out num2))
            {
                MessageBox.Show("Giá trị trong ô thứ hai không phải là số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            sum = (num1 + num2);
            textBox3.Text = sum.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // khi nhấn Enter
            {
                int num1;
                if (int.TryParse(textBox1.Text.Trim(), out num1))
                {
                    // hợp lệ -> chuyển focus xuống ô nhập thứ 2
                    textBox2.Focus();
                }
                else
                {
                    // không hợp lệ -> báo lỗi
                    MessageBox.Show("Vui lòng nhập số nguyên!",
                                    "Lỗi nhập liệu",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    textBox1.Focus();
                    textBox1.SelectAll(); // bôi đen lại để người dùng nhập lại luôn
                }

                e.SuppressKeyPress = true; // ngăn Enter phát ra tiếng "beep"
            }
        }

    }
}
