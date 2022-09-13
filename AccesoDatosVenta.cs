using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DPRN3_U3_A1_JHRM
{
    class AccesoDatosVenta
    {
        public static DataTable mostarDatos()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from ventas";
                //MySqlDataAdapter data = new MySqlDataAdapter(sql, con.conectar());
                MySqlCommand cmd = new MySqlCommand(sql, con.conectar());
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.desconectar();

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }


    }
}
