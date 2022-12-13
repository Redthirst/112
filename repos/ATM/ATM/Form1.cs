namespace ATM
{
    public partial class Form1 : Form
    {
        public User user;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        //private void SubmitBtn_Click(object sender, EventArgs e)
        //{
        //    int pin;
        //    long card;
        //    long balance;

        //    Int32.TryParse(PINBox.Text, out pin);
        //    Int64.TryParse(CardBox.Text, out card);
        //    Int64.TryParse(BalanceBox.Text, out balance);

        //    User mt = new User(pin, card, balance);
        //}

        private void EnterButton_Click(object sender, EventArgs e)
        {
            PinPanel.Show();
        }

       

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            WDInput.Show();
            WDOK.Show();
            WD20.Show();
            WD50.Show();
            WD100.Show();
        }

        private void WDOK_Click(object sender, EventArgs e)
        {
            user.Withdraw((long)WDInput.Value);
            BalanceLbl.Text = "Balance: " + user.Balance;
            WDInput.Hide();
            WDOK.Hide();
            WD20.Hide();
            WD50.Hide();
            WD100.Hide();
        }

        private void WD20_Click(object sender, EventArgs e)
        {
            user.Withdraw(20);
            BalanceLbl.Text = "Balance: " + user.Balance;
            WDInput.Hide();
            WDOK.Hide();
            WD20.Hide();
            WD50.Hide();
            WD100.Hide();
        }

        private void WD50_Click(object sender, EventArgs e)
        {
            user.Withdraw(50);
            BalanceLbl.Text = "Balance: " + user.Balance;
            WDInput.Hide();
            WDOK.Hide();
            WD20.Hide();
            WD50.Hide();
            WD100.Hide();
        }

        private void WD100_Click(object sender, EventArgs e)
        {
            user.Withdraw(100);
            BalanceLbl.Text = "Balance: " + user.Balance;
            WDInput.Hide();
            WDOK.Hide();
            WD20.Hide();
            WD50.Hide();
            WD100.Hide();
        }

        private void DPBtn_Click(object sender, EventArgs e)
        {
            DPBox.Show();
            DPOK.Show();
        }

        private void DPOK_Click(object sender, EventArgs e)
        {
            user.Deposit((long)DPBox.Value);
            BalanceLbl.Text = "Balance: " + user.Balance;
            DPBox.Hide();
            DPOK.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
        }

        private void LogInBtn_Click_1(object sender, EventArgs e)
        {
            long card;
            int pin;

            Int64.TryParse(LoginCard.Text, out card);
            Int32.TryParse(InpPin.Text, out pin);

            user = new User(pin, card);
            DBL.Text = user.Debug;

            if (user.Exists == false)
            {
                WrongPin.Show();
            }
            else if (user.Exists == true)
            {
                PinPanel.Hide();
                MainPanel.Show();
                BalanceLbl.Text = "Balance: "+ user.Balance;
                Label[] tn = new Label[5] { TN1, TN2, TN3, TN4, TN5 };
                for (int i = 0; i < tn.Length; i++)
                {
                    tn[i].Text = user.LTransactions[i];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.Debug);
        }
    }
}