using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;



namespace SQLiteSamples1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckARGS(args);
        }

        private static void CheckARGS(string[] args)
        {
            foreach (var item in args)
            {
                if (item.Contains("+db/"))
                {
                    CreateDB();
                }
            }
        }

        private static void CreateDB()
        {
            if (!System.IO.File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
                Console.WriteLine($"file was create {DateTime.Now}{Environment.NewLine}Please Press any key!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("file already exists!");
                Console.ReadKey();
            }
        }


    }
}
