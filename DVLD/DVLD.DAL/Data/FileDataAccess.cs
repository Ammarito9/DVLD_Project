using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public class FileDataAccess
    {
        public static List<string> ReadFromFile(string path)
        {
            try
            {
                var sr = new StreamReader(path);

                List<string> result = new List<string>();
                string? line;

                while ((line = sr.ReadLine()) != null)
                    result.Add(line);


                sr.Close();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Error occurred while writing to the file", e);
            }
        }
        public static void WriteToFile(string path, string txt, bool IsAppend = false)
        {   
            try
            {
                StreamWriter sw = new StreamWriter(path, append:IsAppend);
                sw.WriteLine(txt);
                sw.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error occurred while writing to the file", e);
            }
        }

    }
}
