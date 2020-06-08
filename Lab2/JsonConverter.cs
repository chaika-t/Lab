using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab2
{
    public class JsonConverter
    {
        public void ToJson(Person person, string fileName)
        {
            string json = JsonConvert.SerializeObject(person);
            File.WriteAllText(fileName, json);
        }

        public Person FromJson(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<Person>(json);
        }
    }
}
