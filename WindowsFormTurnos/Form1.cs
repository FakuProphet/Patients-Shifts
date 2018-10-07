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

        public Form1()
        {
            InitializeComponent();
            miConexion = new Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            miConexion.OpenConnection();
        }
    }
}
