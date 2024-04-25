using System;
using System.Diagnostics;
namespace prevod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDirectory = @"C:\Users\micha\OneDrive\Plocha\fotky";
            string outputDirectory = @"C:\Users\micha\OneDrive\Plocha\jpgfotky";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "magick";
            startInfo.Arguments = $"convert \"{inputDirectory}\\*.heic\" \"{outputDirectory}\\%d.jpg\"";

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            Console.WriteLine("Převod dokončen.");
        }
    }
}