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
    public partial class Puntofijo : Form
    {
        public Puntofijo()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void Puntofijo_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("i");
            dt.Columns.Add("X");
            dt.Columns.Add("Xi+1");
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
            double va = 0;
            double m = Convert.ToDouble(txtma.Text);
            double c1 = Convert.ToDouble(txtc1.Text);
            double t = Convert.ToDouble(txttie.Text);
            double eu = 2.718281828;
            double v = Convert.ToDouble(txtv.Text);
            double ea = 100;
            double ve = Convert.ToDouble(txtve.Text);
            DataRow row = dt.NewRow();


            for (int i = 1; ve < ea; i++)
            {
                row["X"] = c1.ToString();
                c1 = (g * m / c1  ) * (1 - Math.Pow(eu, (-(c1 / m) * t))) - v + c1;
                row["i"] = i.ToString();
                
                row["Xi+1"] = c1.ToString();
              
                 ea = Math.Abs(((c1 - va) / c1) * 100);
              
                row["Ea"] = ea.ToString();
                va = c1;
               
                dt.Rows.Add(row["i"], row["X"], row["Xi+1"], row["Ea"]);
            }
        }  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc1.Text = " ";
           
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
    }
}
