using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public static class FileHandler
    {
        public static bool Save(object objectToSave, string filename)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectToSave, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(filename, json);
            return true;
        }
        public static T Open<T>(string filename)
        {
            string data = System.IO.File.ReadAllText(filename);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(data);
        }
    }
}
