namespace PrograIV.AW.Products
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
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(125, 63);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(250, 21);
            this.cbProductos.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(22, 63);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(97, 13);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Lista de productos:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(85, 39);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // cbColores
            // 
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Items.AddRange(new object[] {
            "Black",
            "White",
            "Brown",
            "Yellow",
            "Green"});
            this.cbColores.Location = new System.Drawing.Point(125, 30);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(121, 21);
            this.cbColores.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(125, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 170);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbColores);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cbProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColores;
        private System.Windows.Forms.Button btnConsultar;
    }
}

