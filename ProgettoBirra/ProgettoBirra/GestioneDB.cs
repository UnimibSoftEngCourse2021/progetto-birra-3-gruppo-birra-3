﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProgettoBirra
{
    //inizializzazione variabili globali
    public class Globals {
        public static string emailGlobal;
        public static string passwordGlobal;
        public static List<ProdottoMapper> listaProdotti = new List<ProdottoMapper>();
        public static List<AttrezzoMapper> listaAttrezzi = new List<AttrezzoMapper>();
        public static List<RicettaMapper> listaRicette = new List<RicettaMapper>();
    }
    class GestioneDB
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
       

        //Constructor
        public GestioneDB()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "den1.mysql3.gear.host";
            database = "birradb";
            uid = "birradb";
            password = "password.";
            string connectionString;
            connectionString = @"SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        //create table
        public void create_table()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXIST `Utenti` (`email` VARCHAR(45) NOT NULL,`password` VARCHAR(45) NOT NULL, PRIMARY KEY (`email`))");
            //string query = string.Format("DROP TABLE `iscritti`");

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //cmd.ExecuteNonQuery();

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo creazione tabella prodotto
        public void create_tableProd()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `Prodotto` (`proprietario` VARCHAR(45) NOT NULL,`nomeProd` VARCHAR(45) NOT NULL,`quantita` INT NOT NULL,`idProdotto` INT NOT NULL AUTO_INCREMENT, PRIMARY KEY (`idProdotto`), CONSTRAINT `emailp` FOREIGN KEY (`proprietario`) REFERENCES `Utenti` (`email`))");
            //string query = string.Format("DROP TABLE `Prodotto`");

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //cmd.ExecuteNonQuery();

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo creazione tabella attrezzo
        public void create_tableAtt()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `Attrezzo` (`idAttrezzo` INT NOT NULL AUTO_INCREMENT, `nomeAtt` VARCHAR(45) NOT NULL, `proprietario` VARCHAR(45) NOT NULL, `capacita` INT NOT NULL, PRIMARY KEY(`idAttrezzo`), CONSTRAINT `emailat` FOREIGN KEY(`proprietario`) REFERENCES `Utenti` (`email`))");
            //string query = string.Format("DROP TABLE `attrezzo`");

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //cmd.ExecuteNonQuery();

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo creazione tabella ricetta
        public void create_tableRic()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `Ricetta` (`idRicetta` INT NOT NULL AUTO_INCREMENT, `nomeRic` VARCHAR(45) NOT NULL, `preparazione` VARCHAR(1000) NULL, `note` VARCHAR(1000) NULL, `proprietario` VARCHAR(45) NOT NULL, `elencoAttrezzi` VARCHAR(1000) NOT NULL, PRIMARY KEY(`idRicetta`), CONSTRAINT `emailr`FOREIGN KEY(`proprietario`) REFERENCES `Utenti` (`email`))");
            //string query = string.Format("DROP TABLE `Ricetta`");

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //cmd.ExecuteNonQuery();

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        public void create_tableProdHasRicetta()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `prodRicetta` (`idRicetta` INT NOT NULL, `nomeProd` VARCHAR(45) NOT NULL,  `quantita` INT NOT NULL, CONSTRAINT `idRicettar`FOREIGN KEY(`idRicetta`) REFERENCES `ricetta` (`idRicetta`))");
            //string query = string.Format("DROP TABLE `ricetta`");

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //cmd.ExecuteNonQuery();

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";


            create_table();

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        public void InsertUtente(string email, string password)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            string query = "INSERT INTO Utenti (email, password) VALUES('"+email+ "', '" + password + "')";

            //create_table();

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }


        //Metodo per inserire un nuovo prodotto nel DB
        public void InsertProd(string emailp, string nomeProd, int quantita)
        {
            string query = "INSERT INTO Prodotto (proprietario, nomeProd, quantita) VALUES('" + emailp + "', '" + nomeProd + "','" + quantita + "')";

            
            //create_table();

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Metodo per inserire un nuovo attrezzo nel DB
        public void InsertAtt(string emailat, string nomeAtt, int capacita)
        {
            string query = "INSERT INTO Attrezzo (proprietario, nomeAtt, capacita) VALUES('" + emailat + "', '" + nomeAtt + "','" + capacita + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Metodo per inserire un nuovo attrezzo nel DB
        public void InsertRic(string nomeRic, string attrezzi, string preparazione, string note)
        {
            /*
            string[] ListaAtrezzi = attrezzi.Split('\n');
            string[] ListaProdotti = prodotti.Split('\n');

            foreach (var sub in ListaAtrezzi) {
                MessageBox.Show($"valore: {sub}");
            }
            foreach (var sub in ListaProdotti)
            {
                MessageBox.Show($"valore: {sub}");
            }*/

            string query = "INSERT INTO Ricetta (nomeRic, preparazione, note, proprietario, elencoAttrezzi) VALUES('" + nomeRic + "', '" + preparazione + "','" + note + "', '" + Globals.emailGlobal + "', '" + attrezzi + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Aggiunta di un prodotto relativo ad una ricetta
        public void InsertProdRic(int idRicetta, string nome, int quantita)
        {
           

            string query = "INSERT INTO prodricetta (idRicetta, nomeProd, quantita) VALUES('" + idRicetta + "', '" + nome + "','" + quantita + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }
        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

 
        public void UpdateUtente(string email, string password)
        {
            //
            
            //query modifica Utente
            string query = "UPDATE utenti SET email='" + email + "', password='" + password + "' WHERE email='" + Globals.emailGlobal + "' AND password='" + Globals.passwordGlobal + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }


        //Update di un prodotto
        public void UpdateProd(string nomeProd, int nuovaQT)
        {
            string query = "UPDATE Prodotto SET quantita='" + nuovaQT + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeProd='" + nomeProd + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Update di un attrezzo
        public void UpdateAtt(string nomeAtt, int nuovaCP)
        {
            string query = "UPDATE Attrezzo SET capacita='" + nuovaCP + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeAtt ='" + nomeAtt + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Update di una ricetta
        public void UpdateRic(string nomeRic, string note)
        {
            string query = "UPDATE Ricetta SET note='" + note + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeRic ='" + nomeRic + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }



        //Elimina Utente
        public void DeleteUtente()
        {
            string query = "DELETE FROM Utenti WHERE email='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }
        
        //elimina tutti i prodotti associati all'utente 
        public void DeleteProdUtente()
        {
            string query = "DELETE FROM Prodotto WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Prodotto
        public void DeleteProd(string nomeProd)
        {
            string query = "DELETE FROM Prodotto WHERE nomeProd='" + nomeProd + "' AND proprietario='"+ Globals.emailGlobal +"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Attrezzo
        public void DeleteAtt(string nomeAtt)
        {
            string query = "DELETE FROM Attrezzo WHERE nomeAtt='" + nomeAtt + "' AND proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Ricetta
        public void DeleteRic(string nomeRic)
        {
            MessageBox.Show("sto eliminando " + nomeRic + "con proprietario " + Globals.emailGlobal);
            string query = "DELETE FROM Ricetta WHERE nomeRic='" + nomeRic + "' AND proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Prodotti relatiti alla Ricetta
        public void DeleteProdRic(int idRicetta)
        {
            MessageBox.Show("sto eliminando la ricetta con id " + idRicetta);
            string query = "DELETE FROM prodRicetta WHERE idRicetta='" + idRicetta + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //recupero delle ricette associate ad un utente
        public void recuperoRic()
        {
            string query = "SELECT * FROM Ricetta WHERE proprietario = '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeRic = "";
                string preparazione = "";
                string note = "";
                string idRicetta = "";
                string attrezzi = "";
               


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeRic = $"{reader.GetString("nomeRic")}";
                    preparazione = $"{reader.GetString("preparazione")}";
                    note = $"{reader.GetString("note")}";
                    idRicetta = $"{reader.GetString("idRicetta")}";
                    attrezzi = $"{reader.GetString("elencoAttrezzi")}";
                    Globals.listaRicette.Add(new RicettaMapper(nomeRic, note, preparazione, idRicetta,attrezzi));
                }



                //close Connection
                this.CloseConnection();


            }

           
        }

        //recupero dei prodotti associati ad una ricetta di un utente
        public void recuperoProd(string idRic)
        {
            string query = "SELECT * FROM prodricetta WHERE idRicetta= '"+ Convert.ToInt32(idRic) + "'";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeProd = "";
                string quantita = "";



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeProd = $"{reader.GetString("nomeProd")}";
                    quantita = $"{reader.GetString("quantita")}";
                    Globals.listaProdotti.Add(new ProdottoMapper(nomeProd, quantita));
                }



                //close Connection
                this.CloseConnection();


            }


        }

        //recupera id ricetta
        public int recuperoIdRic(string nomeric)
        {
            string idric="";
            string query = "SELECT idRicetta FROM Ricetta WHERE proprietario = '" + Globals.emailGlobal + "' AND nomeRic='" + nomeric + "'";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   idric = $"{reader.GetString("idRicetta")}";
                  
                }

                //close Connection
                this.CloseConnection();
                
            }
            //Convert.ToInt32(idric);
            int valoreRitorno = Convert.ToInt32(idric);
            return valoreRitorno;



        }
        //ricercaUtente(login)
        public bool SelectUtente(string email, string password)
        {
            Globals.emailGlobal = email;
            Globals.passwordGlobal = password;

            string query = "SELECT Utenti.email,Utenti.password FROM Utenti WHERE Utenti.email = '" + email + "' AND Utenti.password = '" + password + "'";

        
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";
                string p = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("email")};";
                    p += $"{reader.GetString("password")};";
                }

                //MessageBox.Show("a = " + a.ToString());
                //MessageBox.Show("b = " + b.ToString());

                //close Connection
                this.CloseConnection();


                if (e == "" || p == "")
                    return false;


                //return list to be displayed
                //utente.setEmail(e);
                //utente.setPassword(p);
                /*Globals.emailGlobal = e;
                Globals.passwordGlobal = p;*/
                return true;
            }

            return false;
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }






    }
}

