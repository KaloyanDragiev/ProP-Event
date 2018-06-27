namespace Event
{
    using System;
    using Phidget22;
    using System.Drawing;
    using Phidget22.Events;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using System.Collections.Generic;

    public partial class VisitorCheckInOut : Form
    {
        public VisitorCheckInOut()
        {
            InitializeComponent();
        }

        private Form opener;
        private RFID reader;
        private MySqlConnection dbConnection;
        private int EmployeeId;

        public VisitorCheckInOut(Form parentOpener, int EmployeeId)
        {
            opener = parentOpener;
            InitializeComponent();
            this.EmployeeId = EmployeeId;
        }

        private void VisitorCheckInOut_Load(object sender, EventArgs e)
        {
            try
            {
                reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);
        }

        private void Reader_Tag(object sender, RFIDTagEventArgs e)
        {
            String sqlStatement = "SELECT * FROM customer;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var id = articlesReader[0].ToString();
                var name = articlesReader[1].ToString();
                var balance = articlesReader[6].ToString();
                var number = articlesReader[7].ToString();
                var status = articlesReader[8].ToString();

                list.Add(id);
                list.Add(name);
                list.Add(balance);
                list.Add(number);
                list.Add(status);
            }
            dbConnection.Close();

            if (e.Tag == "2800b82096")
            {
                lblStatus.Text = "Approved";
                lblStatus.ForeColor = Color.Green;

                cardHolderId.Text = list[0];
                lblCardNr.Text = list[3];
                lblBalance.Text = list[2];
                lblCardHld.Text = list[1];

                if (list[4] == string.Empty || list[4] == "False")
                {
                    statusIn.Text = "Not in the Event!";
                    statusIn.ForeColor = Color.Red;

                    welcome.Text = "Welcome to Mercedes-Benz Event!";
                    welcomeLabel2.Text = "Thank you for choosing the best event in the world!";
                    welcomeOrGoodbye3.Text = "We hope you enjoy your stay!";

                    dbConnection.Open();
                    String sqlStatement2 = "Update `customer` Set Status = 1 Where TicketNumber = \"" + lblCardNr.Text + "\";";
                    MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, dbConnection);
                    MySqlDataReader articlesReader2 = sqlCommand2.ExecuteReader();
                    dbConnection.Close();
                }
                else
                {
                    statusIn.Text = "In the Event!";
                    statusIn.ForeColor = Color.Green;

                    welcome.Text = "";
                    welcomeLabel2.Text = "";
                    welcomeOrGoodbye.Text = "GoodBye!";
                    welcomeOrGoodbye2.Text = "See you soon!";
                    welcomeOrGoodbye3.Text = "We hope you enjoyed your stay!";

                    dbConnection.Open();
                    String sqlStatement2 = "Update `customer` Set Status = 0 Where TicketNumber = \"" + lblCardNr.Text + "\";";
                    MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, dbConnection);
                    MySqlDataReader articlesReader2 = sqlCommand2.ExecuteReader();
                    dbConnection.Close();
                }
                
            }

            dbConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();
        }
    }
}
