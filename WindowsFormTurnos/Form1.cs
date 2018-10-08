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

        private void btnGrabarTurno_Click(object sender, EventArgs e)
        {

            try
            {
                int codigo = Convert.ToInt32(txtCodigoPaciente.Text);
                int idHora = Convert.ToInt32(cboHora.SelectedValue);
                int ext = 0; int cito = 0; int eritro = 0; int reti = 0;

                if (ckbExt.Checked)
                {
                    ext = 1;
                }

                if (ckbCito.Checked)
                {
                    cito = 1;
                }

                if (ckbEritro.Checked)
                {
                    eritro = 1;
                }

                if (ckbReti.Checked)
                {
                    reti = 1;
                }


                if (MetroFramework.MetroMessageBox.Show(this, "Se recomienda revisar que los pedidos esten correctos antes de continuar. Desea registrar el turno? ", "Registrar turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tabla = "Turnos";
                    miGestor.generarTurno(codigo, idHora, tabla, ext, cito, eritro, reti);
                    string parametro = txtFecha.Text.Trim();
                    miGestor.cargarDataGrid(dataGridView1, "select * from turnos v where fecha like '%" + parametro + "%'");
                    lblExisteTurno.Text = "";
                    btnGrabarTurno.Enabled = false;
                }
            }

            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.ToString());
            }
        }
    }
}
