namespace Tarea_15Juego_3enLineaGrob
{
    partial class frmJuego
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPuntajeJugador2 = new System.Windows.Forms.Label();
            this.lblPuntajeJugador1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al juego 3 en línea ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(37, 56);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(235, 29);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.ReadOnly = true;
            this.txtJugador.Size = new System.Drawing.Size(390, 20);
            this.txtJugador.TabIndex = 2;
            this.txtJugador.Text = "Tu turno #.";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(37, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juego en proceso";
            // 
            // lblPuntajeJugador2
            // 
            this.lblPuntajeJugador2.AutoSize = true;
            this.lblPuntajeJugador2.Location = new System.Drawing.Point(574, 84);
            this.lblPuntajeJugador2.Name = "lblPuntajeJugador2";
            this.lblPuntajeJugador2.Size = new System.Drawing.Size(100, 13);
            this.lblPuntajeJugador2.TabIndex = 4;
            this.lblPuntajeJugador2.Text = "Puntaje Jugador #2";
            // 
            // lblPuntajeJugador1
            // 
            this.lblPuntajeJugador1.AutoSize = true;
            this.lblPuntajeJugador1.Location = new System.Drawing.Point(374, 84);
            this.lblPuntajeJugador1.Name = "lblPuntajeJugador1";
            this.lblPuntajeJugador1.Size = new System.Drawing.Size(100, 13);
            this.lblPuntajeJugador1.TabIndex = 5;
            this.lblPuntajeJugador1.Text = "Puntaje Jugador #1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dejar de jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPuntajeJugador1);
            this.Controls.Add(this.lblPuntajeJugador2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Name = "frmJuego";
            this.Text = "Tres en línea ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPuntajeJugador2;
        private System.Windows.Forms.Label lblPuntajeJugador1;
        private System.Windows.Forms.Button button1;
    }
}