using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace labirra
{
    class gestionedb
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public gestionedb()
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
            //string query = string.Format("CREATE TABLE IF NOT EXISTS  testicoli.mossa1 ( `ID_mossa` int(11) NOT NULL,PRIMARY KEY(`ID_mossa`),UNIQUE KEY(`ID_mossa`) ,  `Nome` text NOT NULL,  `Potenza` int(11) NOT NULL,  `Fisica` int(11) NOT NULL,  `Tipo_mossa` text NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1;    INSERT INTO testicoli.`mossa` (`ID_mossa`, `Nome`, `Potenza`, `Fisica`, `Tipo_mossa`) VALUES(1, 'azione', 40, 1, 'normale'),(2, 'foglielama', 55, 1, 'erba'),(3, 'fangobomba', 90, 0, 'veleno'),(4, 'energipalla', 90, 0, 'erba'),(5, 'lanciafiamme', 90, 0, 'fuoco'),(6, 'turbine', 60, 1, 'volante'),(7, 'lacerazione', 70, 1, 'normale'),(8, 'terremoto', 100, 1, 'terra'),(9, 'idrondata', 90, 1, 'acqua'),(10, 'pistolacqua', 50, 0, 'acqua'),(11, 'rocciotomba', 60, 1, 'roccia'),(12, 'sgranocchio', 80, 1, 'buio'),(13, 'geloraggio', 90, 0, 'ghiaccio'),(14, 'fulmine', 90, 0, 'elettro'),(15, 'breccia', 75, 1, 'lotta'),(16, 'sprizzalampo', 90, 1, 'elettro');");
            //string query = string.Format("CREATE TABLE IF NOT EXISTS  testicoli.giovanni ");
            //string query = string.Format($"CREATE TABLE `iscritti` (`nome` VARCHAR(45) NOT NULL,`cognome` VARCHAR(45) NOT NULL,`luogo` VARCHAR(45) NOT NULL,`tipogara` VARCHAR(45) NOT NULL,`datanascita` VARCHAR(45) NOT NULL,`codicetessera` VARCHAR(45) NOT NULL,`password` int(45) NOT NULL,PRIMARY KEY (`codicetessera`))");
            string query = string.Format("zz");
            


            //CODICE PER DROPPARE /CANCELLARE LE TABELLE string query = string.Format($"DROP TABLE iscritti");


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
