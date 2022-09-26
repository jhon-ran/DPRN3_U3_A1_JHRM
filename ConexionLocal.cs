using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DPRN3_U3_A1_JHRM
{
    class ConexionLocal
    {
        //Se declara un objeto de SQl connection
        MySqlConnection con;
        //Se instancia el objeto SQL y se le pasa la cadena de conexión a la BD del programa 
        public ConexionLocal()
        {
            con = new MySqlConnection("Server=localhost;Database=registro_plantas;Uid=root;Pwd=1234;");
        }


        //método para abrir conexión a la BD
        public MySqlConnection conectarLocal()
        {
            try
            {
                con.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos local");
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar correctamente a la Base de Datos local");
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        //método para cerrar conexión a la BD
        public bool desconectarLocal()
        {
            try
            {
                con.Close();
                MessageBox.Show("Se desconectó correctamente a la Base de Datos local");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo desconectar correctamente de la Base de Datos local");
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
    }
}
