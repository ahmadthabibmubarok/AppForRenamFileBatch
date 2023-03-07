using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRenameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add from main");
                Console.WriteLine("Rename File Started");
                Console.WriteLine("Please Input Folder Path !");
                string FolderPath = Console.ReadLine();
                //DirectoryInfo d = new DirectoryInfo(@"D:\Project Fujitsu\COMPARE TABLE AND SP FROM DEPLOYMENT PROCEDURE WITH TRIAL LATEST\TRIAL SP\PEDS_INV_DB_TR_SAPHANA");
                DirectoryInfo d = new DirectoryInfo(FolderPath);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    
                    File.Move(f.FullName, f.FullName.Replace("dbo.", "").Replace(".StoredProcedure", "").Replace("create_", "").Replace("alter_", "").Replace(".Table", "").Replace(".View", ""));
                    //File.Move(f.FullName, f.FullName.Replace("create_", "").Replace("alter_", ""));
                    //File.Move(f.FullName, f.FullName.Replace("dbo.", "").Replace(".Table", ""));
                }
                Console.WriteLine("Rename Success");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Rename Error :"+e.Message.ToString());
                Console.ReadKey();
            }
            
        }
    }
}
