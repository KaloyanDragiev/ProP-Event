namespace Event
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using Phidget22;
    using Phidget22.Events;

    public partial class Materials : Form
    {
        private MySqlConnection dbConnection;
        RFID reader;

        private int EmployeeId;
        private string Adder = "";
        private List<string> globalDates;
        private int QuantityOfMaterialsOne;
        private int QuantityOfMaterialsTwo;
        private int QuantityOfMaterialsThree;
        private int QuantityOfMaterialsFour;
        private List<string> listOfCardNumbers;

        public Materials()
        {
            InitializeComponent();
        }

        Form opener;

        public Materials(Form parentForm, int EmployeeId)
        {
            InitializeComponent();
            opener = parentForm;
            this.EmployeeId = EmployeeId;
            listOfCardNumbers = new List<string>();
            globalDates = new List<string>();
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            try
            {
                reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.Open();
                button5.Enabled = false;
                button5.BackColor = Color.Gray;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            ShowMaterials();

            QuantityOfMaterialsOne = Convert.ToInt32(status1lb.Text.Split()[1]);
            QuantityOfMaterialsTwo = Convert.ToInt32(status2lb.Text.Split()[1]);
            QuantityOfMaterialsThree = Convert.ToInt32(status3lb.Text.Split()[1]);
            QuantityOfMaterialsFour = Convert.ToInt32(status4lb.Text.Split()[1]);

            dbConnection.Close();
        }

        private void ShowMaterials()
        {
            String sqlStatement =
                "SELECT * FROM material as m JOIN storagematerials sm on sm.StorageMaterialId = m.StorageMaterialId JOIN materialtype mt on mt.MaterialTypeId = m.MaterialTypeId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();

            dbConnection.Open();
            MySqlDataReader materialsReader = sqlCommand.ExecuteReader();

            while (materialsReader.Read())
            {
                var materialID = materialsReader[0].ToString();
                var quantity = materialsReader[6].ToString();
                var materialType = materialsReader[7].ToString();
                var name = materialsReader[8].ToString();
                var price = materialsReader[9].ToString();

                list.Add(materialID);
                list.Add(quantity);
                list.Add(materialType);
                list.Add(name);
                list.Add(price);
            }


            materialId1.Text = list[0];
            mtrl1TypeLbl.Text = list[2];
            mrtl1Name.Text = list[3];
            price1lb.Text = list[4];

            if (Convert.ToInt32(list[1]) > 0)
            {
                status1lb.Text = "Left: " + list[1];
                status1lb.ForeColor = Color.Green;
            }
            else
            {
                status1lb.Text = "No more left!";
                status1lb.ForeColor = Color.Red;
            }

            materialId2.Text = list[5];
            mtrl2TypeLbl.Text = list[7];
            mtrl2Name.Text = list[8];
            price2lb.Text = list[9];

            if (Convert.ToInt32(list[6]) > 0)
            {
                status2lb.Text = "Left: " + list[6];
                status2lb.ForeColor = Color.Green;
            }
            else
            {
                status2lb.Text = "No more left!";
                status2lb.ForeColor = Color.Red;
            }

            materialId3.Text = list[10];
            mtrl3TypeLbl.Text = list[12];
            mtrl3Name.Text = list[13];
            price3lb.Text = list[14];

            if (Convert.ToInt32(list[11]) > 0)
            {
                status3lb.Text = "Left: " + list[11];
                status3lb.ForeColor = Color.Green;
            }
            else
            {
                status3lb.Text = "No more left!";
                status3lb.ForeColor = Color.Red;
            }

            materialId4.Text = list[15];
            mtrl4TypeLbl.Text = list[17];
            mtrl4Name.Text = list[18];
            price4lb.Text = list[19];

            if (Convert.ToInt32(list[16]) > 0)
            {
                status4lb.Text = "Left: " + list[16];
                status4lb.ForeColor = Color.Green;
            }
            else
            {
                status4lb.Text = "No more left!";
                status4lb.ForeColor = Color.Red;
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
                cardHolderId.Text = list[0];
                lblCardNr.Text = list[3];
                lblBalance.Text = list[2];
                lblCardHld.Text = list[1];
                button5.Enabled = true;
                button5.BackColor = Color.Orange;

            }
            dbConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader.Close();

            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(materialId1.Text);
            String sqlStatement = "Update `storagematerials` Set Quantity = Quantity + 1 Where StorageMaterialId = " + number + ";";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            dbConnection.Close();

            ShowMaterials();
            dbConnection.Close();
        }

        private void btnMtrl1_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(date);

            if (!isEmpty17)
            {
                if (QuantityOfMaterialsOne != 0 && QuantityOfMaterialsOne >= Convert.ToInt32(textBox1.Text))
                {
                    string value = textBox1.Text;
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        listBox1.Items.Add($"Material Type: {mtrl1TypeLbl.Text} Name: {mrtl1Name.Text} Price: {price1lb.Text} ");
                    }

                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - " + value + " Where StorageMaterialId = " + materialId1.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId1.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
            else
            {
                if (QuantityOfMaterialsOne != 0)
                {
                    listBox1.Items.Add($"Name: {mrtl1Name.Text} Price: {price1lb.Text}");
                    
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - 1 Where StorageMaterialId = " + materialId1.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId1.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
        }

        private void materialsGB_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void price3lb_Click(object sender, EventArgs e)
        {

        }

        private void return3btn_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(materialId3.Text);
            String sqlStatement = "Update `storagematerials` Set Quantity = Quantity + 1 Where StorageMaterialId = " + number + ";";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            dbConnection.Close();

            ShowMaterials();
            dbConnection.Close();
        }

        private void return2btn_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(materialId2.Text);
            String sqlStatement = "Update `storagematerials` Set Quantity = Quantity + 1 Where StorageMaterialId = " + number + ";";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            dbConnection.Close();

            ShowMaterials();
            dbConnection.Close();
        }

        private void return4btn_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(materialId4.Text);
            String sqlStatement = "Update `storagematerials` Set Quantity = Quantity + 1 Where StorageMaterialId = " + number + ";";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            dbConnection.Close();

            ShowMaterials();
            dbConnection.Close();
        }

        private void btnMtrl3_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(date);

            if (!isEmpty17)
            {
                if (QuantityOfMaterialsThree != 0 && QuantityOfMaterialsThree >= Convert.ToInt32(textBox1.Text))
                {
                    string value = textBox1.Text;
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        listBox1.Items.Add($"Name: {mtrl3Name.Text} Price: {price3lb.Text}");
                    }
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - " + value + " Where StorageMaterialId = " + materialId3.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId3.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
            else
            {
                if (QuantityOfMaterialsThree != 0)
                {
                    listBox1.Items.Add($"Name: {mtrl3Name.Text} Price: {price3lb.Text}");
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - 1 Where StorageMaterialId = " + materialId3.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId3.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
        }

        private void btnMtrl2_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(date);

            if (!isEmpty17)
            {
                if (QuantityOfMaterialsTwo != 0 && QuantityOfMaterialsTwo >= Convert.ToInt32(textBox1.Text))
                {
                    string value = textBox1.Text;
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        listBox1.Items.Add($"Name: {mtrl2Name.Text} Price: {price2lb.Text}");
                    }
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - " + value + " Where StorageMaterialId = " + materialId2.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId2.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
            else
            {
                if (QuantityOfMaterialsTwo != 0)
                {
                    listBox1.Items.Add($"Name: {mtrl2Name.Text} Price: {price2lb.Text}");
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - 1 Where StorageMaterialId = " + materialId2.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId2.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
        }

        private void btnMtrl4_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(date);

            if (!isEmpty17)
            {
                if (QuantityOfMaterialsFour != 0 && QuantityOfMaterialsFour >= Convert.ToInt32(textBox1.Text))
                {
                    string value = textBox1.Text;
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        listBox1.Items.Add($"Name: {mtrl4Name.Text} Price: {price4lb.Text}");
                    }
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - " + value + " Where StorageMaterialId = " + materialId4.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId4.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
            else
            {
                if (QuantityOfMaterialsFour != 0)
                {
                    listBox1.Items.Add($"Name: {mtrl4Name.Text} Price: {price4lb.Text}");
                    this.Adder += "Update `storagematerials` Set Quantity = Quantity - 1 Where StorageMaterialId = " + materialId4.Text + ";";
                    this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, MaterialTypeId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + materialId4.Text + "');";

                    var list = new List<int>();
                    foreach (var item in listBox1.Items)
                    {
                        list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                    }

                    TotalPrice.Text = list.Sum(x => x).ToString();
                }
                else
                {
                    MessageBox.Show("There are not enough materials left!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            bool isEmpty17 = textBox1.Text == string.Empty;
            if (!isEmpty17)
            {
                if (this.listBox1.SelectedItem != null)
                {
                    string selectedItem = listBox1.SelectedItem.ToString();

                    int counter1 = 0;
                    int counter2 = 0;

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString() == selectedItem)
                        {
                            counter1 += i;
                            break;
                        }
                    }

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString() == selectedItem)
                        {
                            counter2 = i;
                        }
                    }

                    for (int i = counter1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        listBox1.Items.RemoveAt(counter1);
                    }
                }
                else
                {
                    MessageBox.Show("Please, select items!");
                }
            }
            else
            {
                if (this.listBox1.SelectedItem != null)
                {
                    for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please, select item!");
                }
            }
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = new List<int>();
            foreach (var item in listBox1.Items)
            {
                list.Add(Convert.ToInt32(item.ToString().Split()[3]));
            }

            TotalPrice.Text = list.Sum(x => x).ToString();

            String sqlStatement = "SELECT * FROM customer;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            List<string> temp = new List<string>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                string balance = articlesReader[6].ToString();
                string cardNumber = articlesReader[7].ToString();
                temp.Add(balance);
                temp.Add(cardNumber);
            }

            dbConnection.Close();
            int currentPersonBalance = 0;
            string ticketnumber = "";

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < listOfCardNumbers.Count; j++)
                {
                    if (temp[i] == listOfCardNumbers[j])
                    {
                        currentPersonBalance = Convert.ToInt32(temp[i - 1]);
                        ticketnumber = listOfCardNumbers[j];
                        break;
                    }
                }
            }

            int price = Convert.ToInt32(TotalPrice.Text);

            // Check if Customer has enough money!!!

            if (currentPersonBalance >= price)
            {
                //execute queries...

                dbConnection.Open();

                this.Adder += "Update `customer` Set Balance = Balance - " + price + " Where TicketNumber = \"" + ticketnumber + "\";";

                MySqlCommand sqlCommand2 = new MySqlCommand(Adder, dbConnection);
                MySqlDataReader articlesReader2 = sqlCommand2.ExecuteReader();

                dbConnection.Close();

                dbConnection.Open();

                String sqlStatementTransactions = "SELECT * FROM transactions;";
                MySqlCommand sqlCommandTransaction = new MySqlCommand(sqlStatementTransactions, dbConnection);
                var listSecond = new List<string>();

                MySqlDataReader articlesReaderTransaction = sqlCommandTransaction.ExecuteReader();

                while (articlesReaderTransaction.Read())
                {
                    var TransactionId = articlesReaderTransaction[0].ToString();
                    var Date = articlesReaderTransaction[1].ToString();
                    var Amount = articlesReaderTransaction[2].ToString();
                    var MaterialId = articlesReaderTransaction[6].ToString();

                    listSecond.Add(TransactionId);
                    listSecond.Add(Amount);
                    listSecond.Add(MaterialId);
                    listSecond.Add(Date);
                }

                dbConnection.Close();

                string tempTran = "";
                for (int i = 0; i < listSecond.Count; i++)
                {
                    for (int j = 0; j < globalDates.Count; j++)
                    {
                        string temp1 = listSecond[i];
                        string temp2 = globalDates[j];
                        if (temp1 == temp2)
                        {
                            string transactionId = listSecond[i - 3];
                            Random rnd = new Random();//-----------------------------------change auto increment!!!
                            int a = rnd.Next(1, 4);
                            tempTran += "INSERT INTO loan(LoanId, Date, TransactionId) VALUES (' " + a + " ', ' " + temp1 + " ', ' " + transactionId + " '); ";
                        }
                    }
                }

                dbConnection.Open();
                String sqlStatementLoan = tempTran;
                MySqlCommand sqlCommandLoan = new MySqlCommand(sqlStatementLoan, dbConnection);
                MySqlDataReader articlesReaderLoan = sqlCommandLoan.ExecuteReader();
                dbConnection.Close();



                dbConnection.Open();

                String sqlStatementOrders = "SELECT * FROM loan;";
                MySqlCommand sqlCommandOrders = new MySqlCommand(sqlStatementOrders, dbConnection);
                var listOrders = new List<string>();

                MySqlDataReader articlesReaderOders = sqlCommandOrders.ExecuteReader();

                while (articlesReaderOders.Read())
                {
                    var LoanId = articlesReaderOders[0].ToString();
                    var Date = articlesReaderOders[1].ToString();
                    var transactionID = articlesReaderOders[2].ToString();

                    listOrders.Add(LoanId);
                    listOrders.Add(Date);
                    listOrders.Add(transactionID);
                }

                dbConnection.Close();

                string tempOrder = "";

                for (int i = 0; i < listSecond.Count; i++)
                {
                    for (int j = 0; j < globalDates.Count; j++)
                    {
                        string temp1 = listSecond[i];
                        string temp2 = globalDates[j];
                        if (temp1 == temp2)
                        {
                            //string amount = listSecond[i - 2];
                            string materialId = listSecond[i - 1];

                            for (int o = 0; o < listOrders.Count; o++)
                            {
                                for (int p = 0; p < globalDates.Count; p++)
                                {
                                    string temp3 = listOrders[o];
                                    string temp4 = globalDates[p];
                                    if (temp3 == temp4)
                                    {
                                        tempOrder += "INSERT INTO material(LoanId, Returned, MaterialTypeId, StorageMaterialId) VALUES ( '" + listOrders[o-1] + "', '" + 0 + "', '" + materialId + "', '" + materialId + "' );";
                                    }
                                }
                            }
                        }
                    }
                }

                dbConnection.Open();
                String sqlStatementOrderLines = tempOrder;
                MySqlCommand sqlCommandOrderLines = new MySqlCommand(sqlStatementOrderLines, dbConnection);

                MySqlDataReader articlesReaderOrderLines = sqlCommandOrderLines.ExecuteReader();
                dbConnection.Close();


                MessageBox.Show("Transaction was successfully executed!");

                dbConnection.Close();
            }
            else
            {
                MessageBox.Show("You do not have enough money in your event account!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TotalPrice.Text = "0";
        }
    }
}
