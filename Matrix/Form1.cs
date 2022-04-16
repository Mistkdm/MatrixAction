using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Сложение";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {

                Matrix.FillMatrix(FirstMatrix, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                Matrix.FillMatrix(SecondMatrix, int.Parse(textBox3.Text), int.Parse(textBox4.Text));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            
            Matrix firstmatrix = new Matrix(int.Parse(textBox1.Text), int.Parse(textBox2.Text), in FirstMatrix);
            Matrix secondmatrix = new Matrix(int.Parse(textBox3.Text), int.Parse(textBox4.Text), in SecondMatrix);
            switch (comboBox1.Text)
            {
                case "Сложение":
                    firstmatrix.Addiction(secondmatrix, ResultMatrix);
                    break;
                case "Вычитание":
                    firstmatrix.Substraction(secondmatrix, ResultMatrix);
                    break;
                case "Умножение":
                    firstmatrix.Multiplication(secondmatrix, ResultMatrix);
                    break;
            }
        }
    }
}
