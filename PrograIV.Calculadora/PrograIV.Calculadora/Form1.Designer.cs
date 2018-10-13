namespace PrograIV.Calculadora
{
    partial class frmCalculadora
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbOperandoUno = new System.Windows.Forms.TextBox();
            this.lblOperandoUno = new System.Windows.Forms.Label();
            this.lblOperandoDos = new System.Windows.Forms.Label();
            this.tbOperandoDos = new System.Windows.Forms.TextBox();
            this.cbOperadores = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(33, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora básica";
            // 
            // tbOperandoUno
            // 
            this.tbOperandoUno.Location = new System.Drawing.Point(185, 74);
            this.tbOperandoUno.Name = "tbOperandoUno";
            this.tbOperandoUno.Size = new System.Drawing.Size(100, 20);
            this.tbOperandoUno.TabIndex = 1;
            this.tbOperandoUno.Text = "0";
            // 
            // lblOperandoUno
            // 
            this.lblOperandoUno.AutoSize = true;
            this.lblOperandoUno.Location = new System.Drawing.Point(33, 77);
            this.lblOperandoUno.Name = "lblOperandoUno";
            this.lblOperandoUno.Size = new System.Drawing.Size(124, 13);
            this.lblOperandoUno.TabIndex = 2;
            this.lblOperandoUno.Text = "Digite el primer operando";
            // 
            // lblOperandoDos
            // 
            this.lblOperandoDos.AutoSize = true;
            this.lblOperandoDos.Location = new System.Drawing.Point(33, 111);
            this.lblOperandoDos.Name = "lblOperandoDos";
            this.lblOperandoDos.Size = new System.Drawing.Size(137, 13);
            this.lblOperandoDos.TabIndex = 5;
            this.lblOperandoDos.Text = "Digite el segundo operando";
            // 
            // tbOperandoDos
            // 
            this.tbOperandoDos.Location = new System.Drawing.Point(185, 109);
            this.tbOperandoDos.Name = "tbOperandoDos";
            this.tbOperandoDos.Size = new System.Drawing.Size(100, 20);
            this.tbOperandoDos.TabIndex = 4;
            this.tbOperandoDos.Text = "0";
            // 
            // cbOperadores
            // 
            this.cbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperadores.FormattingEnabled = true;
            this.cbOperadores.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbOperadores.Location = new System.Drawing.Point(185, 144);
            this.cbOperadores.Name = "cbOperadores";
            this.cbOperadores.Size = new System.Drawing.Size(100, 21);
            this.cbOperadores.TabIndex = 6;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(33, 147);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(82, 13);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "Elija el operador";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(148, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(33, 182);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(185, 179);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 10;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 274);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.cbOperadores);
            this.Controls.Add(this.lblOperandoDos);
            this.Controls.Add(this.tbOperandoDos);
            this.Controls.Add(this.lblOperandoUno);
            this.Controls.Add(this.tbOperandoUno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbOperandoUno;
        private System.Windows.Forms.Label lblOperandoUno;
        private System.Windows.Forms.Label lblOperandoDos;
        private System.Windows.Forms.TextBox tbOperandoDos;
        private System.Windows.Forms.ComboBox cbOperadores;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

