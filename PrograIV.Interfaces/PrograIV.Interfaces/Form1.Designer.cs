namespace PrograIV.Interfaces
{
    partial class frmInvocarWcf
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.tbMensaje1 = new System.Windows.Forms.TextBox();
            this.tbMensaje2 = new System.Windows.Forms.TextBox();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.lblSalida1 = new System.Windows.Forms.Label();
            this.lblSalida2 = new System.Windows.Forms.Label();
            this.tbSalida1 = new System.Windows.Forms.TextBox();
            this.tbSalida2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(112, 188);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Location = new System.Drawing.Point(16, 20);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(56, 13);
            this.lblMensaje1.TabIndex = 1;
            this.lblMensaje1.Text = "Mensaje 1";
            // 
            // tbMensaje1
            // 
            this.tbMensaje1.Location = new System.Drawing.Point(77, 13);
            this.tbMensaje1.Name = "tbMensaje1";
            this.tbMensaje1.Size = new System.Drawing.Size(192, 20);
            this.tbMensaje1.TabIndex = 2;
            // 
            // tbMensaje2
            // 
            this.tbMensaje2.Location = new System.Drawing.Point(77, 40);
            this.tbMensaje2.Name = "tbMensaje2";
            this.tbMensaje2.Size = new System.Drawing.Size(192, 20);
            this.tbMensaje2.TabIndex = 3;
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(16, 43);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(56, 13);
            this.lblMensaje2.TabIndex = 4;
            this.lblMensaje2.Text = "Mensaje 2";
            // 
            // lblSalida1
            // 
            this.lblSalida1.AutoSize = true;
            this.lblSalida1.Location = new System.Drawing.Point(16, 103);
            this.lblSalida1.Name = "lblSalida1";
            this.lblSalida1.Size = new System.Drawing.Size(45, 13);
            this.lblSalida1.TabIndex = 5;
            this.lblSalida1.Text = "Salida 1";
            // 
            // lblSalida2
            // 
            this.lblSalida2.AutoSize = true;
            this.lblSalida2.Location = new System.Drawing.Point(16, 127);
            this.lblSalida2.Name = "lblSalida2";
            this.lblSalida2.Size = new System.Drawing.Size(45, 13);
            this.lblSalida2.TabIndex = 6;
            this.lblSalida2.Text = "Salida 2";
            // 
            // tbSalida1
            // 
            this.tbSalida1.Location = new System.Drawing.Point(77, 100);
            this.tbSalida1.Name = "tbSalida1";
            this.tbSalida1.Size = new System.Drawing.Size(192, 20);
            this.tbSalida1.TabIndex = 7;
            // 
            // tbSalida2
            // 
            this.tbSalida2.Location = new System.Drawing.Point(77, 124);
            this.tbSalida2.Name = "tbSalida2";
            this.tbSalida2.Size = new System.Drawing.Size(192, 20);
            this.tbSalida2.TabIndex = 8;
            // 
            // frmInvocarWcf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 252);
            this.Controls.Add(this.tbSalida2);
            this.Controls.Add(this.tbSalida1);
            this.Controls.Add(this.lblSalida2);
            this.Controls.Add(this.lblSalida1);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.tbMensaje2);
            this.Controls.Add(this.tbMensaje1);
            this.Controls.Add(this.lblMensaje1);
            this.Controls.Add(this.btnOK);
            this.Name = "frmInvocarWcf";
            this.Text = "Invocación a Interfaces WCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.TextBox tbMensaje1;
        private System.Windows.Forms.TextBox tbMensaje2;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Label lblSalida1;
        private System.Windows.Forms.Label lblSalida2;
        private System.Windows.Forms.TextBox tbSalida1;
        private System.Windows.Forms.TextBox tbSalida2;
    }
}

