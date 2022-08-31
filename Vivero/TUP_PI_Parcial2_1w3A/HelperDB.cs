using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUP_PI_Parcial2_1w3A;

namespace TUP_PI_Parcial2_13A
{

    class HelperDB
    {
        private SqlConnection cnn;

        public HelperDB()
        {
            cnn = new SqlConnection(@"Data Source=138.99.7.66,1433;Initial Catalog=TUPI_Vivero;User ID=tup1_vivero;Password=@tup1_Vive");
        }

        public DataTable EjecutarQuery(string query)
        {
            SqlCommand cmd;
            DataTable table;

            cnn.Open();
            cmd = new SqlCommand(query, cnn);
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }

        public int EjecutarNonQuery(string query, Planta oPlanta)
        {
            SqlCommand cmd;
            int filas;
            cnn.Open();
            cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@codigo", oPlanta.pCodigo);
            cmd.Parameters.AddWithValue("@nombre", oPlanta.pNombre);
            cmd.Parameters.AddWithValue("@precio", oPlanta.pPrecio);
            cmd.Parameters.AddWithValue("@especie", oPlanta.pEspecie);
            cmd.Parameters.AddWithValue("@fecha", oPlanta.pFecha);
            filas = cmd.ExecuteNonQuery();

            cnn.Close();
            return filas;
        }
    }
    
}

