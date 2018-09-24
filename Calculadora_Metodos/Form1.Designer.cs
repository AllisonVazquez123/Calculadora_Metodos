namespace Calculadora_Metodos
{
    partial class Biseccion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtma = new System.Windows.Forms.TextBox();
            this.txttie = new System.Windows.Forms.TextBox();
            this.btnbi = new System.Windows.Forms.Button();
            this.ve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtv = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtve = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtc2no = new System.Windows.Forms.TextBox();
            this.txtc1no = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(114, 58);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 1;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // txttie
            // 
            this.txttie.Location = new System.Drawing.Point(114, 102);
            this.txttie.Name = "txttie";
            this.txttie.Size = new System.Drawing.Size(100, 20);
            this.txttie.TabIndex = 2;
            this.txttie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // btnbi
            // 
            this.btnbi.Location = new System.Drawing.Point(253, 207);
            this.btnbi.Name = "btnbi";
            this.btnbi.Size = new System.Drawing.Size(75, 23);
            this.btnbi.TabIndex = 4;
            this.btnbi.Text = "Calcular";
            this.btnbi.UseVisualStyleBackColor = true;
            this.btnbi.Click += new System.EventHandler(this.button1_Click);
            // 
            // ve
            // 
            this.ve.AutoSize = true;
            this.ve.Location = new System.Drawing.Point(14, 18);
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(77, 13);
            this.ve.TabIndex = 5;
            this.ve.Text = "Valor Estimado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Masa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "C2";
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(114, 243);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(100, 20);
            this.txtc2.TabIndex = 10;
            this.txtc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Velocidad";
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(114, 130);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(100, 20);
            this.txtv.TabIndex = 13;
            this.txtv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(114, 169);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(100, 20);
            this.txtc1.TabIndex = 3;
            this.txtc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 21;
            // 
            // txtve
            // 
            this.txtve.Location = new System.Drawing.Point(114, 25);
            this.txtve.Name = "txtve";
            this.txtve.Size = new System.Drawing.Size(100, 20);
            this.txtve.TabIndex = 22;
            this.txtve.TextChanged += new System.EventHandler(this.txtve_TextChanged);
            this.txtve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtc2no);
            this.groupBox1.Controls.Add(this.txtc1no);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txttie);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtc1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ve);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnbi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtve);
            this.groupBox1.Controls.Add(this.txtc2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtv);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 336);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bisección";
            // 
            // txtc2no
            // 
            this.txtc2no.Location = new System.Drawing.Point(114, 269);
            this.txtc2no.Name = "txtc2no";
            this.txtc2no.Size = new System.Drawing.Size(100, 20);
            this.txtc2no.TabIndex = 55;
            // 
            // txtc1no
            // 
            this.txtc1no.Location = new System.Drawing.Point(114, 207);
            this.txtc1no.Name = "txtc1no";
            this.txtc1no.Size = new System.Drawing.Size(100, 20);
            this.txtc1no.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 53;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "m^2/s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "seg.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(373, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 238);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla de demostración";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "Biseccion";
            this.Text = "Bisección";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txttie;
        private System.Windows.Forms.Button btnbi;
        private System.Windows.Forms.Label ve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtc2no;
        private System.Windows.Forms.TextBox txtc1no;
    }
}

