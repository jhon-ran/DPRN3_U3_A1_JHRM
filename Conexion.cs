using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DPRN3_U3_A1_JHRM
{
  
    class Conexion
    {
        //Se declara un objeto de SQl connection
        MySqlConnection con;
        //Se instancia el objeto SQL y se le pasa la cadena de conexión a la BD del programa 
        public Conexion()
        {
            con = new MySqlConnection("Server=35.197.23.46;Port=3306;Database=dprn3u3;Uid=estudiante;Pwd=dprn3pass;");
        }


        //método para abrir conexión a la BD
        public MySqlConnection conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar correctamente a la Base de Datos");
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        //método para cerrar conexión a la BD
        public bool desconectar()
        {
            try
            {
                con.Close();
                MessageBox.Show("Se desconectó correctamente a la Base de Datos");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo desconectar correctamente de la Base de Datos");
                MessageBox.Show(ex.ToString());
                return false; 
            }

        }
    }
}
