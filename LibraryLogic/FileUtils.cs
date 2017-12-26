using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryLogic
{
    public class FileUtils
    {
        public static string[] ReadStringArrFromFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void WriteStringArrToFile(string path, string[] arr)
        {
            File.WriteAllLines(path, arr);
        }
        
        public static string ReadStringFromFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteStringToFile(string path, string str)
        {
            File.WriteAllText(path, str);
        }
    }
}
