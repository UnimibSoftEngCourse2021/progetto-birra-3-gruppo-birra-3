﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ProgettoBirra
{
    //Inizializzazione variabili globali, in modo da poterle recuperare all'interno di tutto il progetto.
    public static class Globals {
        public static string emailGlobal;
        public static string passwordGlobal;
        public static List<ProdottoMapper> listaProdotti = new List<ProdottoMapper>();
        public static List<AttrezzoMapper> listaAttrezzi = new List<AttrezzoMapper>();
        public static List<RicettaMapper> listaRicette = new List<RicettaMapper>();
        public static List<ListaSpesaMapper> listaSpesa = new List<ListaSpesaMapper>();
        public static List<ProdottoMapper> listaProdottiUtente = new List<ProdottoMapper>();
        public static List<ProdottoMapper> listaProdottiRicettaUtente = new List<ProdottoMapper>();
        public static List<CheBirraFaccio> listaDisponibilitaBirra = new List<CheBirraFaccio>();
        public static int n = 999;
    }
    class GestioneDB
    {
        private MySqlConnection connection;

        //Constructor
        public GestioneDB()
        {
            Initialize();
        }

        //Inizializzazione dei parametri del database remoto per permettere la connessione
        private void Initialize()
        {  
            string server;
        string database;
        string uid;
        string password;


        server = "den1.mysql3.gear.host";
            database = "birradb";
            uid = "birradb";
            password = "password.";
            string connectionString;
            connectionString = @"SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Metodo che permette di aprire la connessione con il DB
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
             
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

        //Metodo che permette di chiudere la connessione con il DB
        private void CloseConnection()
        {
            try
            {
                connection.Close();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        //Metodo che permette di creare la tabaella utenti nel database.
        public void create_table()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXIST `Utenti` (`email` VARCHAR(45) NOT NULL,`password` VARCHAR(45) NOT NULL, PRIMARY KEY (`email`))");
            //string query = string.Format("DROP TABLE `iscritti`");

            //open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                

                cmd.ExecuteNonQueryAsync();

               
                this.CloseConnection();
            }
        }

        //metodo creazione tabella prodotto
        public void create_tableProd()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `Prodotto` (`proprietario` VARCHAR(45) NOT NULL,`nomeProd` VARCHAR(45) NOT NULL,`quantita` INT NOT NULL,`idProdotto` INT NOT NULL AUTO_INCREMENT, PRIMARY KEY (`idProdotto`), CONSTRAINT `emailp` FOREIGN KEY (`proprietario`) REFERENCES `Utenti` (`email`))");
            //string query = string.Format("DROP TABLE `Prodotto`");

            //open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

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
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

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
            if (this.OpenConnection())
            {
               
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo creazione tabella prodotto di una determinata ricetta
        public void create_tableProdHasRicetta()
        {
            string query = string.Format($"CREATE TABLE IF NOT EXISTS `prodRicetta` (`idRicetta` INT NOT NULL, `nomeProd` VARCHAR(45) NOT NULL,  `quantita` INT NOT NULL, `proprietario` VARCHAR(45) NOT NULL, CONSTRAINT `idRicettar`FOREIGN KEY(`idRicetta`) REFERENCES `ricetta` (`idRicetta`))");
            //string query = string.Format("DROP TABLE `prodRicetta`");

            //open connection
            if (this.OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo creazione tabella lista della spesa
        public void create_tableListaDellaSpesa()
        {
             string query = string.Format($"CREATE TABLE IF NOT EXISTS `ListaDellaSpesa` (`proprietario` VARCHAR(45) NOT NULL, `Prodotto` VARCHAR(100) NOT NULL, `Quantita` int NOT NULL, CONSTRAINT `proprietarior` FOREIGN KEY(`proprietario`) REFERENCES `utenti` (`email`))");
            //string query = string.Format("DROP TABLE `ListaDellaSpesa`");

            //open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //metodo per verifica se l'utente inserito esiste nel database
        public bool verificaUtente(string email)
        {
            string query = "SELECT Utenti.email FROM Utenti WHERE Utenti.email = '" + email + "'";

            //Open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("email")};";
                    
                }

                //close Connection
                this.CloseConnection();

                //controllo se il risultato della query è un elemento vuoto (utente non presente) o il contrario.
                if (e == "")
                    return false;

                return true;
            }
            return false;
        }

        //metodo per verificare che un attrezzo non sia già presente nel db
        public bool verificaAttr(string nome)
        {
            string query = "SELECT attrezzo.nomeAtt FROM attrezzo WHERE attrezzo.nomeAtt = '" + nome + "'AND attrezzo.proprietario='" + Globals.emailGlobal + "'";

            //Open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("nomeAtt")};";

                }

                //close Connection
                this.CloseConnection();

                //controllo se il risultato della query è un elemento vuoto (attrezzo non presente) o il contrario.
                if (e == "")
                    return false;

                return true;
            }
            return false;
        }

        //metodo per verificare che un prodotto non sia già presente nel db
        public bool verificaProd(string nome)
        {
            string query = "SELECT prodotto.nomeProd FROM prodotto WHERE prodotto.nomeProd= '" + nome + "' AND prodotto.proprietario='" + Globals.emailGlobal + "'";

            //Open connection
            if (this.OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("nomeProd")};";

                }

                //close Connection
                this.CloseConnection();

                //controllo se il risultato della query è un elemento vuoto (prodotto non presente) o il contrario.
                if (e == "")
                    return false;

                return true;
            }
            return false;
        }

        //metodo per verificare che una ricetta non sia già presente nel db
        public bool verificaRic(string nome)
        {
            string query = "SELECT ricetta.nomeRic FROM ricetta WHERE ricetta.nomeRic= '" + nome + "'AND ricetta.proprietario='" + Globals.emailGlobal + "'";

            //Open connection
            if (this.OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("nomeRic")};";

                }

                //close Connection
                this.CloseConnection();

                //controllo se il risultato della query è un elemento vuoto (ricetta non presente) o il contrario.
                if (e == "")
                    return false;

                return true;
            }
            return false;
        }

        //metodo per verificare che ci sia abbastanza quantità di un prodotto per una ricetta
        public int verificaQuantitaProd(string nome, int quantita)
        {
            string query = "SELECT prodotto.quantita FROM prodotto WHERE prodotto.nomeProd= '" + nome + "' AND prodotto.proprietario='" + Globals.emailGlobal + "'";

            //Open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                //recupero la quantità di prodotto che l'utente ha a disposizione
                while (reader.Read())
                {
                    e += $"{reader.GetString("quantita")}";

                }

                //close Connection
                this.CloseConnection();


                //verifichiamo che la quantità sia abbastanza per fare la ricetta.
                int quanitaMancante = Convert.ToInt32(e) - quantita;

                if (quanitaMancante < 0) 
                {
                    return (quanitaMancante * -1);
                }
                    
                else 
                { 
                    return 0;
                }
            }
            return 9999;
        }

        //metodo per verificare che un prodotto non sia già presente nella lista della spesa
        public bool verificaProdListaSpesa(string nome)
        {
            string query = "SELECT ListaDellaSpesa.Prodotto FROM ListaDellaSpesa WHERE ListaDellaSpesa.Prodotto= '" + nome + "' AND ListaDellaSpesa.proprietario='" + Globals.emailGlobal + "'";

            //Open connection
            if (this.OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string e = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e += $"{reader.GetString("Prodotto")};";

                }

                //close Connection
                this.CloseConnection();

                //controllo se il risultato della query è un elemento vuoto (prodotto non presente) o il contrario.
                if (e == "")
                    return false;

                return true;
            }
            return false;
        }

        //metodo per inserire un nuovo utente del DB
         public void InsertUtente(string email, string password)
        {
            if (email.Contains("@") && email.Contains("."))
            {

                string query = "INSERT INTO Utenti (email, password) VALUES('" + email + "', '" + password + "')";

                //verifichiamo che l'utente non sia già presente nel DB.
                if (!verificaUtente(email))
                {
                    //open connection
                    if (this.OpenConnection())
                    {

                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQueryAsync();

                        //close connection
                        this.CloseConnection();
                        MessageBox.Show("Registrazione completata");
                    }
                }
                else
                {
                    MessageBox.Show("Nome utente già esistente");
                }
            }
            else {
                MessageBox.Show("Errore inserimento email"); 
            }
            
        }

        //Metodo per inserire un nuovo prodotto nel DB
        public void InsertProd(string emailp, string nomeProd, int quantita)
        {
            string query = "INSERT INTO Prodotto (proprietario, nomeProd, quantita) VALUES('" + emailp + "', '" + nomeProd + "','" + quantita + "')";

            //Verifichiamo che il prodotto non sia già presente nel DB
            if (!verificaProd(nomeProd))
            {

                //open connection
                if (this.OpenConnection())
                {
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQueryAsync();

                    //close connection
                    this.CloseConnection();
                    MessageBox.Show("Il prodotto è stato inserita nella dispensa");
                }
            }
            else
            {
                MessageBox.Show("Prodotto già presente nella dispensa");
            }
    }

        //Metodo per inserire un nuovo attrezzo nel DB
        public void InsertAtt(string nomeAtt, int capacita)
        {
            string query = "INSERT INTO Attrezzo (proprietario, nomeAtt, capacita) VALUES('" + Globals.emailGlobal+ "', '" + nomeAtt + "','" + capacita + "')";

            //controllo che l'attrezzo non sia già presente nel DB.
            if (!verificaAttr(nomeAtt))
            {
                //open connection
                if (this.OpenConnection())
                {
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQueryAsync();

                    //close connection
                    this.CloseConnection();
                    MessageBox.Show("L'attrezzo è stato inserito nel magazzino");
                }
            }
            else
            { MessageBox.Show("Attrezzatura già presente nel magazzino"); }
        }

        //Metodo per inserire una nuova ricetta nel DB
        public void InsertRic(string nomeRic, string attrezzi, string preparazione, string note)
        {
            string query = "INSERT INTO Ricetta (nomeRic, preparazione, note, proprietario, elencoAttrezzi) VALUES('" + nomeRic + "', '" + preparazione + "','" + note + "', '" + Globals.emailGlobal + "', '" + attrezzi + "')";

            //open connection
            if (this.OpenConnection())
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
            string query = "INSERT INTO prodricetta (idRicetta, nomeProd, quantita, proprietario) VALUES('" + idRicetta + "', '" + nome + "','" + quantita + "','" + Globals.emailGlobal+"')";

            //open connection
            if (this.OpenConnection())
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Inserisci prodotti nella lista della spesa una volta preparata la ricetta
        public void InsertListaSpesa(string prodotto, int quantita)
        {
            string query = "INSERT INTO ListaDellaSpesa (proprietario, Prodotto, quantita) VALUES('" + Globals.emailGlobal  + "', '" + prodotto+ "', '" + quantita + "')";

            //open connection
            if (this.OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }
         
        //Metodo per la modifica della password di un utente
        public void UpdateUtente( string password)
        {
            string query = "UPDATE utenti SET password='" + password + "' WHERE password='" + Globals.passwordGlobal + "'";

            //Open connection
            if (this.OpenConnection() )
            {
                
                MySqlCommand cmd = new MySqlCommand();
               
                cmd.CommandText = query;
                
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQueryAsync();

                //close connection
                this.CloseConnection();
            }
        }

        //Metodo per la modifica della quantita di un prodotto
        public void UpdateProd(string nomeProd, int nuovaQT)
        {
            string query = "UPDATE Prodotto SET quantita='" + nuovaQT + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeProd='" + nomeProd + "'";

            //Open connection
            if (this.OpenConnection() )
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

        //Metodo per la modifica della capacità di un attrezzo
        public void UpdateAtt(string nomeAtt, int nuovaCP)
        {
            string query = "UPDATE Attrezzo SET capacita='" + nuovaCP + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeAtt ='" + nomeAtt + "'";

            //Open connection
            if (this.OpenConnection() )
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

        //Metodo per la modifica delle note di una ricetta
        public void UpdateRic(string nomeRic, string note)
        {
            string query = "UPDATE Ricetta SET note='" + note + "' WHERE proprietario='" + Globals.emailGlobal + "' AND nomeRic ='" + nomeRic + "'";

            //Open connection
            if (this.OpenConnection() )
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

        //Metodo per il riempimento della lista della spesa, se i prodotti sono già presenti viene modificata la quantità.
        public void UpdateListaDellaSpesa(int numero, string nomeProd)
        {
            string query = "UPDATE ListaDellaSpesa SET quantita=quantita+" + numero + " WHERE proprietario='" + Globals.emailGlobal + "' AND Prodotto ='" + nomeProd + "'";

            //Open connection
            if (this.OpenConnection() )
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
        
        //Elimina Utente
        public void DeleteUtente()
        {
            string query = "DELETE FROM Utenti WHERE email='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }
        
        //Elimina tutti i prodotti associati all'utente 
        public void DeleteProdUtente()
        {
            string query = "DELETE FROM Prodotto WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina tutti gli attrezzi associati all'utente 
        public void DeleteAttrezziUtente()
        {
            string query = "DELETE FROM Attrezzo WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina tutti i prodotti associati alle ricette dell'utente 
        public void DeleteProdRicettaUtente()
        {
            string query = "DELETE FROM prodRicetta WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina tutte le ricette dell'utente 
        public void DeleteRicetteUtente()
        {
            string query = "DELETE FROM Ricetta WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina la lista della spesa di un utente
        public void DeleteSpesa()
        {
            string query = "DELETE FROM listadellaspesa WHERE proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Prodotto passato come attributo
        public void DeleteProd(string nomeProd)
        {
            string query = "DELETE FROM Prodotto WHERE nomeProd='" + nomeProd + "' AND proprietario='"+ Globals.emailGlobal +"'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Attrezzo passato come attributo
        public void DeleteAtt(string nomeAtt)
        {
            string query = "DELETE FROM Attrezzo WHERE nomeAtt='" + nomeAtt + "' AND proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Ricetta passata come attributo
        public void DeleteRic(string nomeRic)
        {
            string query = "DELETE FROM Ricetta WHERE nomeRic='" + nomeRic + "' AND proprietario='" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }

        //Elimina Prodotti relatiti alla Ricetta
        public void DeleteProdRic(int idRicetta)
        {
            string query = "DELETE FROM prodRicetta WHERE idRicetta='" + idRicetta + "'";

            if (this.OpenConnection() )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQueryAsync();
                this.CloseConnection();
            }
        }
         


        //Recupero delle ricette associate ad un utente
        public void recuperoRic()
        {
            string query = "SELECT * FROM Ricetta WHERE proprietario = '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
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

        //Metodo per recuperare la lista della spesa di un determinato utente
        public void recuperoListaSpesa()
        {
            string query = "SELECT * FROM listadellaspesa WHERE proprietario = '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeProd = "";
                string quantita = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeProd = $"{reader.GetString("Prodotto")}";
                    quantita = $"{reader.GetString("Quantita")}";
                    Globals.listaSpesa.Add(new ListaSpesaMapper(nomeProd,quantita));
                }

                //close Connection
                this.CloseConnection();

            }
        }

        //Recupero delle attrezzature di un determinato utente
        public void recuperoAttr()
        {
            string query = "SELECT * FROM attrezzo WHERE proprietario= '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeAtt= "";
                string capacita = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeAtt = $"{reader.GetString("nomeAtt")}";
                    capacita = $"{reader.GetString("capacita")}";
                    Globals.listaAttrezzi.Add(new AttrezzoMapper(nomeAtt,capacita));
                }

                //close Connection
                this.CloseConnection();
            }
        }
        
        //Recupero dei prodotti di un determinato utente
        public void recuperoProdUtente()
        {
            string query = "SELECT * FROM prodotto WHERE proprietario= '" + Globals.emailGlobal + "'";

          if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeProdotto = "";
                string quantita = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeProdotto = $"{reader.GetString("nomeProd")}";
                    quantita = $"{reader.GetString("quantita")}";
                    Globals.listaProdotti.Add(new ProdottoMapper(nomeProdotto, quantita));
                }

                //close Connection
                this.CloseConnection();
            }
        }
        
        //Recupero dei prodotti associati ad una ricetta di un utente
        public void recuperoProd(string idRic)
        {
            string query = "SELECT * FROM prodricetta WHERE idRicetta= '"+ Convert.ToInt32(idRic) + "' AND proprietario = '" + Globals.emailGlobal+"'";

            if (this.OpenConnection() )
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

        //Recupero della quantita di un prodotto 
        public int recuperoQuantitaProd(string nomeProd)
        {
            string quantita = "";
            string query = "SELECT quantita FROM prodotto WHERE nomeProd= '" + nomeProd+ "' AND proprietario = '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    quantita = $"{reader.GetString("quantita")}";
                }

                //close Connection
                this.CloseConnection();
            }
            return (Convert.ToInt32(quantita));
        }

        //Metodo per recuperare il nome di una ricetta, dato il suo ID
        public string recuperoNomeRic(int id)
        {
            string nomeRic="";
            string query = "SELECT nomeRic FROM Ricetta WHERE proprietario = '" + Globals.emailGlobal + "' AND idRicetta='" + id + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeRic = $"{reader.GetString("nomeRic")}";

                }

                //close Connection
                this.CloseConnection();

            }
            return nomeRic;
        }
        
        //Recupera id della ricetta passata come attributo
        public int recuperoIdRic(string nomeric)
        {
            string idric="";
            string query = "SELECT idRicetta FROM Ricetta WHERE proprietario = '" + Globals.emailGlobal + "' AND nomeRic='" + nomeric + "'";

            if (this.OpenConnection() )
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
            if (this.OpenConnection() )
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
                //close Connection
                this.CloseConnection();


                if (e == "" || p == "")
                    return false;

                return true;
            }
            return false;
        }

        //Metodo che permette di svolgere la funzionalità: Che birra faccio.
        public void cheBirraFaccioOggi(int idRic) {

            //Recupero di tutti i prodotti di un determinato utente
            string query = "SELECT * FROM prodotto WHERE proprietario= '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string nomeProdotto = "";
                string quantita = "";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomeProdotto = $"{reader.GetString("nomeProd")}";
                    quantita = $"{reader.GetString("quantita")}";
                    Globals.listaProdottiUtente.Add(new ProdottoMapper(nomeProdotto, quantita));
                }

                //close Connection
                this.CloseConnection();

            }

            //Recupero di tutti i prodotti relativi alla ricetta richiesta.
            string query2 = "SELECT * FROM prodricetta WHERE idRicetta= '" + Convert.ToInt32(idRic) + "' AND proprietario = '" + Globals.emailGlobal + "'";

            if (this.OpenConnection() )
            {
                //Create Command
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                string nomeProd = "";
                string quantita = "";

                MySqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    nomeProd = $"{reader2.GetString("nomeProd")}";
                    quantita = $"{reader2.GetString("quantita")}";
                    Globals.listaProdottiRicettaUtente.Add(new ProdottoMapper(nomeProd, quantita));
                }

                //close Connection
                this.CloseConnection();

            }

            int min = 9999;

            bool blocco1 = true;
            
            for (int i = 0; i < Globals.listaProdottiRicettaUtente.Count; i++){
                if (blocco1)
                {
                    for (int j = 0; j < Globals.listaProdottiUtente.Count; j++)
                    {
                        if (Globals.listaProdottiRicettaUtente[i].getNome().Equals(Globals.listaProdottiUtente[j].getNome()))
                        {
                           
                            int quantitaRicetta = Convert.ToInt32(Globals.listaProdottiRicettaUtente[i].getQuantita());
                            int quantitaProdotto = Convert.ToInt32(Globals.listaProdottiUtente[j].getQuantita());

                            int numVolteProd = quantitaProdotto / quantitaRicetta;
                            if (numVolteProd >= 1)
                            {
                                if (numVolteProd < Globals.n) {

                                    Globals.n = numVolteProd;
                                    
                                    if (Globals.n < min)
                                    {
                                        min = Globals.n;
                                    }
                                }
                                
                            }
                            else {
                                blocco1 = false;
                                break;
                            }
                        }
                    }
                }
            }
            if (min != 9999) {
                Globals.listaDisponibilitaBirra.Add(new CheBirraFaccio(idRic, min));
            }
        }

    }
}