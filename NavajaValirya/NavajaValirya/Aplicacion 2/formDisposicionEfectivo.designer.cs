namespace NavajaValirya.DisposicionEfectivo
{
    partial class formDisposicionEfectivo
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
            this.LValor = new System.Windows.Forms.Label();
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.LDisposicion = new System.Windows.Forms.Label();
            this.BDisposicionEfectivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.Location = new System.Drawing.Point(22, 22);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(52, 13);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Cantidad:";
            this.LValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(103, 19);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(179, 20);
            this.TCantidad.TabIndex = 1;
            // 
            // LDisposicion
            // 
            this.LDisposicion.AutoSize = true;
            this.LDisposicion.Location = new System.Drawing.Point(22, 100);
            this.LDisposicion.Name = "LDisposicion";
            this.LDisposicion.Size = new System.Drawing.Size(91, 13);
            this.LDisposicion.TabIndex = 2;
            this.LDisposicion.Text = "La disposición es:";
            // 
            // BDisposicionEfectivo
            // 
            this.BDisposicionEfectivo.Location = new System.Drawing.Point(103, 54);
            this.BDisposicionEfectivo.Name = "BDisposicionEfectivo";
            this.BDisposicionEfectivo.Size = new System.Drawing.Size(179, 27);
            this.BDisposicionEfectivo.TabIndex = 3;
            this.BDisposicionEfectivo.Text = "Disposición de Efectivo";
            this.BDisposicionEfectivo.UseVisualStyleBackColor = true;
            this.BDisposicionEfectivo.Click += new System.EventHandler(this.BDisposicionEfectivo_Click);
            // 
            // formDisposicionEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 295);
            this.Controls.Add(this.BDisposicionEfectivo);
            this.Controls.Add(this.LDisposicion);
            this.Controls.Add(this.TCantidad);
            this.Controls.Add(this.LValor);
            this.Name = "formDisposicionEfectivo";
            this.Text = "Disposición de Efectivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.TextBox TCantidad;
        private System.Windows.Forms.Label LDisposicion;
        private System.Windows.Forms.Button BDisposicionEfectivo;
    }
}

