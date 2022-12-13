using System.Data.SqlClient;

namespace SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            string[][] dat = db.ReadData(5462739224476670, 3652);
            foreach(string s in dat[0])
            {
                Console.WriteLine(s);
            }







            //var cs = @"Server=localhost\SQLEXPRESS;Database=ATMdb;Trusted_Connection=True;";


            //using var con = new SqlConnection(cs);
            //con.Open();

            //using var cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = @"DROP TABLE users";
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='users' and xtype='U')
            //                        CREATE TABLE users(
            //                           id int identity(1,1) NOT NULL PRIMARY KEY,
            //                           pin INT NOT NULL,
            //                           card BIGINT NOT NULL,
            //                           balance INT,
            //                           tn1 INT,
            //                           tn2 INT,
            //                           tn3 INT,
            //                           tn4 INT,
            //                           tn5 INT
            //                        )";
            //cmd.ExecuteNonQuery();
            ////var query = "INSERT INTO users(pin, card, balance) VALUES(@pin, @card, @balance)";
            ////using var com = new SqlCommand(query, con);


            ////com.Parameters.Add("@pin", System.Data.SqlDbType.Int).Value = 2145;
            ////com.Parameters.Add("@card", System.Data.SqlDbType.BigInt).Value = 5555555555555;
            ////com.Parameters.Add("@balance", System.Data.SqlDbType.Int).Value = 10000;
            ////com.Prepare();
            ////com.ExecuteNonQuery();

            //string sql = @"SELECT * FROM users
            //              WHERE pin = 1234 AND card = 224342223344";
            //using var cmd2 = new SqlCommand(sql, con);
            //using SqlDataReader rdr = cmd2.ExecuteReader();
            //while (rdr.Read())
            //{

            //    Console.WriteLine("{0} {1} {2} {3}", rdr.GetInt32(0), rdr.GetInt32(1),
            //            rdr.GetInt64(2), rdr.GetInt32(3));
            //}
            //if (rdr.Read() == true)
            //{
            //    Console.WriteLine('1');
            //}
        }
        static long[] CardDetails()
        {
            Random rnd = new Random();
            long pin = rnd.Next(1000, 9999);
            long card = rnd.NextInt64(1000000000000000, 9999999999999999);
            long balance = 0;
            if (rnd.Next(0, 2) == 0)
            {
                balance = rnd.NextInt64(1000, 9999999);
            }
            long[] results = new long[3] { pin, card, balance };
            return results;
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
                                       tn1 VARCHAR(255),
                                       tn2 VARCHAR(255),
                                       tn3 VARCHAR(255),
                                       tn4 VARCHAR(255),
                                       tn5 VARCHAR(255)
                                    )";
            cmd.ExecuteNonQuery();
        }
        public void InsertInitData(long pin, long card, long balance)
        {
            
            var query = "INSERT INTO users(pin, card, balance, tn1, tn2, tn3, tn4, tn5) VALUES(@pin, @card, @balance, '-' , '-', '-', '-', '-')";
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

                Console.WriteLine(rdr.GetInt32(0));
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
        public void Update(int id, long amount)
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
        public void LastTransactions(List<string> list, int id, long amount)
        {
            string ld = "";
            var query = "";
           
            for (int i = 0; i <= list.Count; i++)
            {
                if (list.Count == i)
                {
                    ld = $"tn{i + 1}";
                    if(ld == "tn6")
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

        public void DropTables()
        {
            using var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"DROP TABLE users";
            cmd.ExecuteNonQuery();
        }
    }
}