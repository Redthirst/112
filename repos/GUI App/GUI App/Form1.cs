using ExcelTest;
using System.Collections.Generic;

namespace GUI_App
{
    public partial class Form1 : Form
    {
        ExcelWrite st = new ExcelWrite();
        List<People> P = new();
        int en;
        
        public Form1()
        {
            InitializeComponent();
            SgnUpPanel.Hide();
            DataPanel.Hide();
            EditPanel.Hide();
            EditPWPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SgnInPanel.Show();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            List<string> li = st.ReadFromSheet(Usnm.Text, Pswd.Text);
            if(li.Count > 0)
            {
                People user = new(li[2], Convert.ToInt32(li[3]), li[0], li[1], Convert.ToInt32(li[4]));
                P.Add(user);
                SgnInPanel.Hide();
                NameLabel.Text = user.Name;
                UsernameLabel.Text = user.Username;
                AgeLabel.Text = Convert.ToString(user.Age);
                DataPanel.Show();
            }
            else if(li.Count == 0)
            {
                WrongData.Text = "Wrong username/pasword";
            }
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            SgnInPanel.Hide();
        }

        private void BckButton2_Click(object sender, EventArgs e)
        {
            SgnUpPanel.Hide();
        }

        private void SgnUpButton_Click(object sender, EventArgs e)
        {
            int age;
            Int32.TryParse(SgUAG.Text, out age);
            st.WriteToSheet(SgUUN.Text, SgUPW.Text, SgUNM.Text, age);
            List<string> li = st.ReadFromSheet(SgUUN.Text, SgUPW.Text);
            People user = new(li[2], Convert.ToInt32(li[3]), li[0], li[1], Convert.ToInt32(li[4]));
            P.Add(user);
            SgnUpPanel.Hide();
            RefreshData();
            DataPanel.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SgnUpPanel.Show();    
        }

        private void EditName_Click(object sender, EventArgs e)
        {
            EditPanel.Show();
            NewDatLabel.Text = "Input your new name";
            en = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditPanel.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (en == 1)
            {
                st.EditData(NewInfo.Text, P[0].Age, P[0].ID, P[0].Username, P[0].Password);
                P[0].Name = NewInfo.Text;
                RefreshData();
                EditPanel.Hide();
                NewInfo.Text = null;
                MessageBox.Show("Name changed successfully");
            }
            else if (en == 2)
            {
                int ag;
                Int32.TryParse(NewInfo.Text, out ag);
                st.EditData(ag, P[0].Password, P[0].Name, P[0].Username, P[0].ID);
                P[0].Age = ag;
                RefreshData();
                EditPanel.Hide();
                NewInfo.Text = null;
                MessageBox.Show("Age changed successfully");
            }
            else if(en == 3)
            {
                st.EditData(NewInfo.Text, P[0].Password, P[0].Name, P[0].Age, P[0].ID);
                P[0].Username = NewInfo.Text;
                RefreshData();
                EditPanel.Hide();
                NewInfo.Text = null;
                MessageBox.Show("Username changed successfully");
            }
        }

        private void EditAge_Click(object sender, EventArgs e)
        {
            EditPanel.Show();
            NewDatLabel.Text = "Input your new age";
            en = 2;
        }

        private void EditUN_Click(object sender, EventArgs e)
        {
            EditPanel.Show();
            NewDatLabel.Text = "Input your new username";
            en = 3;
        }

        private void CancelPW_Click(object sender, EventArgs e)
        {
            EditPWPanel.Hide();
        }

        private void EditPW_Click(object sender, EventArgs e)
        {
            EditPWPanel.Show();
        }

        private void EditPWBtn_Click(object sender, EventArgs e)
        {
            if(OldPWInput.Text == P[0].Password)
            {
                st.EditData(NewPWInput.Text, P[0].Age, P[0].Name, P[0].Username, P[0].ID);
                P[0].Password = NewPWInput.Text;
                EditPWPanel.Hide();
                OldPWInput.Text = null;
                NewPWInput.Text = null;
                MessageBox.Show("Password changed successfully");
                PWLabel.Text = "Input your old password";

            }
            else
            {
                PWLabel.Text = "Wrong password";
            }
        }
        private void RefreshData()
        {
            NameLabel.Text = P[0].Name;
            UsernameLabel.Text = P[0].Username;
            AgeLabel.Text = Convert.ToString(P[0].Age);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    class People  // Main class for the users
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ID { get; set; }
        public People(string name, int age, string username, string password, int id)  // Constructor
        {
            Name = name;
            Age = age;
            Username = username;
            Password = password;
            string[] arr = Name.Split(' ');
            Fname = arr[0];
            Lname = arr[1];
            ID = id;
        }
        public void GetInfo()
        {
            Console.WriteLine("Name is " + Name);
            Console.WriteLine("Age is " + Age);
        }
        public void EditInfo(string name, int age, string username, string password)
        {
            Name = name;
            Age = age;
            Username = username;
            Password = password;
            string[] arr = Name.Split(' ');
            Fname = arr[0];
            Lname = arr[1];
        }

    }
}