using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Calculator size -> 1185,591
namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 381;
            txtDisplay.Width = 333;
        }

        private void sciencetificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 746;
            txtDisplay.Width = 697;
        }

        private void tempertureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1185;
            txtDisplay.Width = 697;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            // When button is click we refresh default value.
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            //Casting the button obj
            Button num = (Button)sender;

            if (num.Text == ".")
            {
                // We use checker to avoid decimal tiwce
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }  
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }


        }

        //Backspace button for removing
        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        //Perfom Addition,Multiple,Subtract...etc.
        private void ArithmaticButton(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            showLabel.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void equalButtonClick(object sender, EventArgs e)
        {
            showLabel.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
