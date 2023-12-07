//using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace RPGQuest
{
    public partial class frmRPG : Form
    {
        // Initialisation des variables globales
        private MySqlConnection connection;
        private int nbPiece = 500;
        private int nbPointsRepartitions=20;
        public frmRPG()
        {
            InitializeComponent();
            // Initialisation et connection a la DB
            InitializeDatabaseConnection();
            // chargement de la combo Arme depuis la base de données
            loadArmes();
            // Initialisation des champs libellés par défaut
            lblpieces.Text = nbPiece.ToString();
            lblPoints.Text = nbPointsRepartitions.ToString();
            // Chargement de l'image et ajustement
            picPieces.Image = Image.FromFile(@"money.png");
            picPieces.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmRPG_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDatabaseConnection()
        {
           // string connectionString = "Server=localhost;Database=RPGQuest;User ID=root;Password=;";
           // connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.10.40",
                UserID = "sio1-tp4",
                Password = "Sio1TP4.31",
                Database = "rpgquest",
            };
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connexion à la base de données réussie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}", "Erreur de connexion");
            }
        }

        public class Arme
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void loadArmes()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, nom, type FROM armes", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string nom = row["nom"].ToString();
                    string type = row["type"].ToString();

                    // Ajoutez un élément à la combobox en utilisant le nom de l'arme
                    // et conservez l'id de l'arme comme valeur associée à l'élément.
                    Arme uneArme = new Arme { Text = nom, Value = id, Type = type };
                    comboBoxArmes.Items.Add(uneArme);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }

        private void btnPlusForce_Click(object sender, EventArgs e)
        {
            if (nbPointsRepartitions > 0)
            {
                pgbForce.Value = pgbForce.Value + 1;
                nbPointsRepartitions--;
                lblPoints.Text = nbPointsRepartitions.ToString();
            }
        }
    }
}
