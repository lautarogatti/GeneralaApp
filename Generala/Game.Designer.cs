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
            this.lblDadoUno = new System.Windows.Forms.Label();
            this.btnDadoUno = new System.Windows.Forms.Button();
            this.lblDadoDos = new System.Windows.Forms.Label();
            this.lblDadoTres = new System.Windows.Forms.Label();
            this.lblDadoCuatro = new System.Windows.Forms.Label();
            this.lblDadoCinco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDadoUno
            // 
            this.lblDadoUno.AutoSize = true;
            this.lblDadoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoUno.Location = new System.Drawing.Point(159, 141);
            this.lblDadoUno.Name = "lblDadoUno";
            this.lblDadoUno.Size = new System.Drawing.Size(77, 108);
            this.lblDadoUno.TabIndex = 0;
            this.lblDadoUno.Text = "-\r\n";
            // 
            // btnDadoUno
            // 
            this.btnDadoUno.Location = new System.Drawing.Point(343, 267);
            this.btnDadoUno.Name = "btnDadoUno";
            this.btnDadoUno.Size = new System.Drawing.Size(75, 23);
            this.btnDadoUno.TabIndex = 1;
            this.btnDadoUno.Text = "Tirar";
            this.btnDadoUno.UseVisualStyleBackColor = true;
            this.btnDadoUno.Click += new System.EventHandler(this.btnDadoUno_Click);
            // 
            // lblDadoDos
            // 
            this.lblDadoDos.AutoSize = true;
            this.lblDadoDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoDos.Location = new System.Drawing.Point(260, 141);
            this.lblDadoDos.Name = "lblDadoDos";
            this.lblDadoDos.Size = new System.Drawing.Size(77, 108);
            this.lblDadoDos.TabIndex = 2;
            this.lblDadoDos.Text = "-\r\n";
            // 
            // lblDadoTres
            // 
            this.lblDadoTres.AutoSize = true;
            this.lblDadoTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoTres.Location = new System.Drawing.Point(359, 141);
            this.lblDadoTres.Name = "lblDadoTres";
            this.lblDadoTres.Size = new System.Drawing.Size(77, 108);
            this.lblDadoTres.TabIndex = 3;
            this.lblDadoTres.Text = "-\r\n";
            // 
            // lblDadoCuatro
            // 
            this.lblDadoCuatro.AutoSize = true;
            this.lblDadoCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoCuatro.Location = new System.Drawing.Point(459, 140);
            this.lblDadoCuatro.Name = "lblDadoCuatro";
            this.lblDadoCuatro.Size = new System.Drawing.Size(77, 108);
            this.lblDadoCuatro.TabIndex = 4;
            this.lblDadoCuatro.Text = "-\r\n";
            // 
            // lblDadoCinco
            // 
            this.lblDadoCinco.AutoSize = true;
            this.lblDadoCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoCinco.Location = new System.Drawing.Point(557, 140);
            this.lblDadoCinco.Name = "lblDadoCinco";
            this.lblDadoCinco.Size = new System.Drawing.Size(77, 108);
            this.lblDadoCinco.TabIndex = 5;
            this.lblDadoCinco.Text = "-\r\n";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 420);
            this.Controls.Add(this.lblDadoCinco);
            this.Controls.Add(this.lblDadoCuatro);
            this.Controls.Add(this.lblDadoTres);
            this.Controls.Add(this.lblDadoDos);
            this.Controls.Add(this.btnDadoUno);
            this.Controls.Add(this.lblDadoUno);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadoUno;
        private System.Windows.Forms.Button btnDadoUno;
        private System.Windows.Forms.Label lblDadoDos;
        private System.Windows.Forms.Label lblDadoTres;
        private System.Windows.Forms.Label lblDadoCuatro;
        private System.Windows.Forms.Label lblDadoCinco;
    }
}