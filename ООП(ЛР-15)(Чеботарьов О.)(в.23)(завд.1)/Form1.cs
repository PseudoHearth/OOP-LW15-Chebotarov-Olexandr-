using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР_15__Чеботарьов_О.__в._23__завд._1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOK.Text = "OK";
            lblResult.Text = "";

            btnOK2.Text = "OK";
            lblResultC.Text = "";
            lblResultS.Text = "";

            btnOK3.Text = "True or False?";
            lblResult3.Text = "";

            btnOK4.Text = "Max is...";
            lblMidResult41.Text = "";
            lblMidResult42.Text = "";
            lblResult4.Text = "";

            btnOK5.Text = "Check the upcoming number!";
            lblNumberM5.Text = "";

            btnOK6.Text = "OK";
            lblResult6.Text = "";

            btnOK7.Text = "OK";
            lblResult7.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
            //код для завдання 1
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double result = (Math.Pow(3, x)- 4 * x + (y - Math.Sqrt(Math.Abs(x))));
            lblResult.Text = result.ToString();
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtY.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOK2_Click(object sender, EventArgs e)
            //код для завдання 2
        {
            double R = Convert.ToDouble(txtR.Text);
            double result21 = 2 * Math.PI * R;
            double result22 = Math.PI * Math.Pow(R, 2);
            lblResultC.Text = result21.ToString();
            lblResultS.Text = result22.ToString();
        }

        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
            //код для завдання 3
        {
            double a = Convert.ToDouble(txtA3.Text);
            double b = Convert.ToDouble(txtB3.Text);
            double c = Convert.ToDouble(txtC3.Text);
            double d = Convert.ToDouble(txtD3.Text);
            double result3a = a - c;
            double result3b = b - d;
            if (result3a == 2 && result3b == 1)
            {
                lblResult3.Text = "True";
            }
            else if (result3a == 1 && result3b == 2)
            {
                lblResult3.Text = "True";
            }
            else if (result3a == -2 && result3b == -1)
            {
                lblResult3.Text = "True";
            }
            else if (result3a == -1 && result3b == -2)
            {
                lblResult3.Text = "True";
            }
            else
            {
                lblResult3.Text = "False";
            }
        }

        private void txtA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '8'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblMidResult42_Click(object sender, EventArgs e)
        {

        }

        private void btnOK4_Click(object sender, EventArgs e)
            //код для завдання 4
        {
            double a = Convert.ToDouble(txtA4.Text);
            double b = Convert.ToDouble(txtB4.Text);
            double c = Convert.ToDouble(txtC4.Text);
            double d = Convert.ToDouble(txtD4.Text);
            double result4a = 0;
            double result4b = 0;
            if (a > b)
            {
                lblMidResult41.Text = b.ToString();
                result4a = b;
            }
            else if (a < b)
            {
                lblMidResult41.Text = a.ToString();
                result4a = a;
            }
            else if (a == b)
            {
                lblMidResult41.Text = a.ToString();
                result4a = a;
            }
            else
            {
                lblMidResult41.Text = "Error!";
            }
            if (c > d)
            {
                lblMidResult42.Text = d.ToString();
                result4b = d;
            }
            else if (c < d)
            {
                lblMidResult42.Text = c.ToString();
                result4b = c;
            }
            else if (c == d)
            {
                lblMidResult42.Text = c.ToString();
                result4b = c;
            }
            else
            {
                lblMidResult42.Text = "Error!";
            }

            if (result4a > result4b)
            {
                lblResult4.Text = result4a.ToString();
            }
            else if (result4a < result4b)
            {
                lblResult4.Text = result4b.ToString();
            }
            else if (result4b == result4a)
            {
                lblResult4.Text = result4a.ToString();
            }
            else
            {
                lblResult4.Text = "Error!";
            }
        }

        private void txtA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void btnOK5_Click(object sender, EventArgs e)
            //Код для завдання 5
        {
            int N;

            N = Convert.ToInt32(txtNumberN5.Text);
            string str = txtNumberN5.Text;
            string str2 = str.Substring(0, 1);

            str = str.Remove(str.Length - 1);

            string final = str + str2;
            lblNumberM5.Text = final;
        }

        private void txtNumberN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtNumbers6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            //string str6 = null;
            //string[] str6z = null;
            //Int16 count6 = 0;
            //str6 = txtNumbers6.Text;
            //str6z = str6.Split();
            //for (count6 = 0; count6 < str6.Length; count6++);

            //lblResult6.Text = str6z[count6];
            //string str6 = txtNumbers6.Text;
            //List<string> str6list = str6.Split(',').ToList();

            //int[] list = new int[str6list.Count];
            //string[] str6z = str6list.ToArray();

            //var numberlist6 = new List<String>();
            //numberlist6.AddRange(str6z);
            //foreach (var value in numberlist6)
                //lblResult6.Text = numberlist6;
        }

        private void txtNumbers6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '1'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            string str7 = txtBox7.Text;
            string str7first = str7.Substring(0, str7.Length / 2);
            var str7second = str7.Substring((int)(str7.Length / 2), (int)(str7.Length / 2));

            str7first = str7first.Replace(":", ".");
            str7second = str7second.Replace("!", ".");

            string str7final = str7first + str7second;
            if (str7final.Length % 2 == 0)
            {
                lblResult7.Text = str7final;
            }
            else
            {
                lblResult7.Text = str7final;
            }
        }
    }
}
