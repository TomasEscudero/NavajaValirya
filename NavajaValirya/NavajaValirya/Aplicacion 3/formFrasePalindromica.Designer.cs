﻿namespace NavajaValirya.FrasePalindromica
{
    partial class formFrasePalindromica
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
            this.BPalindromica = new System.Windows.Forms.Button();
            this.LFrase = new System.Windows.Forms.Label();
            this.TFrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BPalindromica
            // 
            this.BPalindromica.Location = new System.Drawing.Point(130, 107);
            this.BPalindromica.Name = "BPalindromica";
            this.BPalindromica.Size = new System.Drawing.Size(184, 45);
            this.BPalindromica.TabIndex = 0;
            this.BPalindromica.Text = "¿Es Palindrómica?";
            this.BPalindromica.UseVisualStyleBackColor = true;
            this.BPalindromica.Click += new System.EventHandler(this.BPalindromica_Click);
            // 
            // LFrase
            // 
            this.LFrase.AutoSize = true;
            this.LFrase.Location = new System.Drawing.Point(12, 29);
            this.LFrase.Name = "LFrase";
            this.LFrase.Size = new System.Drawing.Size(36, 13);
            this.LFrase.TabIndex = 1;
            this.LFrase.Text = "Frase:";
            // 
            // TFrase
            // 
            this.TFrase.Location = new System.Drawing.Point(72, 26);
            this.TFrase.Name = "TFrase";
            this.TFrase.Size = new System.Drawing.Size(379, 20);
            this.TFrase.TabIndex = 2;
            // 
            // formFrasePalindromica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 164);
            this.Controls.Add(this.TFrase);
            this.Controls.Add(this.LFrase);
            this.Controls.Add(this.BPalindromica);
            this.Name = "formFrasePalindromica";
            this.Text = "Frase Palindromica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPalindromica;
        private System.Windows.Forms.Label LFrase;
        private System.Windows.Forms.TextBox TFrase;
    }
}