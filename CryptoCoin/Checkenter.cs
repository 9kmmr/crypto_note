using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;
namespace CryptoCoin
{
   public class Checkenter
    {
        public  Boolean is_firstenterpri = false;
        public Boolean is_firstentersec = false;
        public  string path = Path.GetDirectoryName(Application.ExecutablePath) + "/Data.DAT";
        string hintpath = Path.GetDirectoryName(Application.ExecutablePath) + "/HintData.DAT";
        public  string primarypass = "";
        public  string secondarypass = "";


        // FIRST LOAD THE DATA OF FILE AND GET THE PASSWORD
        public void loadData()
        {
            if (!File.Exists(hintpath))
            {
                using (StreamWriter outputFile = new StreamWriter(hintpath))
                {
                    outputFile.Write("1111");
                }
            }
            if (File.Exists(path))
            {                
                if (new FileInfo(System.IO.Directory.GetCurrentDirectory() + "/Data.DAT").Length != 0)
                {
                    primarypass = File.ReadLines(path).First();
                    if (File.ReadLines(path).Count() < 2)
                    {
                        is_firstentersec = true;
                    }
                    else secondarypass = File.ReadLines(path).ElementAt(1);
                    if (secondarypass.Equals(".")) is_firstentersec = true;
                    else
                    {
                        is_firstentersec = false;
                    }                    
                }
                else
                {
                    is_firstenterpri = true;
                }               
            }
            else
            {
                // Create the file.
                
                // Open the stream and read it back.
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string hash = GetMd5Hash(md5Hash, "1111");
                        outputFile.WriteLine(hash);
                        primarypass = hash;
                    }
                    
                }
                File.AppendAllText(path, ".\n");
                is_firstenterpri = false;
                is_firstentersec = true;
            }
        }
        // UPDATE DATA IN LINE INDEX
        public void lineChanger(string newText, string fileName , int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        // CHECK IF IT IS THE FIRST TIME WE OPEN THE SOFT IF RIGHT WE INSERT THE PASSWORD
        public Boolean firstenter(string password)
        {
            if (is_firstenterpri)
            {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string hash = GetMd5Hash(md5Hash, password);
                        primarypass = hash;
                        lineChanger(hash, path, 1);                        
                    }
                    File.AppendAllText(path,  ".\n");
                    return true;
            }
            else { return false;}
        }
       // CHECK IF IT IS THE FIRST TIME OPEN THE SECONDARY PASSWORD IF RIGHT WE INSERT
        public Boolean firstsecond(string password)
        {
            if (is_firstentersec)
            {               
                using (MD5 md5Hash = MD5.Create())
                {
                      string hash = GetMd5Hash(md5Hash, password);
                      secondarypass = hash;
                    File.AppendAllText(path, "\n");
                    lineChanger(hash, path, 2);
                }                
                return true;                
            }
            else
            {
                return false;
            }
        }
        // CHECK LOGIN
        public Boolean checkEnter(string password,string type)
        {

            using (MD5 md5Hash = MD5.Create())
            {
                if (type.Equals("primary"))
                {
                    if (VerifyMd5Hash(md5Hash, password, primarypass))
                    {
                        Console.WriteLine("The hashes are the same.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The hashes are not same.");
                        return false;
                    }
                }
                else
                {
                    if (VerifyMd5Hash(md5Hash, password, secondarypass))
                    {
                        Console.WriteLine("The hashes are the same.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The hashes are not same.");
                        return false;
                    }
                }
            }
            
        }

      
        // GET ALL DATA IN FILE
         public List<string> getdatafile()
        {
           
            IEnumerable<string> line = File.ReadLines(path).Skip(2);
            return new List<string>(line);
        }
        // SAVE TO FILE BY APPEND
         public void savetofile(string content)
        {

            File.AppendAllText(path, content + "\n");
        }
       
        public string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // read data and decrypt
       

    }
}
