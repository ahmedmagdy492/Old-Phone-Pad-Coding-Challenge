namespace OldPhonePad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            string output = OldPhonePad("8 88777444666*664#");
            Console.WriteLine(output);
        }

        public static string OldPhonePad(string input)
        {
            return CommandExecutor.InterpretAndExecute(CommandExtractor.ExtractCommands(input));
        }
    }
}