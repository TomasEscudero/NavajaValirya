namespace NavajaValirya
{
    partial class formPrincipal
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
            this.BCambioDivisa = new System.Windows.Forms.Button();
            this.BDisposicionEfectivo = new System.Windows.Forms.Button();
            this.BFrasePalindromica = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BCambioDivisa
            // 
            this.BCambioDivisa.Location = new System.Drawing.Point(23, 32);
            this.BCambioDivisa.Name = "BCambioDivisa";
            this.BCambioDivisa.Size = new System.Drawing.Size(148, 62);
            this.BCambioDivisa.TabIndex = 0;
            this.BCambioDivisa.Text = "Cambio de Divisas [€-Ptas.]";
            this.BCambioDivisa.UseVisualStyleBackColor = true;
            this.BCambioDivisa.Click += new System.EventHandler(this.BCambioDivisa_Click);
            // 
            // BDisposicionEfectivo
            // 
            this.BDisposicionEfectivo.Location = new System.Drawing.Point(23, 100);
            this.BDisposicionEfectivo.Name = "BDisposicionEfectivo";
            this.BDisposicionEfectivo.Size = new System.Drawing.Size(148, 62);
            this.BDisposicionEfectivo.TabIndex = 1;
            this.BDisposicionEfectivo.Text = "Disposición de Efectivo";
            this.BDisposicionEfectivo.UseVisualStyleBackColor = true;
            this.BDisposicionEfectivo.Click += new System.EventHandler(this.BDisposicionEfectivo_Click);
            // 
            // BFrasePalindromica
            // 
            this.BFrasePalindromica.Location = new System.Drawing.Point(23, 237);
            this.BFrasePalindromica.Name = "BFrasePalindromica";
            this.BFrasePalindromica.Size = new System.Drawing.Size(148, 62);
            this.BFrasePalindromica.TabIndex = 2;
            this.BFrasePalindromica.Text = "Frase Palindrómca";
            this.BFrasePalindromica.UseVisualStyleBackColor = true;
            this.BFrasePalindromica.Click += new System.EventHandler(this.BFrasePalindromica_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 397);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BFrasePalindromica);
            this.Controls.Add(this.BDisposicionEfectivo);
            this.Controls.Add(this.BCambioDivisa);
            this.Name = "formPrincipal";
            this.Text = "Navaja Valirya";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BCambioDivisa;
        private System.Windows.Forms.Button BDisposicionEfectivo;
        private System.Windows.Forms.Button BFrasePalindromica;
        private System.Windows.Forms.Button button4;
    }
}

