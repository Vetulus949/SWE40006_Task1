using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace task1_1
{
    public partial class Form1 : Form
    {
        private int number = 0;
        private Random random = new Random();
        private Class1 class1 = new Class1();
        //
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            int difference = class1.add(guess, number);
            label3.Text = $"sum of guess and the secret number is {difference}";
            if (guess == number) {
                label2.Text = "you guessed the number!";
            } else {
                label2.Text = "you guessed wrong :(";
            }
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            number = random.Next(1, 10);
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = random.Next(1, 10);
            label2.Text = "";
            label3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
