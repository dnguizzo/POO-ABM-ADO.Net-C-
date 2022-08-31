using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace U5_Alumnos_5_2
{
    class ConexionDB
    {
        private string conexionString;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private DataTable tabla; 



        public ConexionDB()
        {
            conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=alumnosADO;Integrated Security=True";
            cnn = new SqlConnection(conexionString);
        }

        public DataTable ConsultarSQL(string consulta)
        {
            cnn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text; //  por defecto es una query
            cmd.Connection = cnn;
            tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;

        }

        public int EjecutarSQL (string consulta, List<Parametro> lstParametro)
        {
            int filasafectadas = 0;
            cnn.Open();
            cmd = new SqlCommand();
            cmd. CommandText = consulta;
            cmd. Connection = cnn;

            foreach (Parametro p in lstParametro)
            {
                cmd.Parameters.AddWithValue(p.Nombre,p.Valor);

            }

           filasafectadas = cmd.ExecuteNonQuery();
           cnn.Close();
            return filasafectadas;
        }

    }

    
    
}
