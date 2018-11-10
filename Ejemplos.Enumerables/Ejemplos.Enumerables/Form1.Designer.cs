namespace Ejemplos.Enumerables
{
    partial class frmEstructuras
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
            this.lbAgregar = new System.Windows.Forms.Label();
            this.tbAgregar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbSalida = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefrescarCB = new System.Windows.Forms.Button();
            this.btnRefrescarLL = new System.Windows.Forms.Button();
            this.cbAgregarAlFinal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbAgregar
            // 
            this.lbAgregar.AutoSize = true;
            this.lbAgregar.Location = new System.Drawing.Point(88, 32);
            this.lbAgregar.Name = "lbAgregar";
            this.lbAgregar.Size = new System.Drawing.Size(82, 13);
            this.lbAgregar.TabIndex = 0;
            this.lbAgregar.Text = "Texto a agregar";
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(177, 32);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(257, 20);
            this.tbAgregar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(91, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 121);
            this.listBox1.TabIndex = 2;
            // 
            // cbSalida
            // 
            this.cbSalida.FormattingEnabled = true;
            this.cbSalida.Location = new System.Drawing.Point(313, 105);
            this.cbSalida.Name = "cbSalida";
            this.cbSalida.Size = new System.Drawing.Size(121, 21);
            this.cbSalida.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(464, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefrescarCB
            // 
            this.btnRefrescarCB.Location = new System.Drawing.Point(447, 103);
            this.btnRefrescarCB.Name = "btnRefrescarCB";
            this.btnRefrescarCB.Size = new System.Drawing.Size(92, 23);
            this.btnRefrescarCB.TabIndex = 5;
            this.btnRefrescarCB.Text = "Refrescar CB";
            this.btnRefrescarCB.UseVisualStyleBackColor = true;
            this.btnRefrescarCB.Click += new System.EventHandler(this.btnRefrescarCB_Click);
            // 
            // btnRefrescarLL
            // 
            this.btnRefrescarLL.Location = new System.Drawing.Point(447, 148);
            this.btnRefrescarLL.Name = "btnRefrescarLL";
            this.btnRefrescarLL.Size = new System.Drawing.Size(92, 23);
            this.btnRefrescarLL.TabIndex = 6;
            this.btnRefrescarLL.Text = "Refrescar LL";
            this.btnRefrescarLL.UseVisualStyleBackColor = true;
            this.btnRefrescarLL.Click += new System.EventHandler(this.btnRefrescarLL_Click);
            // 
            // cbAgregarAlFinal
            // 
            this.cbAgregarAlFinal.AutoSize = true;
            this.cbAgregarAlFinal.Location = new System.Drawing.Point(91, 67);
            this.cbAgregarAlFinal.Name = "cbAgregarAlFinal";
            this.cbAgregarAlFinal.Size = new System.Drawing.Size(96, 17);
            this.cbAgregarAlFinal.TabIndex = 7;
            this.cbAgregarAlFinal.Text = "Agregar al final";
            this.cbAgregarAlFinal.UseVisualStyleBackColor = true;
            // 
            // frmEstructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 269);
            this.Controls.Add(this.cbAgregarAlFinal);
            this.Controls.Add(this.btnRefrescarLL);
            this.Controls.Add(this.btnRefrescarCB);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbSalida);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbAgregar);
            this.Controls.Add(this.lbAgregar);
            this.Name = "frmEstructuras";
            this.Text = "Estructuras Enumerables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAgregar;
        private System.Windows.Forms.TextBox tbAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefrescarCB;
        private System.Windows.Forms.Button btnRefrescarLL;
        private System.Windows.Forms.CheckBox cbAgregarAlFinal;
    }
}

