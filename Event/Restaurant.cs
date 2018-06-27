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

    public partial class Restaurant : Form
    {
        private MySqlConnection dbConnection;
        RFID reader;
        private string Adder = "";
        private List<string> listOfCardNumbers;

        public Restaurant()
        {
            InitializeComponent();

        }

        Form opener;
        private int EmployeeId;
        private List<string> globalDates;

        public Restaurant(Form parentForm, int EmployeeId)
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
            listOfCardNumbers.Add("2800b820922143");
            listOfCardNumbers.Add("2800b82096");
            listOfCardNumbers.Add("2800b8209213");
            listOfCardNumbers.Add("2800b820922143");
            try
            {
                reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.Open();
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
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
                cardHolderId.Text = list[0];
                lblCardNr.Text = list[3];
                lblBalance.Text = list[2];
                lblCardHld.Text = list[1];          
            }
            else if(e.Tag == "4a0036e2fe")
            {
                lblStatus.Text = "Approved";
                lblStatus.ForeColor = Color.Green;
                button1.Enabled = true;
                button1.BackColor = Color.Orange;
                cardHolderId.Text = "1";
                lblCardHld.Text = "admin";
                lblCardNr.Text = "4a0036e2fe";
                // lblCardNr.Text = list[7];
                lblBalance.Text = "∞";
                //lblBalance.Size = new Size(500, 750);
            }

            dbConnection.Close();

        }


        private void Restaurant_Load(object sender, EventArgs e)
        {
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            String sqlStatement = "SELECT * FROM product;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var id = articlesReader[0].ToString();
                var name = articlesReader[1].ToString();
                var price = articlesReader[2].ToString();
                var ingredients = articlesReader[5].ToString();
                list.Add(id);
                list.Add(name);
                list.Add(price);
                list.Add(ingredients);
            }

            salad1Id.Text = list[0];
            salad1Name.Text = list[1];
            salad1Price.Text = list[2];
            salad1Ing.Text = list[3];

            salad2Id.Text = list[4];
            salad2Name.Text = list[5];
            salad2Price.Text = list[6];
            salad2Ing.Text = list[7];

            salad3Id.Text = list[8];
            salad3Name.Text = list[9];
            salad3Price.Text = list[10];
            salad3Ing.Text = list[11];

            salad4Id.Text = list[12];
            salad4Name.Text = list[13];
            salad4Price.Text = list[14];
            salad4Ing.Text = list[15];

            product5Id.Text = list[16];
            dess1Name.Text = list[17];
            dess1Price.Text = list[18];
            dess1Ing.Text = list[19];

            product6Id.Text = list[20];
            dess2Name.Text = list[21];
            groupBox.Text = list[22];
            dess2Ing.Text = list[23];

            product7Id.Text = list[24];
            dess3Name.Text = list[25];
            dess3Price.Text = list[26];
            dess3Ing.Text = list[27];

            product8Id.Text = list[28];
            dess4Name.Text = list[29];
            dess4Price.Text = list[30];
            dess4Ing.Text = list[31];

            product9Id.Text = list[32];
            meals1Name.Text = list[33];
            meals1Price.Text = list[34];
            meals1Ing.Text = list[35];

            product10Id.Text = list[36];
            meals2Name.Text = list[37];
            meals2Price.Text = list[38];
            meals2Ing.Text = list[39];

            product11Id.Text = list[40];
            meals3Name.Text = list[41];
            meals3Price.Text = list[42];
            meals3Ing.Text = list[43];

            product12Id.Text = list[44];
            meals4Name.Text = list[45];
            meals4Price.Text = list[46];
            meals4Ing.Text = list[47];

            product13Id.Text = list[48];
            drink1Name.Text = list[49];
            drink1Price.Text = list[50];

            product14Id.Text = list[52];
            drink2Name.Text = list[53];
            drink2Price.Text = list[54];

            product15Id.Text = list[56];
            drink3Name.Text = list[57];
            drink3Price.Text = list[58];

            product16Id.Text = list[60];
            drink4Name.Text = list[61];
            drink4Price.Text = list[62];

            product17Id.Text = list[64];
            drink5Name.Text = list[65];
            drink5Price.Text = list[66];

            product18Id.Text = list[68];
            drink6Name.Text = list[69];
            drink6Price.Text = list[70];

            product19Id.Text = list[72];
            drink7Name.Text = list[73];
            drink7Price.Text = list[74];

            product20Id.Text = list[76];
            drink8Name.Text = list[77];
            drink8Price.Text = list[78];

            product21Id.Text = list[80];
            drink9Name.Text = list[81];
            drink9Price.Text = list[82];

            product22Id.Text = list[84];
            drink10Name.Text = list[85];
            drink10Price.Text = list[86];

            product23Id.Text = list[88];
            drink11Name.Text = list[89];
            drink11Price.Text = list[90];

            product24Id.Text = list[92];
            drink12Name.Text = list[93];
            drink12Price.Text = list[94];

            //For Creating new item!

            //GroupBox gb = new GroupBox();
            //Button b = new Button();
            //Label lb1 = new Label();
            //Label lb2 = new Label();
            //Label lb3 = new Label();
            //PictureBox pb = new PictureBox();
            //lb1.Text = "asd1";
            //lb2.Text = "asd2";
            //lb3.Text = "asd3";
            //b.Text = "add";
            //lb1.Location = new Point(12, 30);
            //lb2.Location = new Point(12, 66);
            //lb3.Location = new Point(12, 88);
            //gb.Controls.Add(b);
            //gb.Controls.Add(lb1);
            //gb.Controls.Add(lb2);
            //gb.Controls.Add(lb3);
            //gb.Location = new Point(27, 632);
            //gb.Size = new Size(252, 227);
            //groupBox5.Controls.Add(gb);

            dbConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {salad1Name.Text} Price: {salad1Price.Text}");

                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + salad1Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad1Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {salad1Name.Text} Price: {salad1Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + salad1Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad1Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {salad2Name.Text} Price: {salad2Price.Text}");
                }

                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + salad2Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad2Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {salad2Name.Text} Price: {salad2Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + salad2Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad2Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reader.Close();

            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {salad3Name.Text} Price: {salad3Price.Text}");
                }

                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + salad3Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad3Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {salad3Name.Text} Price: {salad3Price.Text}");

                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + salad3Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad3Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    string temp = item.ToString().Split()[3];
                    list.Add(Convert.ToInt32(temp));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {salad4Name.Text} Price: {salad4Price.Text}");
                }

                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + salad4Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad4Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    string temp = item.ToString().Split()[3];
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {salad4Name.Text} Price: {salad4Price.Text}");

                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + salad4Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + salad4Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnDess1_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {dess1Name.Text} Price: {dess1Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product5Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product5Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {dess1Name.Text} Price: {dess1Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product5Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product5Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnDess2_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {dess2Name.Text} Price: {dess2Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product6Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product6Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {dess2Name.Text} Price: {dess2Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product6Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product6Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnDess3_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {dess3Name.Text} Price: {dess3Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product7Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product7Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {dess3Name.Text} Price: {dess3Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product7Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product7Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnDess4_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {dess4Name.Text} Price: {dess4Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product8Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product8Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {dess4Name.Text} Price: {dess4Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product8Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product8Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnMeal1_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {meals1Name.Text} Price: {meals1Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product9Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product9Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {meals1Name.Text} Price: {meals1Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product9Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product9Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {meals2Name.Text} Price: {meals2Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product10Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product10Id.Text + "');";
                
                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {meals2Name.Text} Price: {meals2Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product10Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product10Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnMeals3_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {meals3Name.Text} Price: {meals3Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product11Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product11Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {meals3Name.Text} Price: {meals3Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product11Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product11Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void btnMeals4_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {meals4Name.Text} Price: {meals4Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product12Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product12Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {meals4Name.Text} Price: {meals4Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product12Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product12Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink1Name.Text} Price: {drink1Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product13Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product13Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink1Name.Text} Price: {drink1Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product13Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product13Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink2Name.Text} Price: {drink2Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product14Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product14Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink2Name.Text} Price: {drink2Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product14Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product14Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink3Name.Text} Price: {drink3Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product15Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product15Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink3Name.Text} Price: {drink3Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product15Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product15Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink4Name.Text} Price: {drink4Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product16Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product16Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink4Name.Text} Price: {drink4Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product16Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product16Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink5Name.Text} Price: {drink5Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product17Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product17Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink5Name.Text} Price: {drink5Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product17Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product17Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink6Name.Text} Price: {drink6Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product18Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product18Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink6Name.Text} Price: {drink6Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product18Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product18Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink7Name.Text} Price: {drink7Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product19Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product19Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink7Name.Text} Price: {drink7Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product19Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product19Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink8Name.Text} Price: {drink8Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product20Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product20Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink8Name.Text} Price: {drink8Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product20Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product20Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink9Name.Text} Price: {drink9Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product21Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product21Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink9Name.Text} Price: {drink9Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product21Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product21Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink10Name.Text} Price: {drink10Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product22Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product22Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink10Name.Text} Price: {drink10Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product22Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product22Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink11Name.Text} Price: {drink11Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product23Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product23Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink11Name.Text} Price: {drink11Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product23Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product23Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            globalDates.Add(dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss"));

            if (!isEmpty17)
            {
                string value = textBox1.Text;
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    lbItems.Items.Add($"Name: {drink12Name.Text} Price: {drink12Price.Text}");
                }
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - " + value + " Where StorageProductId = " + product24Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + value + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product24Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
            else
            {
                lbItems.Items.Add($"Name: {drink12Name.Text} Price: {drink12Price.Text}");
                this.Adder += "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = " + product24Id.Text + ";";
                this.Adder += "INSERT INTO transactions(Date, Amount, CustomerId, EmployeeId, ProductId) VALUES ( '" + date + "', '" + 1 + "', '" + cardHolderId.Text + "', '" + EmployeeId + "', '" + product24Id.Text + "');";

                var list = new List<int>();
                foreach (var item in lbItems.Items)
                {
                    list.Add(Convert.ToInt32(item.ToString().Split()[3]));
                }

                TotalPrice.Text = list.Sum(x => x).ToString();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            bool isEmpty17 = textBox1.Text == string.Empty;
            if (!isEmpty17)
            {
                if (this.lbItems.SelectedItem != null)
                {
                    string selectedItem = lbItems.SelectedItem.ToString();

                    int counter1 = 0;
                    int counter2 = 0;

                    for (int i = 0; i < lbItems.Items.Count; i++)
                    {
                        if (lbItems.Items[i].ToString() == selectedItem)
                        {
                            counter1 += i;
                            break;
                        }
                    }

                    for (int i = 0; i < lbItems.Items.Count; i++)
                    {
                        if (lbItems.Items[i].ToString() == selectedItem)
                        {
                            counter2 = i;
                        }
                    }

                    for (int i = counter1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        lbItems.Items.RemoveAt(counter1);
                    }
                }
                else
                {
                    MessageBox.Show("Please, select items!");
                }
            }
            else
            {
                if (this.lbItems.SelectedItem != null)
                {
                    for (int i = 0; i < lbItems.SelectedItems.Count; i++)
                    {
                        lbItems.Items.Remove(lbItems.SelectedItems[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please, select item!");
                }
            }
            Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var list = new List<int>();
            foreach (var item in lbItems.Items)
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

            if (currentPersonBalance >= price)
            {
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
                    var ProductId = articlesReaderTransaction[5].ToString();

                    listSecond.Add(TransactionId);
                    listSecond.Add(Amount);
                    listSecond.Add(ProductId);
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
                            tempTran += "INSERT INTO productorder(Date, TransactionId) VALUES ( '" + temp1 + "', '" + transactionId + "');";
                         }
                    }
                }
                dbConnection.Open();
                String sqlStatementLoan = tempTran;
                MySqlCommand sqlCommandLoan = new MySqlCommand(sqlStatementLoan, dbConnection);

                MySqlDataReader articlesReaderLoan = sqlCommandLoan.ExecuteReader();
                dbConnection.Close();


                dbConnection.Open();

                String sqlStatementOrders = "SELECT * FROM productorder;";
                MySqlCommand sqlCommandOrders = new MySqlCommand(sqlStatementOrders, dbConnection);
                var listOrders = new List<string>();

                MySqlDataReader articlesReaderOders = sqlCommandOrders.ExecuteReader();

                while (articlesReaderOders.Read())
                {
                    var OrderId = articlesReaderOders[0].ToString();
                    var Date = articlesReaderOders[1].ToString();
                    var transactionID = articlesReaderOders[2].ToString();

                    listOrders.Add(OrderId);
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
                            string amount = listSecond[i - 2];
                            string productId = listSecond[i - 1];

                            for (int o = 0; o < listOrders.Count; o++)
                            {
                                for (int p = 0; p < globalDates.Count; p++)
                                {
                                    string temp3 = listOrders[o];
                                    string temp4 = globalDates[p];
                                    if (temp3 == temp4)
                                    {
                                        tempOrder += "INSERT INTO productorderlines(ProductOrderId,ProductId, Quantity) VALUES ( '" + listOrders[o-1] + "', '" + productId + "', '" + amount + "');";

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateNewProduct cnp = new CreateNewProduct();
            cnp.Show();
            GroupBox gb = new GroupBox();
            Button b = new Button();
            Label lb1 = new Label();
            Label lb2 = new Label();
            Label lb3 = new Label();
            PictureBox pb = new PictureBox();
            lb1.Text = "asd1";
            lb2.Text = "asd2";
            lb3.Text = "asd3";
            b.Text = "add";
            lb1.Location = new Point(12, 30);
            lb2.Location = new Point(12, 66);
            lb3.Location = new Point(12, 88);
            gb.Controls.Add(b);
            gb.Controls.Add(lb1);
            gb.Controls.Add(lb2);
            gb.Controls.Add(lb3);
            gb.Location = new Point(27, 632);
            gb.Size = new Size(252, 227);
            groupBox5.Controls.Add(gb);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox.Visible = false;
            groupBox11.Visible = false;
            groupBox16.Visible = false;
        }

        private void MealsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Visible = false;
            groupBox5.Visible = false;
            groupBox11.Visible = true;
            groupBox16.Visible = false;
        }

        private void DessertsBtn_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            groupBox.Text = "Desserts";
            groupBox5.Visible = false;
            groupBox11.Visible = false;
            groupBox16.Visible = false;
        }

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            groupBox.Visible = false;
            groupBox5.Visible = false;
            groupBox11.Visible = false;
            groupBox16.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            TotalPrice.Text = "0";
        }

        private void product10Id_Click(object sender, EventArgs e)
        {

        }
    }
}
