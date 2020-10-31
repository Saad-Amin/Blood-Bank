using System;
using System.IO;


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\tLogin id  ");
                Console.WriteLine("=================================");
                Console.Write("Enter id   :");
                string id = Console.ReadLine();
                Console.WriteLine("=================================");
                Console.Write("Enter password  :");
                string pass = Console.ReadLine();
                Console.WriteLine("=================================");
                string c = "hamza";
                string d = "mounis";
                string a = "123";
                string b = "321";
                if (id == c || id == d)
                {
                    if (pass == a || pass == b)
                    {
                        Console.WriteLine("  Login sucessfull");
                        Console.WriteLine("Enter a choice");
                        Console.WriteLine("\n\t\t\tWelcome to Blood Bank ");
                        while (true)
                        {
                            Console.WriteLine("\n\t\t\tMain Menu ");
                            Console.WriteLine("\n\n1 :INFORMATION ABOUT DONAR");
                            Console.WriteLine("2 : INFORMATION ABOUT RECIEVER");
                            Console.WriteLine("3 : AVAILABLE BLOOD GROUP ");
                            Console.WriteLine("4 : WANT TO TAKE JOB IN BLOOD BANK");
                            Console.WriteLine("5 : READING");
                            Console.WriteLine("6 : SEARCHING");
                            Console.WriteLine("7 : CLOSE APPLICATION");
                            Console.WriteLine("\n\nENTER YOUR CHOICE");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.Clear();
                                    using (FileStream fs = new FileStream("donar.txt", FileMode.Append, FileAccess.Write))
                                    {
                                        StreamWriter write = new StreamWriter(fs);
                                        write.WriteLine("\n\t\tInformation about donar");
                                        Console.WriteLine("how much time for donate blood 6 months yes press 1/no press 2");
                                        string time = (Console.ReadLine());
                                        string y = "1";
                                        if (time == y)
                                        {
                                            Console.WriteLine("enter donar age  :");
                                            int age = Convert.ToInt32(Console.ReadLine());
                                            if (age > 18)
                                            {
                                                Console.WriteLine("donar allow for donate blood");
                                                Console.Write("Enter Donar Name :");
                                                string na = Console.ReadLine();
                                                Console.Write("ENTER Donar Father name : ");
                                                string f_name = Console.ReadLine();
                                                Console.Write("Enter Donar City : ");
                                                string city = Console.ReadLine();
                                                Console.Write("enter NIC number  :");
                                                string nic = Console.ReadLine();
                                                Console.Write("Enter Donar Blood group  :");
                                                string bd = Console.ReadLine();
                                                Console.WriteLine("enter phone number  :");
                                                string ph = Console.ReadLine();
                                                Console.WriteLine("Type reason why you donate blood");
                                                string reason = Console.ReadLine();
                                                Console.Clear();
                                                write.Write(na + "       ");
                                                write.Write(f_name + "       ");
                                                write.Write(city + "         ");
                                                write.Write(nic + "       ");
                                                write.Write(bd + "       ");
                                                write.Write(age + "       ");
                                                write.Write(ph + "       ");
                                                write.Write(reason + "       ");
                                            }
                                            else write.WriteLine("sorry under age");
                                        }
                                        else write.WriteLine("sorry not allowd for donate blood ");
                                        write.Flush();
                                        write.Close();
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    using (FileStream fs = new FileStream("reciever.txt", FileMode.Append, FileAccess.Write))
                                    {
                                        StreamWriter write = new StreamWriter(fs);
                                        Console.WriteLine("\t\t\tTHANKS FOR COMING");
                                        Console.WriteLine("\n\t\tInformation about Reciever");
                                        Console.Write("Enter Reciever Name :");
                                        string naR = Console.ReadLine();
                                        Console.Write("\nENTER YOUR FATHER NAME : ");
                                        string f_nameR = Console.ReadLine();
                                        Console.Write("\nENTER YOUR CITY : ");
                                        string cityR = Console.ReadLine();
                                        Console.Write("enter Reciever NIC number  :");
                                        string nicR = Console.ReadLine();
                                        Console.Write("Enter  Blood group which blood group you recieve  :");
                                        string bdR = Console.ReadLine();
                                        Console.WriteLine("enter Reciever phone number  :");
                                        string phR = Console.ReadLine();
                                        Console.WriteLine("Type reason why you Recieve blood");
                                        string reasonR = Console.ReadLine();
                                        Console.WriteLine("Give the medical report why you recieve blood");
                                        string report = Console.ReadLine();
                                        Console.Clear();
                                        write.Write(naR + "         ");
                                        write.Write(f_nameR + "         ");
                                        write.Write(cityR + "           ");
                                        write.Write(nicR + "            ");
                                        write.Write(bdR + "         ");
                                        write.Write(phR + "         ");
                                        write.Write(reasonR + "     ");
                                        write.Write(report + "      ");
                                        write.WriteLine();
                                        write.Flush();
                                        write.Close();
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    using (StreamReader reader = File.OpenText("donar.txt"))
                                    {
                                        string data = "";
                                        while ((data = reader.ReadLine()) != null)
                                        {
                                            Console.WriteLine(data);
                                        }
                                        SearchingInFile();
                                    }
                                    break;
                                case 4:
                                    Console.Clear();
                                    using (FileStream fs = new FileStream("job.txt", FileMode.Append, FileAccess.Write))
                                    {
                                        StreamWriter write = new StreamWriter(fs);
                                        write.WriteLine("\n\t\t\tNow JOBS ARE NOT AVAILABLE");
                                        write.WriteLine("Give the CV and contact number Inshallah i will contact you");
                                        Console.WriteLine("enter name :");
                                        string jna = Console.ReadLine();
                                        Console.WriteLine("enter contact number     :");
                                        string contactj = Console.ReadLine();
                                        write.WriteLine(" Name :" + jna + "contact :" + contactj);
                                        write.WriteLine("\n\n\t\t\tCOMING SOON");
                                        write.Flush();
                                        write.Close();
                                    }
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("Enter file name");
                                    string Fname = Console.ReadLine();
                                    Fname = Fname + ".txt";
                                    string givendata = "";
                                    StreamReader reader1 = new StreamReader(Fname);
                                    while ((givendata = reader1.ReadLine()) != null)
                                    {
                                        Console.WriteLine(givendata);
                                    }
                                    Console.WriteLine("=================================================================");
                                    break;
                                case 6:
                                    Console.Clear();
                                    Console.WriteLine("Enter File name");
                                    string name = Console.ReadLine();
                                    name = name + ".txt";
                                    FileStream fs1 = new FileStream(name, FileMode.Open, FileAccess.Read);
                                    StreamReader sr = new StreamReader(fs1);
                                    Console.WriteLine("Enter name");
                                    string name1 = Console.ReadLine();
                                    string data1 = "";
                                    while ((data1 = sr.ReadLine()) != null)
                                    {
                                        if (data1.Contains(name1))
                                        { Console.WriteLine(data1 + "Found"); }
                                        data1 = sr.ReadLine();
                                    }
                                    Console.ReadLine();
                                    fs1.Close();
                                    Console.WriteLine("=================================================================");
                                    break;
                                case 7:
                                    Console.Clear();
                                    Console.WriteLine("\t\t\tGOOD BYE");
                                    Console.WriteLine("press enter to close program");
                                    System.Environment.Exit(1);
                                    break;
                                default:
                                    Console.WriteLine("INVALID CHOICE"); break;
                            }     
                            Console.WriteLine("press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("  password wrong");
                    }
                }
                else
                {
                    Console.WriteLine(" id wrong");
                }
                Console.WriteLine("press enter for continue");
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
        static void SearchingInFile()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tTHANKS FOR COMING");
            Console.WriteLine("\nAVAILAIBLE BLOOD GROUP : ");
            Console.WriteLine("1:  A+");
            Console.WriteLine("2:  A-");
            Console.WriteLine("3:  B+");
            Console.WriteLine("4:  B-");
            Console.WriteLine("5:  O+");
            Console.WriteLine("6:  O-");
            Console.WriteLine("7:  A1B+");
            Console.WriteLine("8:  A1B-");
            Console.WriteLine("9:  A2B+");
            Console.WriteLine("10:  A2B-");
            string fileName = "donar.txt";
            string[] completeRecord = File.ReadAllLines(fileName);
            Console.WriteLine("Enter blood group");
            string bgroup = Console.ReadLine();
            foreach (var record in completeRecord)
            {
                string[] bg = record.Split(' ');
                for (int i = 0; i < bg.Length; i++)
                {
                    if (bg[i] == bgroup)
                        Console.WriteLine(record);
                    else
                        continue;
                }
            }
        }
    }
}