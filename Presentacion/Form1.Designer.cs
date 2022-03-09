namespace Presentacion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.ptbCalcular = new System.Windows.Forms.PictureBox();
            this.ptbgrabarOp = new System.Windows.Forms.PictureBox();
            this.ptbGrabarN2 = new System.Windows.Forms.PictureBox();
            this.ptbGrabarN1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbgrabarOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrabarN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrabarN1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 139);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistemas de Funciones Matematicas Básicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 1:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(228, 44);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(175, 41);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(228, 119);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(175, 41);
            this.txtNumero2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operaciones:";
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Items.AddRange(new object[] {
            "SUMAR",
            "RESTAR",
            "MULTIPLICAR",
            "DIVIDIR"});
            this.cmbOperaciones.Location = new System.Drawing.Point(228, 187);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(175, 44);
            this.cmbOperaciones.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(686, 69);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 91);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // ptbCalcular
            // 
            this.ptbCalcular.Image = global::Presentacion.Properties.Resources.calculadora;
            this.ptbCalcular.Location = new System.Drawing.Point(263, 237);
            this.ptbCalcular.Name = "ptbCalcular";
            this.ptbCalcular.Size = new System.Drawing.Size(111, 81);
            this.ptbCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCalcular.TabIndex = 11;
            this.ptbCalcular.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbCalcular, "Boton para calcular");
            this.ptbCalcular.Click += new System.EventHandler(this.ptbCalcular_Click);
            // 
            // ptbgrabarOp
            // 
            this.ptbgrabarOp.Image = global::Presentacion.Properties.Resources.analisis_de_cuenta;
            this.ptbgrabarOp.Location = new System.Drawing.Point(431, 190);
            this.ptbgrabarOp.Name = "ptbgrabarOp";
            this.ptbgrabarOp.Size = new System.Drawing.Size(52, 41);
            this.ptbgrabarOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbgrabarOp.TabIndex = 10;
            this.ptbgrabarOp.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbgrabarOp, "boton para grabar las operaciones");
            // 
            // ptbGrabarN2
            // 
            this.ptbGrabarN2.Image = global::Presentacion.Properties.Resources.numero_2;
            this.ptbGrabarN2.Location = new System.Drawing.Point(431, 119);
            this.ptbGrabarN2.Name = "ptbGrabarN2";
            this.ptbGrabarN2.Size = new System.Drawing.Size(52, 41);
            this.ptbGrabarN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGrabarN2.TabIndex = 9;
            this.ptbGrabarN2.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbGrabarN2, "Boton para grabar el número 2");
            this.ptbGrabarN2.Click += new System.EventHandler(this.ptbGrabarN2_Click);
            // 
            // ptbGrabarN1
            // 
            this.ptbGrabarN1.Image = global::Presentacion.Properties.Resources.numero_uno;
            this.ptbGrabarN1.Location = new System.Drawing.Point(431, 44);
            this.ptbGrabarN1.Name = "ptbGrabarN1";
            this.ptbGrabarN1.Size = new System.Drawing.Size(52, 41);
            this.ptbGrabarN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGrabarN1.TabIndex = 8;
            this.ptbGrabarN1.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbGrabarN1, "Boton para grabar Primer Numero");
            this.ptbGrabarN1.Click += new System.EventHandler(this.ptbGrabarN1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.ptbCalcular);
            this.Controls.Add(this.ptbgrabarOp);
            this.Controls.Add(this.ptbGrabarN2);
            this.Controls.Add(this.ptbGrabarN1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbgrabarOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrabarN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrabarN1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox ptbGrabarN1;
        private System.Windows.Forms.PictureBox ptbGrabarN2;
        private System.Windows.Forms.PictureBox ptbgrabarOp;
        private System.Windows.Forms.PictureBox ptbCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

