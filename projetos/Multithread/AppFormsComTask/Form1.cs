using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsComThread
{
    public partial class MainForm : Form
    {
        Stopwatch relogio;

        public MainForm()
        {
            InitializeComponent();
            relogio = new Stopwatch();
            relogio.Start();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            await showTime();
        }


        async Task showTime() 
        {
                while (true)
                {
                    await Task.Delay(100);
                    var tempo = relogio.Elapsed;
                    var segundos = tempo.TotalSeconds;
                    var minutos = tempo.TotalMinutes;
                    var horas = tempo.TotalHours;
                    var milissegundos = tempo.TotalMilliseconds;


                    txtTime.Text = $"{horas:00}:{minutos:00}:{segundos:00}:{milissegundos:000}";
                }
        } 
    }
}
