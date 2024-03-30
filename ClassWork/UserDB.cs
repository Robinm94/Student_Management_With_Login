using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class UserDB
    {
        private const string PATH = @"../../users.txt";
        private static readonly string[] DELIMITER = { "<::>" };

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using(StreamReader textIn = new StreamReader(new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                while (textIn.Peek() != -1)
                {
                    string line = textIn.ReadLine() ?? "";
                    string[] parts = line.Split(DELIMITER, StringSplitOptions.RemoveEmptyEntries);
                    User user = new User
                    {
                        Username = parts[0],
                        Password = parts[1]
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public static void SaveUsers(List<User> users)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(PATH, FileMode.Create, FileAccess.Write)))
            {
                foreach (User user in users)
                {
                    textOut.WriteLine(user.Username + DELIMITER[0] + user.Password);
                }
            }
        }
    }
}
