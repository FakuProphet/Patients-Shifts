using MySql.Data.MySqlClient;
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
using WindowsFormTurnos.Clases;

namespace WindowsFormTurnos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        Conexion miConexion;
        private Timer tiempo;
        GestorTurno miGestor;

        public Form1()
        {
            InitializeComponent();
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(eventoReloj);
            tiempo.Enabled = true;
            miConexion = new Conexion();
            miGestor = new GestorTurno();
        }

        private void eventoReloj(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lblHoraActual.Text = hoy.ToString("H:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fechaActual();
            cargarCombo(cboHora,"horas");
        }

        private void fechaActual()
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = miGestor.realizarConsulta(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }

        private void btnGrabarTurno_Click(object sender, EventArgs e)
        {

            try
            {
                Paciente nuevo = new Paciente();
                nuevo.nombre = txtCodigoPaciente.Text;
                nuevo.doc = txtDni.Text;
              

                if (ckbExt.Checked)
                {
                   int ext = 1;
                }

                if (ckbCito.Checked)
                {
                   int cito = 1;
                }

                if (ckbEritro.Checked)
                {
                   int eritro = 1;
                }

                if (ckbReti.Checked)
                {
                    int reti = 1;
                }


                if (MetroFramework.MetroMessageBox.Show(this, "Se recomienda revisar que los pedidos esten correctos antes de continuar. Desea registrar el turno? ", "Registrar turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    string tabla = "Turnos";
                    miGestor.generarTurno(codigo, idHora, tabla, ext, cito, eritro, reti);
                    string parametro = txtFecha.Text.Trim();
                    cargarDataGrid(dataGridView1, "select * from turnoslab v where fecha like '%" + parametro + "%'");
                    lblExisteTurno.Text = "";
                    btnGrabarTurno.Enabled = false;
                    
                }
            }

            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.ToString());
            }
        }


        public void cargarDataGrid(DataGridView miDataGrid, string consulta)
        {
            DataSet miDataSet = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, miConexion.OpenConnection());
            da.Fill(miDataSet);
            miConexion.CloseConnection();
            miDataGrid.RowHeadersVisible = false;
            miDataGrid.AllowUserToAddRows = false;
            miDataGrid.AllowUserToDeleteRows = false;
            miDataGrid.AllowUserToOrderColumns = false;
            miDataGrid.AllowUserToResizeColumns = true;
            miDataGrid.AllowUserToResizeRows = false;
            miDataGrid.AutoResizeColumns();
            miDataGrid.DataSource = miDataSet.Tables[0];
            //estas dos lineas siguientes indican q las celdas se ajusten al contenido
            //-----------------------------------------------------------------------
            miDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           // miDataGrid.BorderStyle = BorderStyle.None;
            //---------------------------------------------------------------------
        }

    }
}
