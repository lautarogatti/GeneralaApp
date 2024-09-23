namespace Generala
{
    partial class Lobby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnEliminarPerfil = new System.Windows.Forms.Button();
            this.lblLobby = new System.Windows.Forms.Label();
            this.btnQuitarLobby = new System.Windows.Forms.Button();
            this.lblEstadoLobby = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPerfiles.Location = new System.Drawing.Point(53, 33);
            this.dgvPerfiles.MultiSelect = false;
            this.dgvPerfiles.Name = "dgvPerfiles";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPerfiles.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(360, 150);
            this.dgvPerfiles.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(435, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar a Lobby";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJugadores.Location = new System.Drawing.Point(53, 250);
            this.dgvJugadores.MultiSelect = false;
            this.dgvJugadores.Name = "dgvJugadores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvJugadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(360, 150);
            this.dgvJugadores.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Khaki;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(443, 54);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo Perfil";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Khaki;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(172, 415);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(103, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Comenzar Partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.BackColor = System.Drawing.Color.Khaki;
            this.btnEliminarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPerfil.Location = new System.Drawing.Point(437, 86);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(87, 23);
            this.btnEliminarPerfil.TabIndex = 5;
            this.btnEliminarPerfil.Text = "Eliminar Perfil";
            this.btnEliminarPerfil.UseVisualStyleBackColor = false;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // lblLobby
            // 
            this.lblLobby.AutoSize = true;
            this.lblLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLobby.ForeColor = System.Drawing.Color.White;
            this.lblLobby.Location = new System.Drawing.Point(182, 208);
            this.lblLobby.Name = "lblLobby";
            this.lblLobby.Size = new System.Drawing.Size(109, 37);
            this.lblLobby.TabIndex = 6;
            this.lblLobby.Text = "Lobby";
            // 
            // btnQuitarLobby
            // 
            this.btnQuitarLobby.BackColor = System.Drawing.Color.Khaki;
            this.btnQuitarLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarLobby.Location = new System.Drawing.Point(443, 303);
            this.btnQuitarLobby.Name = "btnQuitarLobby";
            this.btnQuitarLobby.Size = new System.Drawing.Size(75, 41);
            this.btnQuitarLobby.TabIndex = 7;
            this.btnQuitarLobby.Text = "Quitar del Lobby";
            this.btnQuitarLobby.UseVisualStyleBackColor = false;
            this.btnQuitarLobby.Click += new System.EventHandler(this.btnQuitarLobby_Click);
            // 
            // lblEstadoLobby
            // 
            this.lblEstadoLobby.AutoSize = true;
            this.lblEstadoLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLobby.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadoLobby.Location = new System.Drawing.Point(427, 355);
            this.lblEstadoLobby.Name = "lblEstadoLobby";
            this.lblEstadoLobby.Size = new System.Drawing.Size(0, 37);
            this.lblEstadoLobby.TabIndex = 8;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(549, 458);
            this.Controls.Add(this.lblEstadoLobby);
            this.Controls.Add(this.btnQuitarLobby);
            this.Controls.Add(this.lblLobby);
            this.Controls.Add(this.btnEliminarPerfil);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnEliminarPerfil;
        private System.Windows.Forms.Label lblLobby;
        private System.Windows.Forms.Button btnQuitarLobby;
        private System.Windows.Forms.Label lblEstadoLobby;
    }
}