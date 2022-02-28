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

        private void button1_Click(object sender, EventArgs e)
        {

            var thread = new Thread(() =>
            {
                while (true)
                {
                    var tempo = relogio.Elapsed;
                    var segundos = tempo.TotalSeconds;
                    var minutos = tempo.TotalMinutes;
                    var horas = tempo.TotalHours;
                    var milissegundos = tempo.TotalMilliseconds;


                    //Técica de criar delegate e converter para Action usando this.Invoke
                    this.Invoke((Action)delegate
                    {
                        txtTime.Text = $"{horas:00}:{minutos:00}:{segundos:00}:{milissegundos:000}";
                    });
                }
            });
            thread.Start();
        }


    }
}
