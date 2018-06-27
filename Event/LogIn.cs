namespace Event
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Employee(int Id, string Name, string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
        }
    }

    public partial class LogIn : Form
    {
        MySqlConnection dbConnection;

        public LogIn()
        {
            InitializeComponent();
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);
            label2.Text = "EmpName";
            textBox2.PasswordChar = '*';
            this.Icon = new Icon(".../ico.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlStatement = "SELECT * FROM employee;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<Employee>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var id = articlesReader[0].ToString();
                var name = articlesReader[1].ToString();
                var password = articlesReader[2].ToString();
                Employee temp = new Employee(Convert.ToInt32(id), name, password);

                list.Add(temp);
            }
            bool inIt = false;
            foreach (var item in list)
            {
                if (item.Name == textBox1.Text && item.Password == textBox2.Text)
                {
                    inIt = true;
                    MessageBox.Show("Successfully Log in!");

                    Form1 frm = new Form1(this, item.Id);
                    frm.Show();
                }
            }
            if (!inIt)
            {
                MessageBox.Show("Unsuccessfully Log in!");
            }
            this.Hide();
            dbConnection.Close();
        }
    }
}
