using System;
using System.Collections.Generic;
using System.IO;

namespace ContagemVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votos = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int numvt = int.Parse(line[1]);

                        if (votos.ContainsKey(name))
                        {
                            votos[name] += numvt;
                        }
                        else
                        {
                            votos[name] = numvt;
                        }
                        
                    }
                    foreach(var vt in votos)
                    {
                        Console.WriteLine(vt.Key + ": " + vt.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
