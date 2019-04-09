using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationAppLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User)); 

            BinaryFormatter serializer = new BinaryFormatter();
            using(var stream = File.Open(@"C:/1/1.bin", FileMode.Truncate))
            {
                User user = new User
                {
                    Id = 1,
                    Login = "admin",
                    Password = "123"
                };
                serializer.Serialize(stream, user);
            }

            using(var stream = File.Open(@"C:/1/1.bin", FileMode.Open))
            {
                User user = serializer.Deserialize(stream) as User;
            }

            var user1 = new User
            {
                Id = 1,
                Login = "admin",
                Password = "123"
            };
            string data = JsonConvert.SerializeObject(user1);
            User result = JsonConvert.DeserializeObject<User>(data);

        }
    }
}
