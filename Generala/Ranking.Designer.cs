namespace Generala
{
    partial class Ranking
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
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.btnAlMenu = new System.Windows.Forms.Button();
            this.lblRanking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRanking
            // 
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Location = new System.Drawing.Point(114, 69);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.Size = new System.Drawing.Size(351, 211);
            this.dgvRanking.TabIndex = 0;
            // 
            // btnAlMenu
            // 
            this.btnAlMenu.Location = new System.Drawing.Point(237, 337);
            this.btnAlMenu.Name = "btnAlMenu";
            this.btnAlMenu.Size = new System.Drawing.Size(107, 23);
            this.btnAlMenu.TabIndex = 1;
            this.btnAlMenu.Text = "Menu Principal";
            this.btnAlMenu.UseVisualStyleBackColor = true;
            this.btnAlMenu.Click += new System.EventHandler(this.btnAlMenu_Click);
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(267, 13);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(44, 13);
            this.lblRanking.TabIndex = 2;
            this.lblRanking.Text = "TOP 10";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.btnAlMenu);
            this.Controls.Add(this.dgvRanking);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.Button btnAlMenu;
        private System.Windows.Forms.Label lblRanking;
    }
}