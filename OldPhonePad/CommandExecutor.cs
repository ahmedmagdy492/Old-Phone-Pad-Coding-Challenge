using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public static class CommandExecutor
    {
        /// <summary>
        /// takes a list of commands and look each one up in a list of built-in commands and
        /// reterives the mapping value
        /// </summary>
        /// <param name="input">list of valid commands</param>
        /// <returns>string representing a sequence of characters the user entered</returns>
        /// <exception cref="UnknownCommandException">if the entered command is unknown</exception>
        public static string InterpretAndExecute(List<string> input)
        {
            StringBuilder output = new();
            int listCounter = 0;
            Dictionary<string, char> builtInCommands = new()
            {
                ["1"] = 'J',
                ["11"] = '\'',
                ["111"] = '(',
                ["2"] = 'A',
                ["22"] = 'B',
                ["222"] = 'C',
                ["3"] = 'D',
                ["33"] = 'E',
                ["333"] = 'F',
                ["4"] = 'G',
                ["44"] = 'H',
                ["444"] = 'I',
                ["5"] = 'J',
                ["55"] = 'K',
                ["555"] = 'L',
                ["6"] = 'M',
                ["66"] = 'N',
                ["666"] = 'O',
                ["7"] = 'P',
                ["77"] = 'Q',
                ["777"] = 'R',
                ["7777"] = 'S',
                ["8"] = 'T',
                ["88"] = 'U',
                ["888"] = 'V',
                ["9"] = 'W',
                ["99"] = 'X',
                ["999"] = 'Y',
                ["9999"] = 'Z',
                ["0"] = ' '
            };

            while (listCounter < input.Count)
            {
                string command = input[listCounter];
                listCounter++;

                if (command == "*")
                {
                    // special command to remove a character from the user entered string
                    output.Remove(output.Length - 1, 1);
                }
                else if (!builtInCommands.ContainsKey(command))
                {
                    throw new UnknownCommandException($"Unsupported Command: {command}");
                }
                else
                {
                    output.Append(builtInCommands[command]);
                }
            }

            return output.ToString();
        }
    }
}
