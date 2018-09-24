using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Metodos
{
    public partial class secante : Form
    {
        
        public secante()
        {
            InitializeComponent();

          
        }
         DataTable dt = new DataTable();

        private void btnse_Click(object sender, EventArgs e)
        {
      
            double g = 9.8;
            double va = 0;
            double x1 = Convert.ToDouble(txtc1.Text);
            double m = Convert.ToDouble(txtma.Text);
            double xi = Convert.ToDouble(txtc2.Text);
            double t = Convert.ToDouble(txttie.Text);
            double eu = 2.718281828;
            double v = Convert.ToDouble(txtv.Text);
            double ea = 100;
            double ve = Convert.ToDouble(txtve.Text);
            DataRow row = dt.NewRow();
            

            for (int i = 1; ve < ea; i++)
            {

                double F1 = (g * m / x1) * (1 - Math.Pow(eu, (-(x1 / m) * t))) - v;
                double Fi = (g * m / xi) * (1 - Math.Pow(eu, (-(xi / m) * t))) - v;
                double xi1 = x1 - ((F1) * (xi - x1)) / (Fi - F1);
                row["i"] = i.ToString();
                row["Xi-1"] = xi.ToString();
                row["Fi-1"] = Fi.ToString();
                row["Xi"] = x1.ToString();
                row["Fi"] = F1.ToString();

                row["Xi+1"] = xi1.ToString();
                     
                double aux = x1;
                x1 = xi1;
                xi = aux;
                double Fi1 = (g * m / xi1) * (1 - Math.Pow(eu, (-(xi1 / m) * t))) - v;
                row["Fi+1"] = Fi1.ToString();
                ea = Math.Abs(((xi1 - va) / xi1) * 100);
                row["Ea"] = ea.ToString();
                va = xi1;       
                dt.Rows.Add(row["i"],  row["Xi-1"], row["Fi-1"],row["Xi"],row["Fi"], row["Xi+1"], row["Fi+1"], row["Ea"]);
               

        }


    }
       

        private void label12_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("i");      
            dt.Columns.Add("Xi-1");
            dt.Columns.Add("Fi-1");
            dt.Columns.Add("Xi");
            dt.Columns.Add("Fi");
            dt.Columns.Add("Xi+1");
            dt.Columns.Add("Fi+1");
            dt.Columns.Add("Ea");
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtve_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '+')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc1.Text = " ";
            txtc2.Text = " ";
            txtma.Text = " ";
            txttie.Text = " ";
            txtv.Text = " ";
            txtve.Text = " ";

            while (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }
        }

        private void txtve_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc2_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }
