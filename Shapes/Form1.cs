using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double calculatorShapes(double length, double width) => length * width;

        public double calculatorShapes(double radius) => Math.PI * radius * radius;

        public double calculatorShapes(float baseLength, double height) => 0.5 * baseLength * height;


        public void button1_Click(object sender, EventArgs e)
        {
         
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            double area = calculatorShapes(length, width);
            textBox6.Text = area.ToString();
            listBox1.Items.Add($"Rectangle: {area}");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox5.Text);
            double area = calculatorShapes(radius);
            textBox6.Text = area.ToString();
            listBox1.Items.Add($" Circle: {area}");

        }

        public void button3_Click(object sender, EventArgs e)
        {
            double baseLength = Convert.ToDouble(textBox3.Text);
            double height = Convert.ToDouble(textBox4.Text);
            double area = 0.50 * baseLength * height;
            textBox6.Text = area.ToString();
            listBox1.Items.Add($"Triangle: {area} ");

        }
    }
    }

