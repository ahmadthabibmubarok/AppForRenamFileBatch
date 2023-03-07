using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppForCheckDbLink
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Checking Db Link Hard Code File Started");
                Console.WriteLine("Please Input Folder Path !");
                string FolderPath = Console.ReadLine();
                Console.WriteLine("Please Input Parameter DbLink, default by _DB");
                string DbLinkParam = Console.ReadLine();
               

                DirectoryInfo d = new DirectoryInfo(FolderPath);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {

                    string[] lines = System.IO.File.ReadAllLines(@""+f.DirectoryName+"\\"+f.Name);
                    for (int i = 0; i < lines.Count(); i++)
                    {
                        if (lines[i].ToUpper().Contains("_DB") || lines[i].ToUpper().Contains("DbLinkParam"))
                        {
                            int row = i + 1;
                            Console.WriteLine("Dblink On File (" + f.Name + ") With Line (" + row + ") :"  + lines[i]);
                        }
                       
                    }
                    
                }

                Console.WriteLine("Check Dblink Success");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERR | Error Checking File Error :" + e.Message.ToString());
                Console.ReadKey();
            }
        }
    }
}
