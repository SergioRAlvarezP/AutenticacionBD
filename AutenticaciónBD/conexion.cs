using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace AutenticaciónBD
{
    class conexion
    {
        public MySqlConnection conn = new MySqlConnection("Database=test;Server=localhost;Uid=sergio;Password=06051990");//conexión autentica al servidor
        public MySqlCommand comando = new MySqlCommand(); //Para insertar a la base de datos.
        public DataSet ds = new DataSet();
        public DataSet comparar()
        {
            conn.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT Usuario as user,Contraseña as password FROM usuarios",conn);
            mda.Fill(ds,"usuarios");
            conn.Close();
            return ds;
        }
    }
}
