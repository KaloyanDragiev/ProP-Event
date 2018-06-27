namespace Event
{
    using System;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form opener;
        int EmployeeId;
        private MySqlConnection dbConnection;

        public Form1(Form parentForm, int Employeeid)
        {
            InitializeComponent();
            opener = parentForm;
            EmployeeId = Employeeid;

            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            String sqlStatement = "SELECT * FROM employee;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader materialsReader = sqlCommand.ExecuteReader();

            while (materialsReader.Read())
            {
                var employeeId = materialsReader[0].ToString();
                var employeeName = materialsReader[1].ToString();

                if (Convert.ToInt32(employeeId) == Employeeid)
                {
                    this.label2.Text += employeeName + "!";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant frm = new Restaurant(this, EmployeeId);
            frm.Show();
            frm.Show();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Materials frm = new Materials(this, EmployeeId);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ATM frm = new ATM(this, EmployeeId);
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ATMStatic frm = new ATMStatic(this, EmployeeId);
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistic frm = new Statistic(this, EmployeeId);
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VisitorCheckInOut frm = new VisitorCheckInOut(this, EmployeeId);
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn lg = new LogIn();
            lg.Show();
        }
    }
}
