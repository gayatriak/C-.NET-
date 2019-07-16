using System;
using System.Collections.Generic;
using System.Text;

namespace Audit
{
    class WriteTextFile
    {
        static void Main()
        {

            string[] lines = { "First line", "Second line", "Third line" };    
            
            System.IO.File.WriteAllLines(@"C:\Users\Gayatri\source\repos\TestFolder\WriteLines.txt", lines);

            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            
            System.IO.File.WriteAllText(@"C:\Users\Gayatri\source\repos\TestFolder\WriteText.txt", text);

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
 
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Gayatri\source\repos\TestFolder\WriteLines2.txt", true))
            {
                file.WriteLine("Fourth line");
            }
        }
    }
   
}
