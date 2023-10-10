using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryGraffiIE
{
    internal class clsAccesoBase
    {
        //Declaraciòn de variable y objetos globales
        OleDbConnection conexionBD;
        OleDbCommand comandarBD;
        OleDbDataReader BDDataReader;

        DirectoryInfo rutaProyecto = new DirectoryInfo(@"../..");

        string cadenaConexion;

        public string resultadoDatos;

        public bool estadoConexion; //verdado-conectado y si es falso-desconectado

        //constructor: cuando se crea un objeto de la clase acceso base
        public clsAccesoBase()
        {
            estadoConexion = false;

            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + rutaProyecto.FullName + "\\BaseDatos.accdb";
        }

        public void ConectarBaseDatos()
        {
            conexionBD = new OleDbConnection(cadenaConexion);
            conexionBD.Open();
            estadoConexion = true;
        }

        public void TraerDatos()
        {
            comandarBD = new OleDbCommand();

            comandarBD.Connection = conexionBD;
            comandarBD.CommandType = System.Data.CommandType.TableDirect;
            comandarBD.CommandText = "Users";

            BDDataReader = comandarBD.ExecuteReader();

            if (BDDataReader.HasRows)
            {
                while (BDDataReader.Read())
                {
                    resultadoDatos += BDDataReader.GetInt32(0).ToString();
                    resultadoDatos += " - " + BDDataReader.GetString(1);
                    resultadoDatos += " - " + BDDataReader.GetString(2);
                }
            }
        }

        public void TraerDatos(ComboBox listaUsers)
        {
            comandarBD = new OleDbCommand();

            comandarBD.Connection = conexionBD;
            comandarBD.CommandType = System.Data.CommandType.TableDirect;
            comandarBD.CommandText = "Users";

            BDDataReader = comandarBD.ExecuteReader();

            if (BDDataReader.HasRows)
            {
                while (BDDataReader.Read())
                {

                    listaUsers.Items.Add(BDDataReader.GetString(1));

                }
            }
        }

    }



}

