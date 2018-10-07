using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormTurnos.AccesoBBDD;

namespace WindowsFormTurnos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        Conexion miConexion;
        private Timer tiempo;

        public Form1()
        {
            InitializeComponent();
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(eventoReloj);
            tiempo.Enabled = true;
            miConexion = new Conexion();
        }

        private void eventoReloj(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lblHoraActual.Text = hoy.ToString("H:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miConexion.OpenConnection();
            fechaActual();
        }

        private void fechaActual()
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
        }
    }
}
