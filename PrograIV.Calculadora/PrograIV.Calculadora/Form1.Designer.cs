namespace PrograIV.Calculadora
{
    partial class Form1
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
            this.chkSuma = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora básica";
            // 
            // tbOperandoUno
            // 
            this.tbOperandoUno.Location = new System.Drawing.Point(159, 71);
            this.tbOperandoUno.Name = "tbOperandoUno";
            this.tbOperandoUno.Size = new System.Drawing.Size(100, 20);
            this.tbOperandoUno.TabIndex = 1;
            this.tbOperandoUno.Text = "0";
            // 
            // lblOperandoUno
            // 
            this.lblOperandoUno.AutoSize = true;
            this.lblOperandoUno.Location = new System.Drawing.Point(26, 71);
            this.lblOperandoUno.Name = "lblOperandoUno";
            this.lblOperandoUno.Size = new System.Drawing.Size(124, 13);
            this.lblOperandoUno.TabIndex = 2;
            this.lblOperandoUno.Text = "Digite el primer operando";
            // 
            // chkSuma
            // 
            this.chkSuma.AutoSize = true;
            this.chkSuma.Checked = true;
            this.chkSuma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuma.Location = new System.Drawing.Point(29, 106);
            this.chkSuma.Name = "chkSuma";
            this.chkSuma.Size = new System.Drawing.Size(87, 17);
            this.chkSuma.TabIndex = 3;
            this.chkSuma.Text = "Es una suma";
            this.chkSuma.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 193);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chkSuma);
            this.Controls.Add(this.lblOperandoUno);
            this.Controls.Add(this.tbOperandoUno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbOperandoUno;
        private System.Windows.Forms.Label lblOperandoUno;
        private System.Windows.Forms.CheckBox chkSuma;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

