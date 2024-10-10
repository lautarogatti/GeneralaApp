namespace Generala
{
    partial class Anotador
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
            this.cbxJuegos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxJuegos
            // 
            this.cbxJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJuegos.FormattingEnabled = true;
            this.cbxJuegos.Location = new System.Drawing.Point(72, 76);
            this.cbxJuegos.Name = "cbxJuegos";
            this.cbxJuegos.Size = new System.Drawing.Size(172, 28);
            this.cbxJuegos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Que anotamos pa?";
            // 
            // btnAnotar
            // 
            this.btnAnotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotar.Location = new System.Drawing.Point(113, 120);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(91, 30);
            this.btnAnotar.TabIndex = 2;
            this.btnAnotar.Text = "Anotar";
            this.btnAnotar.UseVisualStyleBackColor = true;
            // 
            // Anotador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 173);
            this.Controls.Add(this.btnAnotar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxJuegos);
            this.Name = "Anotador";
            this.Text = "Anotador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxJuegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnotar;
    }
}