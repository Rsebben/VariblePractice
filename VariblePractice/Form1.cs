using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariblePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputLabel.Text = $"{playerName} is number {playerNumber}";


        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double billAmount = 12.49;
            double taxRate = 0.13;
            double taxAmount = 12.49 * 0.13;
            double total = 12.49 + taxAmount;
            double cash = 20.00;
            double change = cash - total;
            outputLabel.Text = "Bill of sale";
            outputLabel.Text += $"\n\nShirt:         {billAmount}";
            outputLabel.Text += $"\n\nTax:           {taxAmount}";
            outputLabel.Text += $"\nTotal:           {total}";
            outputLabel.Text += $"\n\nTendered:      {cash}";
            outputLabel.Text += $"\nChange:          {change}";


        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;
            outputLabel.Text = $"radius of circle: {radius}";
            outputLabel.Text += $"\n pi is: {pi}";
            outputLabel.Text += $"\nThe Area of the cricle with a radius of 15cm is: {area}cm^2";

        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = 51;
            double totalCost = 19.95 * 51;
            outputLabel.Text = $"The area of the room with dimesntions {length}x {width} is {area} m^2";
            outputLabel.Text += $"\nThe cost to carpet this area at {costPerMeter} per sqaure meter is {totalCost}";

          

        }
    }
}
