namespace Event
{
    using MySql.Data.MySqlClient;
    using Phidget22;
    using Phidget22.Events;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class ATMStatic : Form
    {
        public ATMStatic()
        {
            InitializeComponent();
        }

        private RFID reader;
        private Form opener;
        private MySqlConnection dbConnection;

        private int EmployeeId;
        private List<string> globalDates;
        private List<string> listOfCardNumbers;
        
        public ATMStatic(Form parentForm, int EmployeeId)
        {
            InitializeComponent();
            opener = parentForm;
            this.EmployeeId = EmployeeId;
            CheckOut.Enabled = false;
            Cancel.Enabled = false;
            CheckOut.BackColor = Color.Gray;
            Cancel.BackColor = Color.Gray;
            globalDates = new List<string>();

            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            try
            {
                reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

                list.Add(id);
                list.Add(name);
                list.Add(balance);
                list.Add(number);
            }

            if (e.Tag == "2800b82096")
            {
                lblStatus.Text = "Approved";
                lblStatus.ForeColor = Color.Green;
                lblCardNr.Text = list[3];
                lblBalance.Text = list[2];
                lblCardHld.Text = list[1];
                CustomerId.Text = list[0];
                CheckOut.Enabled = true;
                Cancel.Enabled = true;
                CheckOut.BackColor = Color.Orange;
                Cancel.BackColor = Color.Orange;

            }
            dbConnection.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            string temp = "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId) VALUES ( '" + date +"', '"+ textBox1.Text +"','" + CustomerId.Text  + "', '"+ EmployeeId+ "' );";
            temp += "Update `customer` Set Balance = Balance + " + textBox1.Text + " Where TicketNumber = \"" + lblCardNr.Text + "\";";

            MySqlCommand sqlCommand = new MySqlCommand(temp, dbConnection);
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            MessageBox.Show("Funds are successfully added to your account!");
            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnection.Open();

            String sqlStatement = "SELECT * FROM transactions;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();
            
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var customerId = articlesReader[3].ToString();
                var date = articlesReader[1].ToString();
                var amount = articlesReader[2].ToString();

                list.Add(customerId);
                list.Add(date);
                list.Add(amount);
            }

            dbConnection.Close();

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(this.saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    try
                    {

                        sw.WriteLine("NL91 ABNA 0417 1643 00");
                        sw.WriteLine(globalDates[0]);
                        sw.WriteLine(globalDates[globalDates.Count - 1]);
                        sw.WriteLine(globalDates.Count + "");

                        string customerid = "";
                        string amount = "";

                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = 0; j < globalDates.Count; j++)
                            {
                                string temp = list[i];
                                string temp2 = globalDates[j];
                                if (temp == temp2)
                                {
                                    customerid = list[i - 1];
                                    amount = list[i + 1];
                                    sw.WriteLine("{0} {1:F2}" ,customerid, Convert.ToInt32(amount));
                                }
                            }
                        }

                        MessageBox.Show("The File has been successfully generated!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error while writing in the file!");
                    }

                }
                catch (IOException)
                {
                    MessageBox.Show("Something went wrong, IOException was thrown!");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Nothing saved, since you pressed the CANCEL-button!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader.Close();
            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();

        }
    }
}

