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
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đọc 3 số từ textbox jjkjhjik
            double so1, so2, so3;

            if (!double.TryParse(textBox1.Text.Trim(), out so1))
            {
                MessageBox.Show("Giá trị trong ô thứ nhất không phải là số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (!double.TryParse(textBox2.Text.Trim(), out so2))
            {
                MessageBox.Show("Giá trị trong ô thứ hai không phải là số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (!double.TryParse(textBox3.Text.Trim(), out so3))
            {
                MessageBox.Show("Giá trị trong ô thứ ba không phải là số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Tìm số lớn nhất
            double soLonNhat = so1;
            if (so2 > soLonNhat)
            {
                soLonNhat = so2;
            }
            else if (so3 > soLonNhat)
            {
                soLonNhat = so3;
            }

            // Tìm số nhỏ nhất
            double soNhoNhat = so1;
            if (so2 < soNhoNhat)
            {
                soNhoNhat = so2;
            }
            else if (so3 < soNhoNhat)
            {
                soNhoNhat = so3;
            }

            // Hiển thị kết quả
            textBox4.Text = soLonNhat.ToString();
            textBox5.Text = soNhoNhat.ToString();                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // khi nhấn Enter
            {
                double so1;
                if (double.TryParse(textBox1.Text.Trim(), out so1))
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

                //e.SuppressKeyPress = true; // ngăn Enter phát ra tiếng "beep"
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // khi nhấn Enter
            {
                double so2;
                if (double.TryParse(textBox2.Text.Trim(), out so2))
                {
                    // hợp lệ -> chuyển focus xuống ô nhập thứ 2
                    textBox3.Focus();
                }
                else
                {
                    // không hợp lệ -> báo lỗi
                    MessageBox.Show("Vui lòng nhập số nguyên!",
                                    "Lỗi nhập liệu",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    textBox2.Focus();
                    textBox2.SelectAll(); // bôi đen lại để người dùng nhập lại luôn
                }

                //e.SuppressKeyPress = true; // ngăn Enter phát ra tiếng "beep"
            }
        }
    }
}
