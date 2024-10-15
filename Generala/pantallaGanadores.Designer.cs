namespace Generala
{
    partial class PantallaGanadores
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
            this.dgvTablaScore = new System.Windows.Forms.DataGridView();
            this.lblGanador = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnJugarDenuevo = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaScore
            // 
            this.dgvTablaScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaScore.Location = new System.Drawing.Point(131, 97);
            this.dgvTablaScore.Name = "dgvTablaScore";
            this.dgvTablaScore.Size = new System.Drawing.Size(391, 193);
            this.dgvTablaScore.TabIndex = 0;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(54, 37);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(74, 13);
            this.lblGanador.TabIndex = 1;
            this.lblGanador.Text = "el ganador es:";
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(461, 368);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(75, 23);
            this.btnRanking.TabIndex = 2;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            // 
            // btnJugarDenuevo
            // 
            this.btnJugarDenuevo.Location = new System.Drawing.Point(272, 368);
            this.btnJugarDenuevo.Name = "btnJugarDenuevo";
            this.btnJugarDenuevo.Size = new System.Drawing.Size(115, 23);
            this.btnJugarDenuevo.TabIndex = 3;
            this.btnJugarDenuevo.Text = "Jugar Denuevo";
            this.btnJugarDenuevo.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(37, 368);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(135, 23);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // PantallaGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 446);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnJugarDenuevo);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.dgvTablaScore);
            this.Name = "PantallaGanadores";
            this.Text = "pantallaGanadores";
            this.Load += new System.EventHandler(this.PantallaGanadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaScore;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnJugarDenuevo;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}