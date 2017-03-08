namespace NavajaValirya.ContadorPalabras
{
    partial class formContadorPalabras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContadorPalabras));
            this.BContadorPalabras = new System.Windows.Forms.Button();
            this.LFrase = new System.Windows.Forms.Label();
            this.TFrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BContadorPalabras
            // 
            this.BContadorPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BContadorPalabras.Location = new System.Drawing.Point(230, 133);
            this.BContadorPalabras.Name = "BContadorPalabras";
            this.BContadorPalabras.Size = new System.Drawing.Size(176, 52);
            this.BContadorPalabras.TabIndex = 0;
            this.BContadorPalabras.Text = "Contar Palabras";
            this.BContadorPalabras.UseVisualStyleBackColor = true;
            this.BContadorPalabras.Click += new System.EventHandler(this.BContadorPalabras_Click);
            // 
            // LFrase
            // 
            this.LFrase.AutoSize = true;
            this.LFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFrase.Location = new System.Drawing.Point(4, 28);
            this.LFrase.Name = "LFrase";
            this.LFrase.Size = new System.Drawing.Size(50, 18);
            this.LFrase.TabIndex = 1;
            this.LFrase.Text = "Frase:";
            // 
            // TFrase
            // 
            this.TFrase.Location = new System.Drawing.Point(60, 29);
            this.TFrase.MaxLength = 500;
            this.TFrase.Name = "TFrase";
            this.TFrase.Size = new System.Drawing.Size(346, 20);
            this.TFrase.TabIndex = 2;
            // 
            // formContadorPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 197);
            this.Controls.Add(this.TFrase);
            this.Controls.Add(this.LFrase);
            this.Controls.Add(this.BContadorPalabras);
            this.Name = "formContadorPalabras";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BContadorPalabras;
        private System.Windows.Forms.Label LFrase;
        private System.Windows.Forms.TextBox TFrase;
    }
}