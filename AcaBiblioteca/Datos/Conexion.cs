using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace AcaBiblioteca.Datos
{
    public class Conexion
    {
          private string cadenaConexion = "Server=localhost;Database=AcaBiblioteca;Trusted_Connection=true;TrustServerCertificate=true;";


          public SqlConnection EstablecerConexion()
          {

            return new SqlConnection(cadenaConexion);
          }
    }
}
