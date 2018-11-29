using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Func[]
             funcs =
         {
            (x) =>x+1,
            (x)=>Math.Exp(Math.Exp(x)),
            (x)=>Math.Sin(x)/x
        };

        Func f = funcs[1];
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbA.Text);
            double b = double.Parse(tbB.Text);
            int n = int.Parse(tbN.Text);

            IntegralFunction int_f = new IntegralFunction(f, a, b);
            Calculator c = new Calculator();
            try
            {
                var result = c.CalculateAll(int_f, n);
                DataTable dt = new DataTable();
                dt.Columns.Add("u");
                dt.Columns.Add("x");
                dt.Columns.Add("y");

                for (int i = 0; i < result.x.Count; i++)
                    dt.Rows.Add(result.u[i], result.x[i], result.y[i]);

                dataGridView1.DataSource = dt;
                lblRes.Text = " = " + result.I;
                lblOz.Text = result.d.ToString();

                lblOz.Text = "Доверительный интервал: [" + result.I_min + "; " + result.I_max + "]";

                lblSrRes.Text = "";
                lblResTochnInterval.Text = "";
                if (double.TryParse(tbTochn.Text.Replace('.', ','), out double tochn))
                {
                    lblSrRes.Text = "Разница со значеним для проверки: ";
                    lblSrRes.Text += c.err(result.I, tochn).ToString();
                    if (result.I_min <= tochn && tochn <= result.I_max)
                        lblResTochnInterval.Text = "Значение для проверки в доверительном интервале";
                    else
                        lblResTochnInterval.Text = "Значение для проверки НЕ в доверительном интервале";
                }

            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Недостаточно памяти, уменьшите количество точек");
                return;
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            f = funcs[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f = funcs[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f = funcs[2];
        }
    }
}
