using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        private static readonly Random rnd = new Random();

        public Form1()
        { 
            InitializeComponent();
            num1Text.Text = rnd.Next(1, 10).ToString();
            num2Text.Text = rnd.Next(1, 10).ToString();
            num3Text.Text = rnd.Next(1, 10).ToString();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);
            
            String methodOutputString = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = methodOutputString;

            String lambdaOutputString = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = lambdaOutputString;

            if (methodOutputString.Equals(lambdaOutputString))
            {
                MessageBox.Show("Ok");
            }
        }
    }
}
