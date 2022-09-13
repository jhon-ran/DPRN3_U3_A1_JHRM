using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U3_A1_JHRM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            //Prueba de conexión
            Conexion q1 = new Conexion();
            q1.conectar();
            q1.desconectar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Métoido para llenar el Data Grid
        private void llenarGrid()
        {
            DataTable datos = AccesoDatosVenta.mostarDatos();

 
            if (datos == null)
            {
                MessageBox.Show("No se pudo acceder a los datos de la BD"); 
            }
            else
            {
                dgLista.DataSource = datos.DefaultView;
                //Contar los registros cargados
                int registros = datos.Rows.Count;
                //Pasar el conteo al Strip Status Label
                toolStripStatusLabel3.Text = registros.ToString();
            }
        }

        //Se carga el método llenarGrid desde el inicio del programa
        private void Main_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
