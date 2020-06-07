using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            C = new Calc();

            label1.Text = "0";
        }
        Calc C;

        int k;
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (label1.Text.IndexOf("∞") != -1)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (label1.Text[0] == '-')
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                    label1.Text = label1.Text.Remove(1, 1);
        }
        private bool CanPress()
        {
            if (!button1.Enabled)            //*
                return false;

            if (!button2.Enabled)           ///
                return false;

            if (!button3.Enabled)           //+
                return false;

            if (!button4.Enabled)           //-
                return false;

            if (!button5.Enabled)           //sqrt
                return false;

            if (!button6.Enabled)           //degreeY
                return false;

            return true;
        }
        private void FreeButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button23.Enabled = true;
        }


       
 
 

   

    
  
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            label1.Text += "2";

            CorrectNumber();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label1.Text += "1";

            CorrectNumber();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            label1.Text += "3";

            CorrectNumber();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            label1.Text += "4";

            CorrectNumber();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            label1.Text += "5";

            CorrectNumber();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += "6";

            CorrectNumber();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            label1.Text += "7";

            CorrectNumber();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            label1.Text += "8";

            CorrectNumber();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            label1.Text += "9";

            CorrectNumber();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label1.Text += "0";

            CorrectNumber();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button3.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button4.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button1.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button2.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            if (!button1.Enabled)
                label1.Text = C.Multiplication(Convert.ToDouble(label1.Text)).ToString();

            if (!button2.Enabled)
                label1.Text = C.Division(Convert.ToDouble(label1.Text)).ToString();

            if (!button3.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();

            if (!button4.Enabled)
                label1.Text = C.Subtraction(Convert.ToDouble(label1.Text)).ToString();

            if (!button5.Enabled)
                label1.Text = C.SqrtX(Convert.ToDouble(label1.Text)).ToString();

            if (!button6.Enabled)
                label1.Text = C.DegreeY(Convert.ToDouble(label1.Text)).ToString();

            if (!button23.Enabled)
                label1.Text = C.Mod(Convert.ToDouble(label1.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
                label1.Text += ",";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                label1.Text = "-" + label1.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label1.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(label1.Text) == (int)(Convert.ToDouble(label1.Text))) &&
                    ((Convert.ToDouble(label1.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(label1.Text));

                    label1.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button5.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button6.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button23.Enabled = false;

                label1.Text = "0";
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                button23.Enabled = false;

                label1.Text = "0";
            }
        }
    }
}
