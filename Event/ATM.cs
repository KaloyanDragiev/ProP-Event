namespace Event
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.IO;

    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        Form opener;
        private int EmployeeId;
        public ATM(Form parentForm, int EmployeeId)
        {
            InitializeComponent();
            opener = parentForm;
            this.EmployeeId = EmployeeId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    status.Text = "Successfully loaded file!";
                    
                    string s = sr.ReadLine();
                    while (s != null)
                    {
                        if (s.Split().Count() == 2)
                        {
                            listBox1.Items.Add($"CustomerTicketNumber: {s.Split()[0]}  Added: {s.Split()[1]}");
                        }
                        s = sr.ReadLine();
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Something went wrong, IOException was thrown!");
                    status.Text = "Unsuccessfully loaded file!";
                    status.BackColor = Color.Red;
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Nothing saved, since you pressed the CANCEL-button!");
                status.Text = "Unsuccessfully loaded file!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1(this, EmployeeId);
            fm1.Show();
            this.Hide();
        }
    }
}
