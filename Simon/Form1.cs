using System;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Simon{

    public partial class Form1 : Form
    {

        public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);

            using(Pen pen = new Pen(this.ForeColor, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
                e.Graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
        private int elapsedSeconds;
        private List<String> secuencia = new List<String>();
        private List<String> secuenciaJugador = new List<String>();
        private Boolean isAllowed = false;
        private int contadorClicks = 0;
        private int segundosTotales = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Configurar el Timer solo una vez
            timer1.Interval = 1000; // Intervalo de 1 segundo
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int previousSecond = elapsedSeconds;
            elapsedSeconds++;

            // Calcular horas, minutos y segundos
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = (elapsedSeconds % 60) / 2;
            Random random = new Random();

            // Mostrar el tiempo transcurrido en el TextBox
            textBox1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            if(seconds % 2 == 1)
            {
                int randomNumber = random.Next(1, 5);
        
                switch(randomNumber)
                {
                    case 1:
                        button1.BackColor = Color.Red;
                        secuencia.Add("Rojo");
                        break;
                    case 2:
                        button2.BackColor = Color.Blue;
                        secuencia.Add("Azul");
                        break;
                    case 3:
                        button3.BackColor = Color.Yellow;
                        secuencia.Add("Amarillo");
                        break;
                    case 4:
                        button4.BackColor = Color.Lime;
                        secuencia.Add("Verde");
                        break;
                }
            }
            else
            {
                button1.BackColor = Color.DarkRed;
                button2.BackColor = Color.DarkBlue;
                button3.BackColor = Color.DarkOrange;
                button4.BackColor = Color.DarkGreen;
            }
            if(seconds == segundosTotales)
            {
                // Detener el Timer
                timer1.Stop();
                button6.Enabled = false;
                this.isAllowed = true;
            }

        }

        private void ComprobarSecuencias()
        {

            if(contadorClicks==segundosTotales/2)
            {
                String[] secuenciaFixed = new String[segundosTotales/2];
                int contador = 0;
                for(int i = 0; i<segundosTotales; i++)
                {
                    if(i%2==0)
                    {
                        secuenciaFixed[contador] = secuencia[i];
                        contador++;
                    }
                }
                int contadorAciertos = 0;
                for(int i = 0; i < (segundosTotales / 2); i++)
                {
                    if(secuenciaFixed[i] == secuenciaJugador[i])
                    { 
                        contadorAciertos++;
                    }
                }

                if(contadorAciertos == segundosTotales/2)
                {
                    MessageBox.Show("¡Has ganado, avanzas al siguiente nivel! :D");
                    button6.Enabled = true;
                }
                else
                {
                    MessageBox.Show("¡Has perdido! :(");
                    this.segundosTotales = 0;
                    button6.Enabled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Reiniciar el contador de segundos
            contadorClicks = 0;
            elapsedSeconds = 0;
            // Reiniciar las listas
            secuencia.Clear();
            secuenciaJugador.Clear();
            // Detener el Timer si ya estaba en ejecución
            timer1.Stop();
            // Aumentar en 2 el timer
            segundosTotales+=2;
            // Iniciar el Timer
            timer1.Start();
        }

        // Métodos adicionales para otros eventos
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // Botón rojo
        private async void button1_Click(object sender, EventArgs e)
        {
            if(this.isAllowed)
            {
                button1.BackColor = Color.Red;
                secuenciaJugador.Add("Rojo");
                await Task.Delay(1000);
                button1.BackColor = Color.DarkRed;
                this.contadorClicks++;
                ComprobarSecuencias();
            }
        }
        // Botón azul
        private async void button2_Click(object sender, EventArgs e)
        {
            if(this.isAllowed)
            {
                button2.BackColor = Color.Blue;
                secuenciaJugador.Add("Azul");
                await Task.Delay(1000);
                button2.BackColor = Color.DarkBlue;
                this.contadorClicks++;
                ComprobarSecuencias();
            }

        }
        // Botón naranja
        private async void button3_Click(object sender, EventArgs e)
        {
            if(this.isAllowed)
            {
                button3.BackColor = Color.Yellow;
                secuenciaJugador.Add("Amarillo");
                await Task.Delay(1000);
                button3.BackColor = Color.DarkOrange;
                this.contadorClicks++;
                ComprobarSecuencias();
            }
        }
        // Botón verde
        private async void button4_Click(object sender, EventArgs e)
        {
            if(this.isAllowed)
            {
                button4.BackColor = Color.Lime;
                secuenciaJugador.Add("Verde");
                await Task.Delay(1000);
                button4.BackColor = Color.DarkGreen;
                this.contadorClicks++;
                ComprobarSecuencias();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) { }


        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}