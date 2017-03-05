namespace NavajaValirya.CambioDivisa
{
    partial class formCambioDivisa
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
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.BCambioEnEuros = new System.Windows.Forms.Button();
            this.BCambioEnPesetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(103, 37);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(238, 20);
            this.TCantidad.TabIndex = 0;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(29, 40);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(52, 13);
            this.LCantidad.TabIndex = 1;
            this.LCantidad.Text = "Cantidad:";
            // 
            // BCambioEnEuros
            // 
            this.BCambioEnEuros.Location = new System.Drawing.Point(32, 88);
            this.BCambioEnEuros.Name = "BCambioEnEuros";
            this.BCambioEnEuros.Size = new System.Drawing.Size(144, 110);
            this.BCambioEnEuros.TabIndex = 2;
            this.BCambioEnEuros.Text = "Cambia a €";
            this.BCambioEnEuros.UseVisualStyleBackColor = true;
            this.BCambioEnEuros.Click += new System.EventHandler(this.BCambioEnEuros_Click);
            // 
            // BCambioEnPesetas
            // 
            this.BCambioEnPesetas.Location = new System.Drawing.Point(202, 87);
            this.BCambioEnPesetas.Name = "BCambioEnPesetas";
            this.BCambioEnPesetas.Size = new System.Drawing.Size(139, 111);
            this.BCambioEnPesetas.TabIndex = 3;
            this.BCambioEnPesetas.Text = "Cambia a ptas.";
            this.BCambioEnPesetas.UseVisualStyleBackColor = true;
            this.BCambioEnPesetas.Click += new System.EventHandler(this.BCambioEnPesetas_Click);
            // 
            // formCambioDivisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 228);
            this.Controls.Add(this.BCambioEnPesetas);
            this.Controls.Add(this.BCambioEnEuros);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.TCantidad);
            this.Name = "formCambioDivisa";
            this.Text = "Cambio de Divisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCantidad;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Button BCambioEnEuros;
        private System.Windows.Forms.Button BCambioEnPesetas;
    }
}

