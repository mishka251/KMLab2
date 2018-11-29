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

        Func f = funcs[0];
        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numUDa.Value;
            double b = (double)numUDb.Value;
            int n = int.Parse(tbN.Text);

            IntegralFunction int_f = new IntegralFunction(f, a, b);
            Calculator c = new Calculator();

            var result = c.CalculateAll(int_f, n);

            DataTable dt = new DataTable();
            dt.Columns.Add("ul");
            dt.Columns.Add("x");
            dt.Columns.Add("y");

            for (int i = 0; i < result.x.Count; i++)
                dt.Rows.Add(result.u[i], result.x[i], result.y[i]);

            dataGridView1.DataSource = dt;
            lblRes.Text = "=" + result.I;
            lblOz.Text = result.d.ToString();

            lblOz.Text = "[" + result.I_min + "; " + result.I_max + "]";

            if(double.TryParse(tbTochn.Text, out double tochn))
            {
                lblSrRes.Text = c.err(result.I, tochn).ToString();
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
