namespace Generala
{
    partial class Game
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
            this.btnDadoUno = new System.Windows.Forms.Button();
            this.pbxDUno = new System.Windows.Forms.PictureBox();
            this.pbxDDos = new System.Windows.Forms.PictureBox();
            this.pbxDTres = new System.Windows.Forms.PictureBox();
            this.pbxDCuatro = new System.Windows.Forms.PictureBox();
            this.pbxDCinco = new System.Windows.Forms.PictureBox();
            this.btnTirarSeleccionados = new System.Windows.Forms.Button();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.lblRondas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDadoUno
            // 
            this.btnDadoUno.Location = new System.Drawing.Point(469, 321);
            this.btnDadoUno.Name = "btnDadoUno";
            this.btnDadoUno.Size = new System.Drawing.Size(103, 41);
            this.btnDadoUno.TabIndex = 1;
            this.btnDadoUno.Text = "Tirar Todos Los Dados";
            this.btnDadoUno.UseVisualStyleBackColor = true;
            this.btnDadoUno.Click += new System.EventHandler(this.btnDadoUno_Click);
            // 
            // pbxDUno
            // 
            this.pbxDUno.Location = new System.Drawing.Point(143, 50);
            this.pbxDUno.Name = "pbxDUno";
            this.pbxDUno.Size = new System.Drawing.Size(167, 152);
            this.pbxDUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDUno.TabIndex = 2;
            this.pbxDUno.TabStop = false;
            // 
            // pbxDDos
            // 
            this.pbxDDos.Location = new System.Drawing.Point(393, 50);
            this.pbxDDos.Name = "pbxDDos";
            this.pbxDDos.Size = new System.Drawing.Size(162, 152);
            this.pbxDDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDDos.TabIndex = 3;
            this.pbxDDos.TabStop = false;
            // 
            // pbxDTres
            // 
            this.pbxDTres.Location = new System.Drawing.Point(654, 50);
            this.pbxDTres.Name = "pbxDTres";
            this.pbxDTres.Size = new System.Drawing.Size(167, 152);
            this.pbxDTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDTres.TabIndex = 4;
            this.pbxDTres.TabStop = false;
            // 
            // pbxDCuatro
            // 
            this.pbxDCuatro.Location = new System.Drawing.Point(911, 50);
            this.pbxDCuatro.Name = "pbxDCuatro";
            this.pbxDCuatro.Size = new System.Drawing.Size(167, 152);
            this.pbxDCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDCuatro.TabIndex = 5;
            this.pbxDCuatro.TabStop = false;
            // 
            // pbxDCinco
            // 
            this.pbxDCinco.Location = new System.Drawing.Point(1150, 50);
            this.pbxDCinco.Name = "pbxDCinco";
            this.pbxDCinco.Size = new System.Drawing.Size(171, 152);
            this.pbxDCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDCinco.TabIndex = 6;
            this.pbxDCinco.TabStop = false;
            // 
            // btnTirarSeleccionados
            // 
            this.btnTirarSeleccionados.Location = new System.Drawing.Point(730, 321);
            this.btnTirarSeleccionados.Name = "btnTirarSeleccionados";
            this.btnTirarSeleccionados.Size = new System.Drawing.Size(113, 39);
            this.btnTirarSeleccionados.TabIndex = 7;
            this.btnTirarSeleccionados.Text = "Tirar Dados Seleccionados";
            this.btnTirarSeleccionados.UseVisualStyleBackColor = true;
            // 
            // dgvScores
            // 
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Location = new System.Drawing.Point(35, 404);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.Size = new System.Drawing.Size(1395, 256);
            this.dgvScores.TabIndex = 8;
            // 
            // lblRondas
            // 
            this.lblRondas.AutoSize = true;
            this.lblRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRondas.Location = new System.Drawing.Point(75, 367);
            this.lblRondas.Name = "lblRondas";
            this.lblRondas.Size = new System.Drawing.Size(54, 25);
            this.lblRondas.TabIndex = 9;
            this.lblRondas.Text = "1/12";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 672);
            this.Controls.Add(this.lblRondas);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.btnTirarSeleccionados);
            this.Controls.Add(this.pbxDCinco);
            this.Controls.Add(this.pbxDCuatro);
            this.Controls.Add(this.pbxDTres);
            this.Controls.Add(this.pbxDDos);
            this.Controls.Add(this.pbxDUno);
            this.Controls.Add(this.btnDadoUno);
            this.Name = "Game";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDadoUno;
        private System.Windows.Forms.PictureBox pbxDUno;
        private System.Windows.Forms.PictureBox pbxDDos;
        private System.Windows.Forms.PictureBox pbxDTres;
        private System.Windows.Forms.PictureBox pbxDCuatro;
        private System.Windows.Forms.PictureBox pbxDCinco;
        private System.Windows.Forms.Button btnTirarSeleccionados;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Label lblRondas;
    }
}