using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_15Juego_3enLineaGrob
{
    public partial class frmJuego : Form
    {
        PictureBox[,] imagenes;
        bool turno;
        int[,] matriz = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int puntajeJugador1, puntajeJugador2;

        public frmJuego()
        {
            InitializeComponent();
            imagenes = new PictureBox[3, 3]; // Inicializa la matriz de imágenes aquí.
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            string nombre = (sender as PictureBox).Name;
            string[] aux = nombre.Split('_');
            int fila = Convert.ToInt32(aux[1]);
            int col = Convert.ToInt32(aux[2]);

            if (matriz[fila, col] == 0) // Verificar que la casilla no esté ocupada
            {
                if (turno)
                {
                    imagenes[fila, col].Image = Tarea_15Juego_3enLineaGrob.Properties.Resources.Estrella;
                    matriz[fila, col] = 1;
                }
                else
                {
                    imagenes[fila, col].Image = Tarea_15Juego_3enLineaGrob.Properties.Resources.Circulo;
                    matriz[fila, col] = 2;
                }

                imagenes[fila, col].Enabled = false;
                turno = !turno;
                QuienJuega();

                // Verificar si hay un ganador
                int ganador = VerificarGanador();
                if (ganador != 0)
                {
                    MostrarGanador(ganador);
                    ReiniciarJuego();
                }
                else if (EsEmpate())
                {
                    MostrarEmpate();
                    ReiniciarJuego();
                }
            }
        }

        private int VerificarGanador()
        {
            // Verificar filas y columnas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] != 0 && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                    return matriz[i, 0]; // Ganador en fila
                if (matriz[0, i] != 0 && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i])
                    return matriz[0, i]; // Ganador en columna
            }

            // Verificar diagonales
            if (matriz[0, 0] != 0 && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
                return matriz[0, 0]; // Ganador en diagonal principal
            if (matriz[0, 2] != 0 && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                return matriz[0, 2]; // Ganador en diagonal secundaria

            return 0; // No hay ganador
        }

        private void MostrarGanador(int ganador)
        {
            // Muestra un mensaje de felicitación al ganador
            if (ganador == 1)
            {
                MessageBox.Show("¡Ganó el Jugador #1!", "¡Felicidades!");
                puntajeJugador1++;
            }
            else if (ganador == 2)
            {
                MessageBox.Show("¡Ganó el Jugador #2!", "¡Felicidades!");
                puntajeJugador2++;
            }

            ActualizarPuntajes();
        }

        private void MostrarEmpate()
        {
            // Muestra un mensaje indicando que el juego es un empate
            MessageBox.Show("¡Es un empate!", "¡Juego Terminado!");
        }

        private bool EsEmpate()
        {
            // Verifica si todas las casillas están ocupadas y no hay un ganador
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                        return false; // Todavía hay casillas disponibles
                }
            }

            return true; // Todas las casillas están ocupadas y no hay ganador
        }

        private void ActualizarPuntajes()
        {
            // Actualiza las etiquetas de puntaje
            lblPuntajeJugador1.Text = $"Puntaje Jugador #1: {puntajeJugador1}";
            lblPuntajeJugador2.Text = $"Puntaje Jugador #2: {puntajeJugador2}";
        }

        private void ReiniciarJuego()
        {
            // Reinicia la matriz y las imágenes
            EnceraMatriz();
            ActualizarPuntajes();

            for (int i = 0; i < imagenes.GetLength(0); i++)
            {
                for (int j = 0; j < imagenes.GetLength(1); j++)
                {
                    imagenes[i, j].Image = Tarea_15Juego_3enLineaGrob.Properties.Resources.vacio;
                    imagenes[i, j].Enabled = true;
                }
            }
        }

        private void QuienJuega()
        {
            if (turno)
                this.txtJugador.Text = "tu turno jugador #1";
            else
                this.txtJugador.Text = "tu turno jugador #2";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            turno = true;
            EnceraMatriz();
            QuienJuega();

            imagenes = new PictureBox[3, 3];
            int x;
            int y = 25;

            for (int i = 0; i < imagenes.GetLength(0); i++)
            {
                x = 19;

                for (int j = 0; j < imagenes.GetLength(1); j++)
                {
                    imagenes[i, j] = new PictureBox();
                    imagenes[i, j].Size = new Size(147, 105);
                    imagenes[i, j].Location = new Point(x, y);
                    imagenes[i, j].Image = Tarea_15Juego_3enLineaGrob.Properties.Resources.vacio;
                    imagenes[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i, j].Name = $"MisImagenes_{i}_{j}";
                    imagenes[i, j].Click += new System.EventHandler(this.Jugar_Click);

                    this.groupBox1.Controls.Add(imagenes[i, j]);
                    x += 147;
                }
                y += 107;
            }

            this.btnIniciar.Enabled = false;
        }

        private void EnceraMatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar los puntajes de ambos jugadores
            string mensaje = $"Los puntajes del jugador 1 son: {puntajeJugador1}\n" +
                             $"Los puntajes del jugador 2 son: {puntajeJugador2}\n";

            // Determinar el ganador
            if (puntajeJugador1 > puntajeJugador2)
            {
                mensaje += "El ganador es: Jugador 1";
            }
            else if (puntajeJugador2 > puntajeJugador1)
            {
                mensaje += "El ganador es: Jugador 2";
            }
            else
            {
                mensaje += "Es un empate";
            }

            // Mostrar mensaje y cerrar el juego
            MessageBox.Show(mensaje, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ImprimirMaatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.WriteLine($"{matriz[i, j]}");
            Console.WriteLine();
        }
    }
}
