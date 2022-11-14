using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public static class CommandExtractor
    {
        /// <summary>
        /// takes a sequence of characters representing the user pressed button and converts them to a list of commands
        /// </summary>
        /// <param name="input">string represents the user pressed buttons</param>
        /// <returns>list of string representing the commands to be executed</returns>
        public static List<string> ExtractCommands(string input)
        {
            List<string> output = new();
            StringBuilder tempCommand = new();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    output.Add("*");
                }
                else if (i <= input.Length - 2 && input[i] != input[i + 1])
                {
                    if (input[i] != ' ')
                    {
                        tempCommand.Append(input[i]);
                        output.Add(tempCommand.ToString());
                        tempCommand.Clear();
                    }
                }
                else
                {
                    tempCommand.Append(input[i]);
                }
            }

            return output;
        }
    }
}
