using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crudado.Datos
{
    public class Conexion
    {
        protected SqlConnection cnn;

        public Conexion()
        {
            this.Conectar();
        }
        protected void Conectar()
        {
            try
            {
                cnn = new SqlConnection(@"Server=HCI-NOTE227\SQLEXPRESS; Database = crudsito; Trusted_Connection = True");
                //"Server=HCI - NOTE227\\SQLEXPRESS; Initial Catalog = crudsito; Integrated Security = True");
                //"Server=HCI-NOTE227\\SQLEXPRESS; Database=InventoryDb; Trusted_Connection=True"
                cnn.Open();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
        }
        protected void Desconectar()
        {
            try
            {
                //cnn.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
        }

    }
}