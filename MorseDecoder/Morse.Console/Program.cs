using Morse.Library;
using System.IO;
using System.Text;

namespace System
{
    public class Program
    {
        static void Main(string[] args)
        {

            string inputFilename = "";
            string outputFilename = "";

            // from Command Line
            if (args.Length == 2)
            {
                inputFilename = args[0];
                outputFilename = args[1];

                readFromFile(inputFilename, outputFilename);
            }
            else
            {
                Console.WriteLine("Wrong Parameters: You need an input file and and output file!");
            }       
        }

        public static void readFromFile(string input, string output)
        {
            char ch = ' ';
            string code = " ";
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);
            MorseDecoder decoder = new MorseDecoder();

            while (!reader.EndOfStream)
            {

                ch = (char) reader.Read();

                if (ch != '\n' && ch != '\r')
                {
                    try
                    {
                        string let = Char.ToString(ch);
                        let = let.ToUpper();
                        code = decoder.getMorseFromLetter(let);
                        code = code + " ";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong Character!" + (int)ch);
                    }
                }
                else
                {
                    code = ch + "";
                }
                
                //Hinausschreiben
                writer.Write(code);
            }
            reader.Close();
            writer.Flush();
            writer.Close();
        }
    }
}
