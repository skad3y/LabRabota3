using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRabota3
{
    public partial class Form1 : Form
    {
        private double tmin, tmax, tstep;
        private double minZ = 2000000, maxZ = 0;    
        private double x, y, t, R;

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Выбирите график", "Внимание!");
                return;
            }

            if (checkBox1.Checked)
            {

            }    

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Выбирите график", "Внимание!");
                return;
            }

            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxH.Text == "")
            {
                MessageBox.Show("Параметры будут заданны по умолчанию", "Внимание!");
                DefaultParams();
            }
            else
            {
                tmin = Convert.ToDouble(textBoxA.Text);
                tmax = Convert.ToDouble(textBoxB.Text);
                tstep = Convert.ToDouble(textBoxH.Text);
                R = Convert.ToDouble(textBoxR.Text);

            }

            if (checkBox1.Checked)
            {
                t = tmin;
                this.chart.Series[0].Points.Clear();
                for(double i = tmin; i <= tmax; i += tstep)
                {
                    y = R * Math.Sin(i);
                    x = R * Math.Cos(i);
                    this.chart.Series[0].Points.AddXY((Math.Round(x, 3)), (Math.Round(y, 3)));

                    //MessageBox.Show(Convert.ToString(y));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Выбирите график", "Внимание!");
                return;
            }

            if (checkBox1.Checked)
            {
                this.chart.Series[0].Points.Clear();
            }
        }

        private void DefaultParams()
        {
            tmin = -10;
            tmax = 10;
            tstep = 0.1;
            R = 3;
        }
    }
}
