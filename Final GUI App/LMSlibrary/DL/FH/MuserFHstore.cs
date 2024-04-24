using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DL.FH
{
     public class MuserFHstore : IMuser
     {
        private static List<Muser>userList = new List<Muser>();
        public string DataFile;

        public MuserFHstore(string DataFile)
        {
            this.DataFile = DataFile;
            ReadUserFile(DataFile);
        }

        public void SignUp(Muser user)
        {
            if(File.Exists(DataFile))
            {
                StreamWriter file = new StreamWriter(DataFile , true);
                file.WriteLine(user.GetUsername() + "," + user.GetPassword() + "," + user.GetRole());
                file.Flush();
                file.Close();
            }
            else
            {
                Console.Write("File does not exist");
            }
          
        }

        public Muser SignIn(Muser user)
        {
            foreach(Muser userstored in userList)
            {
                if(user.GetUsername() == userstored.GetUsername() && user.GetPassword() == userstored.GetPassword())
                {
                    return userstored;
                }
            }
            return null;
        }

        public List<Muser> GetMuserList()
        {
            return userList;
        }

        public string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        public void ReadUserFile(string path)
        {
            if(File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                string record;
                while((record = reader.ReadLine()) != null)
                {
                    string username = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role     = parseData(record, 3);
                    Muser user = new Muser(username, password, role);
                    userList.Add(user);
                }
                reader.Close();
            }
            else
            {
                Console.Write("File does not exist");
            }
        }
      

    }
}
