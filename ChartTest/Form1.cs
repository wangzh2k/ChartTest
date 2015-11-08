using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.AddXY(0, 0);
            this.chart1.Series["Series1"].Points.AddXY(1, 2);
            this.chart1.Series["Series1"].Points.AddXY(3, 1.5);
            this.chart1.Series["Series1"].Points.AddXY(0.5, 1);
            this.chart1.Series["Series1"].Points.AddXY(1, 1.5);
            this.chart1.Series["Series1"].Points.AddXY(1.5, 0.5);
        }
    }
}
