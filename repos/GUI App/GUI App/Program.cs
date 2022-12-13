//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using ExcelTest;




//namespace ConsoleApp3
//{

//    class Program
//    {
//        static void Main121(string[] args)
//        {

//            bool running = false;
//            bool setup = true;
//            bool signup = false;

//            ExcelWrite st = new ExcelWrite();


//            List<People> P = new List<People>();

//            while (setup)  // This loops creates a new object in a list of objects based on user-inputted parameters
//            {
//                Console.WriteLine("\"Sign up\" if you're a new user or \"Sign in\" if you're an existing user");
//                string sinput;
//                sinput = Console.ReadLine();
//                if (sinput == "Sign up")
//                {
//                    setup = false;
//                    signup = true;
//                }
//                else if (sinput == "Sign in")
//                {
//                    Console.WriteLine("Input your username1");
//                    string u = Console.ReadLine();
//                    Console.WriteLine("Input your password1");
//                    string p = Console.ReadLine();
//                    List<string> li = st.ReadFromSheet(u, p);
//                    if (li.Count > 0)
//                    {
//                        People user = new(li[2], Convert.ToInt32(li[3]), li[0], li[1], Convert.ToInt32(li[4]));
//                        P.Add(user);
//                        setup = false;
//                        running = true;
//                    }
//                    else if (li.Count <= 0)
//                    {
//                        Console.WriteLine("Wrong username/password");
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Unrecognized command.");
//                }
//            }
//            while (signup)
//                {
//                    Console.WriteLine("Input your username");
//                    string username = Console.ReadLine();

//                    Console.WriteLine("Input your password");
//                    string password = Console.ReadLine();

//                    Console.WriteLine("Input your full name");
//                    string name = Console.ReadLine();

//                    Console.WriteLine("Input your age");
//                    int age;
//                    string ag = Console.ReadLine();
//                    Int32.TryParse(ag, out age);

//                    st.WriteToSheet(username, password, name, age);
//                    List<string> li = st.ReadFromSheet(username, password);
//                    People user = new(li[2], Convert.ToInt32(li[3]), li[0], li[1], Convert.ToInt32(li[4]));
//                    P.Add(user);

//                    signup = false;
//                    running = true;
//                } 

//            while (running)  // The main loop of the program
//            {
//                Console.WriteLine("Input command(\"Help\" for command list)" );
//                switch (Console.ReadLine())
//                {
//                    case "Help":
//                        Console.WriteLine("Help, Access Data, Quit");
//                        break;
//                    case "Access Data":
//                        bool s = true;
//                            while (s) // This loop gives access to data submenus
//                            {
//                                Console.WriteLine("Type \"View Data\",  \"Edit Data\" or \"Back\"");
//                                bool dataed = true;
//                                    switch (Console.ReadLine())
//                                    {
//                                        case "View Data":
//                                            P[0].GetInfo();
//                                            break;
//                                        case "Edit Data":
//                                        while (dataed) // This loop allows users to edit data
//                                        {
//                                            Console.WriteLine("Type (\"Name\", \"Age\", \"Username\", \"Password\") to edit. Or type \"Back\".");
//                                            switch (Console.ReadLine())
//                                            {
//                                                case "Name":
//                                                    Console.WriteLine("Input your new name");
//                                                    string nm = Console.ReadLine();
//                                                    st.EditData(nm, P[0].Age, P[0].ID, P[0].Username, P[0].Password);
//                                                    P[0].Name = nm;
//                                                    Console.WriteLine("Name changed successfully");
//                                                    break;
//                                                case "Age":
//                                                    Console.WriteLine("Input your new age");
//                                                    int ag;
//                                                    Int32.TryParse(Console.ReadLine(), out ag);
//                                                    st.EditData(ag, P[0].Password, P[0].Name, P[0].Username, P[0].ID);
//                                                    P[0].Age = ag;  
//                                                    Console.WriteLine("Age changed successfully");
//                                                    break;
//                                                case "Username":
//                                                    Console.WriteLine("Input your new username");
//                                                    string un = Console.ReadLine();
//                                                    st.EditData(un, P[0].Password, P[0].Name, P[0].Age, P[0].ID);
//                                                    P[0].Username = un;
//                                                    Console.WriteLine("Username changed successfully");
//                                                    break;
//                                                case "Password":
//                                                    Console.WriteLine("Input your old password");
//                                                    string opw = Console.ReadLine();
//                                                    if (opw == P[0].Password)
//                                                    {
//                                                        Console.WriteLine("Input your new password");
//                                                        string npw = Console.ReadLine();
//                                                        st.EditData(npw, P[0].Age, P[0].Name, P[0].Username, P[0].ID);
//                                                        P[0].Password = npw;
//                                                        Console.WriteLine("Password changed successfully");
//                                                    }
//                                                    else
//                                                    {
//                                                        Console.WriteLine("Wrong password");
//                                                    }
//                                                    break;
//                                                case "Back":
//                                                    dataed = false;
//                                                    break;
//                                                default:
//                                                Console.WriteLine("Unrecognized command.");
//                                                break;
//                                            }
//                                        }
//                                            break;
//                                        case "Back":
//                                            s = false;
//                                            break;
//                                        default:
//                                            Console.WriteLine("Unrecognized command.");
//                                            break;
//                            }
//                                }
                        
//                        break;
//                    case "Quit":
//                        running = false;
//                        break;
//                    default:
//                        Console.WriteLine("Unrecognized command.");
//                        break;
//                }
//            } 
//        }
//    }
//    class People  // Main class for the users
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public string Username { get; set; }
//        public string Password { get; set; }
//        public string Fname { get; set; }
//        public string Lname { get; set; }
//        public int ID { get; set; }
//        public People(string name, int age, string username, string password, int id)  // Constructor
//        {
//            Name = name;
//            Age = age;
//            Username = username;
//            Password = password;
//            string[] arr = Name.Split(' ');
//            Fname = arr[0];
//            Lname = arr[1];
//            ID = id;
//        }
//        public void GetInfo() 
//        {
//            Console.WriteLine("Name is " + Name);
//            Console.WriteLine("Age is " + Age);
//        }
//        public void EditInfo(string name, int age, string username, string password)
//        {
//            Name = name;
//            Age = age;
//            Username = username;
//            Password = password;
//            string[] arr = Name.Split(' ');
//            Fname = arr[0];
//            Lname = arr[1];
//        }
        
//    }
//}
//      // TODO:
//      // Add a method to edit data in the excel sheet
//      // Store passwords encrypted
//      // Look into adding GUI