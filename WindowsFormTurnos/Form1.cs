using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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
            efectosDataGridView();
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
                Turno nuevo = new Turno();
                nuevo.nombre = txtNombre.Text;
                nuevo.documento = Convert.ToInt32( txtDni.Text);
                
                if (ckbCito.Checked)
                {
                   nuevo.cito = 1;
                }

                if (ckbEritro.Checked)
                {
                   nuevo.eritro = 1;
                }

                if (ckbReti.Checked)
                {
                    nuevo.reti = 1;
                }

                nuevo.idHora = Convert.ToInt32(cboHora.SelectedValue);


                if (MetroFramework.MetroMessageBox.Show(this, "Se recomienda revisar que los pedidos esten correctos antes de continuar. Desea registrar el turno? ", "Registrar turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    
                    miGestor.generarTurno(nuevo);
                    string parametro = txtFecha.Text.Trim();
                    cargarDataGrid(dataGridView1, "select * from turnoslab ");
                    lblExisteTurno.Text = "";
                    btnGrabarTurno.Enabled = false;    
                }
            }

            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.ToString());
            }
        }

        public void efectosDataGridView()
        {
            
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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


        



        private void btnVerificarTurno_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(cboHora.SelectedValue);
            string fecha = txtFecha.Text;

            if (miGestor.GetDisponibilidadHora(id, fecha))
            {
                lblExisteTurno.Text = "Disponible";
                lblExisteTurno.ForeColor = Color.Green;
                btnGrabarTurno.Enabled = true;
            }
            else
            {
                lblExisteTurno.Text = "No Disponible";
                lblExisteTurno.ForeColor = Color.Red;
                btnGrabarTurno.Enabled = false;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtDni.Focus();
                return;
            }
        }
    }
}
