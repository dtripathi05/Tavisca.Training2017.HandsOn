using System;
using System.Collections.Generic;
using System.IO;


namespace Directory_Codejam
{
    class DirectoryLog
    {
        static InputData input;
        static StudentInfo student_folder;
        static string path;
        static StreamWriter logWriter;
        static void Main(string[] args)
        {
            CreateIntial();

            Console.WriteLine("\nEnter Key for Operation:\nFor Add Press<1>\nList Press<2>\nUpdate Press<3>\nView Press<4>\n");
            int opt = 0;
            while (true)
            {
                int.TryParse(Console.ReadLine(), out opt);
                if (opt == -1)
                    break;
                switch (opt)
                {
                    case 1:
                        AddRecord();
                        break;
                    case 2:
                         DisplayList();                        
                        
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:

                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nEnter Key for Operation:\nFor Add Press<1>\nList Press<2>\nUpdate Press<3>\nView Press<4>\n");
            }
        }

        public static void Update()
        {
            Console.WriteLine("Enter GUID");
            string str = Console.ReadLine();
            File.Delete("D:\\Students_Record\\" + str+".txt");
            AddRecord();
        }
        public static void CreateIntial()
        {
            input = new InputData();
            student_folder = input.GetStudentInfoContext();
            DirectoryInfo directory = new DirectoryInfo(@"d:\Students_Record");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exists");
                }
                else
                {
                    directory.Create();
                    Console.WriteLine("Directory created successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("processing failed", e.ToString());
            }

            path = @"d:\Students_Record\" + student_folder.Id() + ".txt";
            if (!File.Exists(path))
            {
                using (File.Create(path))
                {

                }
            }
        }
        public static void AddRecord()
        {
            input.FullName();
            input.Address();
            input.DOB();
            input.MentorName();
            input.Email();
            input.PhoneNumber();
            input.EmergencyNumber();
            File.WriteAllText(path, Serilizable.serializeobject(student_folder));
            Log.LogEntry();
        }

        public static void DisplayList()
        {
            if (System.IO.Directory.Exists("D:\\Students_Record"))
            {
                string[] files = System.IO.Directory.GetFiles("D:\\Students_Record", @"*.txt", SearchOption.TopDirectoryOnly);
                foreach (string f in files)
                {
                    using (StreamReader sr = new StreamReader(f))
                    {
                        string s = sr.ReadLine();
                        Console.WriteLine(s);
                    }
                }
            }

        }

    }
    
}