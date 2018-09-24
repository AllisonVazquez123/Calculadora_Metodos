namespace Calculadora_Metodos
{
    partial class secante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtve = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtv = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ve = new System.Windows.Forms.Label();
            this.btnse = new System.Windows.Forms.Button();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.txttie = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Secantee = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Secantee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtve
            // 
            this.txtve.Location = new System.Drawing.Point(106, 29);
            this.txtve.Name = "txtve";
            this.txtve.Size = new System.Drawing.Size(100, 20);
            this.txtve.TabIndex = 45;
            this.txtve.TextChanged += new System.EventHandler(this.txtve_TextChanged);
            this.txtve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 44;
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(106, 138);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(100, 20);
            this.txtv.TabIndex = 37;
            this.txtv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(106, 212);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(100, 20);
            this.txtc2.TabIndex = 36;
            this.txtc2.TextChanged += new System.EventHandler(this.txtc2_TextChanged);
            this.txtc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Xi-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Xi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Masa";
            // 
            // ve
            // 
            this.ve.AutoSize = true;
            this.ve.Location = new System.Drawing.Point(6, 26);
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(77, 13);
            this.ve.TabIndex = 31;
            this.ve.Text = "Valor Estimado";
            // 
            // btnse
            // 
            this.btnse.Location = new System.Drawing.Point(213, 215);
            this.btnse.Name = "btnse";
            this.btnse.Size = new System.Drawing.Size(75, 26);
            this.btnse.TabIndex = 30;
            this.btnse.Text = "Calcular";
            this.btnse.UseVisualStyleBackColor = true;
            this.btnse.Click += new System.EventHandler(this.btnse_Click);
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(106, 177);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(100, 20);
            this.txtc1.TabIndex = 29;
            this.txtc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // txttie
            // 
            this.txttie.Location = new System.Drawing.Point(106, 103);
            this.txttie.Name = "txttie";
            this.txttie.Size = new System.Drawing.Size(100, 20);
            this.txttie.TabIndex = 28;
            this.txttie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(106, 66);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 27;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Velocidad";
            // 
            // Secantee
            // 
            this.Secantee.Controls.Add(this.button2);
            this.Secantee.Controls.Add(this.label14);
            this.Secantee.Controls.Add(this.label13);
            this.Secantee.Controls.Add(this.label12);
            this.Secantee.Controls.Add(this.label11);
            this.Secantee.Controls.Add(this.ve);
            this.Secantee.Controls.Add(this.label1);
            this.Secantee.Controls.Add(this.txtma);
            this.Secantee.Controls.Add(this.txttie);
            this.Secantee.Controls.Add(this.txtc1);
            this.Secantee.Controls.Add(this.label2);
            this.Secantee.Controls.Add(this.txtve);
            this.Secantee.Controls.Add(this.label3);
            this.Secantee.Controls.Add(this.label4);
            this.Secantee.Controls.Add(this.label5);
            this.Secantee.Controls.Add(this.txtc2);
            this.Secantee.Controls.Add(this.btnse);
            this.Secantee.Controls.Add(this.txtv);
            this.Secantee.Location = new System.Drawing.Point(21, 29);
            this.Secantee.Name = "Secantee";
            this.Secantee.Size = new System.Drawing.Size(294, 265);
            this.Secantee.TabIndex = 50;
            this.Secantee.TabStop = false;
            this.Secantee.Text = "Secante";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 52;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "m^2/s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "seg.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(342, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 202);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla de demostración";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // secante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Secantee);
            this.Controls.Add(this.label8);
            this.Name = "secante";
            this.Text = "secante";
            this.Load += new System.EventHandler(this.label12_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtve_KeyPress);
            this.Secantee.ResumeLayout(false);
            this.Secantee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ve;
        private System.Windows.Forms.Button btnse;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.TextBox txttie;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Secantee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}