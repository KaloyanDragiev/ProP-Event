namespace Event
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    public partial class CreateNewProduct : Form
    {
        private string Adder = "";
        private MySqlConnection dbConnection;
        Form opener;
        public CreateNewProduct()
        {
            InitializeComponent();
        }
        public CreateNewProduct(Form parentForm)
        {
            opener = parentForm;
            InitializeComponent();
        }

        private void CreateNewProduct_Load(object sender, EventArgs e)
        {
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                String sqlStatement = "INSERT INTO storageproducts(Quantity) Values ( '" + tbQty.Text + "');";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
                var reader =sqlCommand.ExecuteReader();
        
                dbConnection.Close();

                dbConnection.Open();

                String sqlStatementSt = "SELECT * FROM storageproducts;";

                MySqlCommand sqlCommandSt = new MySqlCommand(sqlStatementSt, dbConnection);
                var st = sqlCommandSt.ExecuteReader();
                var list = new List<string>();

                while (st.Read())
                {
                    var stId = st[0].ToString();
                    list.Add(stId);
                }

                dbConnection.Close();
                
                String sqlStatement1 = "Insert Into product(Name, Price, StorageProductId, Type, Ingredients) Values ('" + 
                                       tbName.Text + "', '" + tbPrice.Text + "' , '" + list[list.Count -1]+ "' , '" + tbType.Text + "' , '"+ tbIngredients.Text + "');";

                dbConnection.Open();

                MySqlCommand sqlCommandP = new MySqlCommand(sqlStatement1, dbConnection);
                var stp = sqlCommandP.ExecuteReader();
                dbConnection.Close();
                MessageBox.Show("You have successfully added a new product!");

                tbName.Clear();
                tbPrice.Clear();
                tbIngredients.Clear();
                tbQty.Clear();
                tbType.Clear();
            }
            else if(radioButton4.Checked)
            {
                dbConnection.Open();

                String sqlStatement = "INSERT INTO storageproducts(Quantity) Values ( '" + tbQty.Text + "');";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
                var reader = sqlCommand.ExecuteReader();

                dbConnection.Close();

                dbConnection.Open();

                String sqlStatementSt = "SELECT * FROM storageproducts;";

                MySqlCommand sqlCommandSt = new MySqlCommand(sqlStatementSt, dbConnection);
                var st = sqlCommandSt.ExecuteReader();
                var list = new List<string>();

                while (st.Read())
                {
                    var stId = st[0].ToString();
                    list.Add(stId);
                }

                dbConnection.Close();

                String sqlStatement1 = "Insert Into product(Name, Price, StorageProductId, Type, Ingredients) Values ('" +
                                       tbName.Text + "', '" + tbPrice.Text + "' , '" + list[list.Count - 1] + "' , '" + tbType.Text + "' , '" + String.Empty +"');";

                dbConnection.Open();

                MySqlCommand sqlCommandP = new MySqlCommand(sqlStatement1, dbConnection);
                var stp = sqlCommandP.ExecuteReader();
                dbConnection.Close();
                MessageBox.Show("You have successfully added a new product!");

                tbName.Clear();
                tbPrice.Clear();
                tbIngredients.Clear();
                tbQty.Clear();
                tbType.Clear();
                dbConnection.Open();
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tbIngredients.Enabled = false;
                Refresh();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tbIngredients.Enabled = true;
            Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbIngredients.Enabled = true;
            Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbIngredients.Enabled = true;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
