using System.Data.SqlClient;

namespace ATM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class User
    {
        public int UserID { get; set; }
        public long Card { get; set; }
        public int PIN { get; set; }
        public long Balance { get; set; }
        public long PhoneNumber { get; set; }
        public bool Exists { get; set; }
        public string Debug { get; set; } = "";
        public List<string> LTransactions { get; set; } = new List<string>();
        public Database db = new Database();
        public User(int pin, long card, long balance) // Constructor for the initial user setup
        {
            PIN = pin;
            Balance = balance;
            Card = card;

            db.CreateTable();
            db.InsertInitData(PIN, Card, Balance);
 
        }
        public User(int pin, long card) // Constructor for user login
        {
            string[][] dat = db.ReadData(card, pin);
            Debug = dat[0][3].ToString();
            if (dat[0][1] == "No user found")
            {
                Exists = false;
            }
            else
            {
                Exists = true;
                int id = 0;
                Int32.TryParse(dat[0][0], out id);
                UserID = id;

                long crd = 0;
                Int64.TryParse(dat[0][1], out crd);
                Card = crd;

                int pn = 0;
                Int32.TryParse(dat[0][2], out pn);
                PIN = pn;

                long balance = 0;
                Int64.TryParse(dat[0][3], out balance);
                Balance = balance;

                LTransactions = dat[1].ToList();
            }
            
            
        }
        public long ShowBalance()
        {
            return Balance;
        }
        public void Withdraw(long amount)
        {
            if(amount <= 1000)
            {
                Balance -= amount;
                if (LTransactions.Count == 5)
                {
                    LTransactions.RemoveAt(0);
                    LTransactions.Insert(0, $"Withdrawal: {amount}");
                }
                db.LastTransactions(LTransactions, UserID, $"Withdrawal: {amount}");
                db.Update(UserID, Balance);
            }
            else
            {
                // Message that amount is too big
            }
        }
            
        public void Deposit(long amount)
        {
            Balance += amount;
            if (LTransactions.Count == 5)
            {
                LTransactions.RemoveAt(0);
                LTransactions.Insert(0, $"Deposit: {amount}");
            }
            db.LastTransactions(LTransactions, UserID, $"Deposit: {amount}");
            db.Update(UserID, Balance);
        }
        public void ChangePin(int newpin)
        {
            PIN = newpin;
            db.Update(UserID, newpin);
        }
        public void AddNumber(long number)
        {
            PhoneNumber = number;
            db.AddPhone(UserID, number);
        }
    }
    public class Database
    {
        private readonly string cs;
        private readonly SqlConnection con;

        public Database()
        {
            cs = @"Server=localhost\SQLEXPRESS;Database=ATMdb;Trusted_Connection=True;";

            con = new SqlConnection(cs);
            con.Open();

        }

        public void CreateTable()
        {

            using var cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='users' and xtype='U')
                                    CREATE TABLE users(
                                       ID int identity(1,1) NOT NULL PRIMARY KEY,
                                       PIN INT NOT NULL,
                                       Card BIGINT NOT NULL,
                                       Balance BIGINT,
                                       PhoneNum BIGINT,
                                       tn1 VARCHAR(255),
                                       tn2 VARCHAR(255),
                                       tn3 VARCHAR(255),
                                       tn4 VARCHAR(255),
                                       tn5 VARCHAR(255)
                                    )";
            cmd.ExecuteNonQuery();
        }
        public void InsertInitData(int pin, long card, long balance) // Adds basic data to the table
        {

            var query = "INSERT INTO users(pin, card, balance) VALUES(@pin, @card, @balance)";
            using var cmd = new SqlCommand(query, con);


            cmd.Parameters.Add("@pin", System.Data.SqlDbType.Int).Value = pin;
            cmd.Parameters.Add("@card", System.Data.SqlDbType.BigInt).Value = card;
            cmd.Parameters.Add("@balance", System.Data.SqlDbType.BigInt).Value = balance;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        public string[][] ReadData(long card, int pin)
        {
            string[] results = new string[4];
            string[] tn = new string[5];
            string sql = @$"SELECT * FROM users
                          WHERE PIN = {pin} AND Card = {card}";
            using var cmd2 = new SqlCommand(sql, con);
            using SqlDataReader rdr = cmd2.ExecuteReader();
            results[1] = "No user found";
            while (rdr.Read())
            {
                results[0] = rdr.GetInt32(0).ToString();
                results[1] = card.ToString();
                results[2] = pin.ToString();
                results[3] = rdr.GetInt64(3).ToString();
                for (int i = 0; i < 5; i++)
                {
                    tn[i] = rdr.GetString(i + 4);
                }

            }
            string[][] output = new string[2][] { results, tn };
            return output;
        }
        public void Update(int id, long amount) // Updates balance column
        {
            var query = $@"UPDATE users
                           SET Balance = @amount
                            WHERE ID = @id";
            using var cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@amount", System.Data.SqlDbType.BigInt).Value = amount;
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
        public void Update(int id, int pin) // Updates pin column
        {
            var query = $@"UPDATE users
                           SET PIN = @pin
                            WHERE ID = @id";
            using var cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@pin", System.Data.SqlDbType.Int).Value = pin;
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
        public void AddPhone(int id, long number)
        {
            var query = $@"UPDATE users
                           SET PhoneNum = @number
                            WHERE ID = @id";
            using var cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@number", System.Data.SqlDbType.BigInt).Value = number;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        public void LastTransactions(List<string> list, int id, string amount) // Adds last transactions to appropriate columns
        {
            string ld = "";
            var query = "";

            for (int i = 0; i <= list.Count; i++)
            {
                if (list.Count == i)
                {
                    ld = $"tn{i + 1}";
                    if (ld == "tn6")
                    {
                        ld = "tn1";
                    }
                    break;
                }
            }
            switch (ld)
            {
                case "tn1":
                    query = @$"UPDATE users
                            SET tn1 = @amount
                            WHERE ID = @id";
                    break;
                case "tn2":
                    query = @$"UPDATE users
                            SET tn2 = @amount
                            WHERE ID = @id";
                    break;
                case "tn3":
                    query = @$"UPDATE users
                            SET tn3 = @amount
                            WHERE ID = @id";
                    break;
                case "tn4":
                    query = @$"UPDATE users
                            SET tn4 = @amount
                            WHERE ID = @id";
                    break;
                case "tn5":
                    query = @$"UPDATE users
                            SET tn5 = @amount
                            WHERE ID = @id";
                    break;
            }
            Console.WriteLine(ld);
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@amount", System.Data.SqlDbType.VarChar, 255).Value = amount;

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
// TODO: 
   // Limit transactions to 1k, 10 transactions per day
   // Ability to change PIN and register a phone number
   // Detailed bank statement
   // Fast withdrawal of small amounts(20/50/100)
   // UI