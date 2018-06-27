namespace Event
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public partial class Statistic : Form
    {
        Form opener;
        private MySqlConnection dbConnection;

        public Statistic()
        {
            InitializeComponent();
        }
        
        private int EmployeeId;
        public Statistic(Form parentOpener, int EmployeeId)
        {
            opener = parentOpener;
            InitializeComponent();
            this.EmployeeId = EmployeeId;
        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);
        }
        //Find Visitor
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButton1.Checked && textBox1.Text != string.Empty)
            {
                String sqlStatement = "SELECT * FROM customer where CustomerId = '" + textBox1.Text + "';";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

                dbConnection.Open();
                MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
                
                if (!articlesReader.HasRows)
                {
                    listBox1.Items.Add("There is no such visior with this Id!");
                }

                while (articlesReader.Read())
                {
                    var id = articlesReader[0].ToString();
                    var firstName = articlesReader[1].ToString();
                    var lastName = articlesReader[2].ToString();
                    var email = articlesReader[4].ToString();
                    var age = articlesReader[5].ToString();
                    var balance = articlesReader[6].ToString();
                    var ticketNumber = articlesReader[7].ToString();

                    listBox1.Items.Add($"Id: {id} FirstName {firstName} LastName {lastName} Email {email} Age {age} Balance {balance} TicketNumber {ticketNumber}");
                    listBox1.Items.Add("");
                }
                
            }
            else if (radioButton2.Checked && textBox1.Text != string.Empty)
            {
                String sqlStatement = "SELECT * FROM customer where FirstName = '" + textBox1.Text + "';";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

                dbConnection.Open();
                MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

                if (!articlesReader.HasRows)
                {
                    listBox1.Items.Add("There is no such visior with this Name!");
                }

                while (articlesReader.Read())
                {
                    var id = articlesReader[0].ToString();
                    var firstName = articlesReader[1].ToString();
                    var lastName = articlesReader[2].ToString();
                    var email = articlesReader[4].ToString();
                    var age = articlesReader[5].ToString();
                    var balance = articlesReader[6].ToString();
                    var ticketNumber = articlesReader[7].ToString();

                    listBox1.Items.Add($"Id: {id} FirstName {firstName} LastName {lastName} Email {email} Age {age} Balance {balance} TicketNumber {ticketNumber}");
                    listBox1.Items.Add("");
                }
            }
            else
            {
                listBox1.Items.Add("Please select a visitor first!");
            }
            
            dbConnection.Close();
        }

        //Show all visitors
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "SELECT * FROM customer;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var id = articlesReader[0].ToString();
                var firstName = articlesReader[1].ToString();
                var lastName = articlesReader[2].ToString();
                var email = articlesReader[4].ToString();
                var age = articlesReader[5].ToString();
                var balance = articlesReader[6].ToString();
                var ticketNumber = articlesReader[7].ToString();

                listBox1.Items.Add($"Id: {id} FirstName {firstName} LastName {lastName} Email {email} Age {age} Balance {balance} TicketNumber {ticketNumber}");
                listBox1.Items.Add("");
            }
            dbConnection.Close();
        }

        //Booked and free rooms
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "SELECT COUNT(RoomNumber) FROM `roomreservation`";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var total = articlesReader[0].ToString();
                listBox1.Items.Add("Total Amount of Booked Rooms: " + total);
                listBox1.Items.Add("Total Amount of Free Rooms: " + (24 - Convert.ToInt32(total)));
            }

            dbConnection.Close();
        }

        //Total amount sold per shop
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "SELECT Sum(sp.Quantity*p.Price) as TotalSoldPerProducts FROM storageproducts as sp JOIN product p on sp.StorageProductId = p.StorageProductId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var totalSum = articlesReader[0].ToString();
                listBox1.Items.Add("For the Restaurant shop the total amount of products sold is: " + totalSum);
            }

            dbConnection.Close();

            String sqlStatement2 = "SELECT SUM(sm.Quantity*mt.Price) FROM storagematerials as sm JOIN material m on m.StorageMaterialId = sm.StorageMaterialId JOIN materialtype mt on mt.MaterialTypeId = m.MaterialTypeId;";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, dbConnection);
            var tempList = new List<int>();

            dbConnection.Open();
            MySqlDataReader articlesReader2 = sqlCommand2.ExecuteReader();

            while (articlesReader2.Read())
            {
                var TotalSum = articlesReader2[0].ToString();

                listBox1.Items.Add("For the Material shop the total amount of products sold is: " + TotalSum);
            }

            dbConnection.Close();
        }

        //Total amount of certain product sold
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "SELECT p.Name, 30 - sp.Quantity as total FROM storageproducts as sp JOIN product p on sp.StorageProductId = p.StorageProductId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var name = articlesReader[0].ToString();
                var totalSoldperProduct = articlesReader[1].ToString();
                listBox1.Items.Add("For this product: " + name + " we sold: " + totalSoldperProduct);
            }

            dbConnection.Close();
        }
        
        //All present visitors in the event
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "SELECT COUNT(*) FROM customer Where Status = 1;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var dictionary = new Dictionary<string, int>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                listBox1.Items.Add("The total amount of visitors present at the event now are: " +articlesReader[0].ToString());
            }
            
            dbConnection.Close();
        }

        //Total balance of all visitors together & total spent money
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String sqlStatement = "select c.CustomerId, CONCAT(c.FirstName, ' ', c.LastName) as CustomerName, sum(t.Amount), c.Balance from transactions t join customer c on c.CustomerId = t.CustomerId GROUP By CustomerId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                listBox1.Items.Add("CustomerId: " + articlesReader[0].ToString());
                listBox1.Items.Add("Total amount of money spent: " + articlesReader[1].ToString());
                listBox1.Items.Add("Total balance of the customer: " + articlesReader[2].ToString());
                listBox1.Items.Add("");
            }

            dbConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();
        }
    }
}
