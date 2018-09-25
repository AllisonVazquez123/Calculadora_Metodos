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
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void label3_Click(object sender, EventArgs e)
        {
            string variable = "Hokla";
            bool FD;
            int entero;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("i");
            dt.Columns.Add("C");
            dt.Columns.Add("F(C)");
            dt.Columns.Add("Ea");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }
            double g = 9.8;
            double v = Convert.ToDouble(txtv.Text);
            double m = Convert.ToDouble(txtma.Text);
            double c1 = Convert.ToDouble(txtc1.Text);
            double c2 = Convert.ToDouble(txtc2.Text);
            double t = Convert.ToDouble(txttie.Text);
            double eu = 2.718281828;
            double va = 0;
            double cn = 0;
            double aux;
            double ea = 100;
            double ve= Convert.ToDouble(txtve.Text);
           
            double F1 = (g * m / c1) * (1 - Math.Pow(eu, (-(c1 / m) * t))) - v;

            double F2 = (g * m / c2) * (1 - Math.Pow(eu, (-(c2 / m) * t))) - v;

            txtc1no.Text = F1.ToString();
            txtc2no.Text = F2.ToString();

            DataRow row = dt.NewRow();

            if ((F1*F2)<0)
            {
                 if (F1 < 0)//intercambia
                {
                    aux = c1;
                    c1 = c2;
                    c2 = aux;
                }

                for (int i = 1; ve < ea; i++)
                {

                    cn = (c1 + c2) / 2;
                

                    double F3 = (g * m / cn) * (1 - Math.Pow(eu, (-(cn / m) * t))) - v;

                    row["i"] = i.ToString();
                    row["C"] = cn.ToString();
                    row["F(C)"] = F3.ToString();

                    if (F3 < 0)
                    {
                        c2 = cn;
                    }
                    else
                    {
                        c1 = cn;


                    }

                    ea = Math.Abs(((cn - va) / cn) * 100);
                    va = cn;

                    row["Ea"] = ea.ToString();

                    dt.Rows.Add(row["i"], row["C"], row["F(C)"], row["Ea"]);
                }
            }
            else
            {
                MessageBox.Show("Ingresa otro valor hasta tener uno positivo y otro negativo");
            }

            

        }

        private void txtea_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc1.Text = " ";
            txtc2.Text = " ";
            txtma.Text = " ";
            txttie.Text = " ";
            txtv.Text = " ";
            txtve.Text = " ";
            txtc1no.Text = " ";
            txtc2no.Text = " ";

            while (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }

        }

        private void txtve_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

