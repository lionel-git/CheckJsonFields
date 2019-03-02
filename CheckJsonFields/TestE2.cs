using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CheckJsonFields
{
    public class TestE2
    {
        public void TestDoubleException()
        {
            try
            {
                File.ReadAllText(@"c:\tmp\t1.txt");
            }
            catch (Exception e1)
            {
                try
                {
                    File.ReadAllText(@"c:\tmp\t2.txt");
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e1.Message);
                    Console.WriteLine(e2.Message);
                }
            }
        }
    }
}
