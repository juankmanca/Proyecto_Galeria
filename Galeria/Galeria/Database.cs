using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Galeria
{
    class Database
    {
        MySqlConnection galeriaC = new MySqlConnection();
        public Database()
        {

            galeriaC.ConnectionString = "server = 127.0.0.1; "
                            + "uid= root; "
                            + "pwd= root; "
                            + "database= galeria;";
            galeriaC.Open();
        }

        public int insertdate(Usuario user)
        {
            int sw = 0;
            
            try
            {
                //ingresar datos en la tabla persona
                string sql = "INSERT INTO `persona` (`PersonaID`,"
                + " `Cedula`, `Nombre`)"
                + " VALUES(NULL,'" + user.Cedula + "','" + user.Nombre + "');";
                MySqlCommand command = new MySqlCommand(sql);
                command.Connection = galeriaC;
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                sw = 1;
            }
            int Resultado=0; // Variable aux donde guardaremos la consulta
                                     //Si a este campo le ponemos el valor que deberia ir en PersonaID(persona) y
                                     //el de PersonaID(Usuario), logra hacer la consulta 2
            if (sw == 0)
            {
                try
                {
                    //Pasar el ultimo valor de PersonaID a UsuarioID
                    String query = "SELECT MAX(`PersonaID`) FROM `persona`;";


                    MySqlCommand command3 = new MySqlCommand(query);
                    command3.Connection = galeriaC;
                    MySqlDataReader reader = command3.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int.TryParse(Convert.ToString(row["PersonaID"]), out Resultado);
                        
                       
                        return Resultado;
                    }
                    
                    //MessageBox.Show(Resultado); //Esto es para ver que me guarda la consulta, que al parecer no es nada,
                                                //Sin embargo tampoco me saca un error de sintaxis
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }

                try
                {
                    //Ingresar Datos a la tabla Usuario
                    string sql2 = "INSERT INTO `usuario`(`UsuarioID`, `NombreUsuario`, `Avatar`, `PersonaID`)" +
                    " VALUES (NULL,'" + user.NombreUsuario + "','" + user.Avatar + "','" + Resultado + "');";
                    MySqlCommand command2 = new MySqlCommand(sql2);
                    command2.Connection = galeriaC;
                    command2.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return sw;
        }

       
    }
}

