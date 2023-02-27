using crudado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crudado.Datos
{
	public class PersonaAdmin : Conexion
	{
		public IEnumerable<PersonaModel> Consultar()
		{
			Conectar();
			List<PersonaModel> lista = new List<PersonaModel>();
			try
			{
                SqlCommand comando = new SqlCommand("spconsultar", cnn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                SqlDataReader lector = comando.ExecuteReader();
				while (lector.Read())
				{
					PersonaModel modelo = new PersonaModel()
					{
						Id = int.Parse(lector[0].ToString()),
						Nombre = lector[1] + "",
						Apellido = lector[2] + "",
						Edad = int.Parse(lector[3] + "")
					};
					lista.Add(modelo);
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.StackTrace);
			}
			finally
			{
				Desconectar();
			}
			return lista;
		}

		public void Guardar(PersonaModel modelo)
		{
			Conectar();
			try
			{
                SqlCommand comando = new SqlCommand("spguardar", cnn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@nombre", modelo.Nombre);
                comando.Parameters.AddWithValue("@apellido", modelo.Nombre);
                comando.Parameters.AddWithValue("@edad", modelo.Edad);
				comando.ExecuteNonQuery();
            }
			catch (Exception)
			{

				throw;
			}
		}
	}
}