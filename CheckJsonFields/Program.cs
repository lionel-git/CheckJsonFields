using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckJsonFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string jsonFile = @"c:\tmp\myData.json";

            try
            {
                var myData = new MyData
                {
                    Name = "Bad Boys",
                    Year = 1995
                };

                // serialize JSON to a string and then write string to a file
                //File.WriteAllText(jsonFile, JsonConvert.SerializeObject(myData));

                string jsonContent = File.ReadAllText(jsonFile);
                var result = JsonConvert.DeserializeObject<MyData>(jsonContent);
                Console.WriteLine(JsonConvert.SerializeObject(result));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("========================");
                Console.WriteLine(e.Message);
            }
        }
    }
}
