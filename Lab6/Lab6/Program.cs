using opennlp.tools.sentdetect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"amber_136293_convert.txt");
            using (StreamReader sr = new StreamReader(@"amber_136293.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    java.io.InputStream modelIn = new java.io.FileInputStream(string.Format("{0}en-sent.bin", @"C:\Users\hunterntinc\Desktop\lab-6-opennlp-ju-zi-qie-fen-hunter910202197\Lab6\Lab6\bin\Debug\"));
                    SentenceModel smodel = new SentenceModel(modelIn);
                    SentenceDetector detector = new SentenceDetectorME(smodel);
                    string[] sents = detector.sentDetect(line);
                    foreach (var sent in sents)
                    {
                        Console.WriteLine(sent);
                    }
                }
            }
            sw.Close();
        }
    }
}
