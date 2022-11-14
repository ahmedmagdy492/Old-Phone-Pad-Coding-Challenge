using OldPhonePad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadTest
{
    [TestClass]
    public class TestCommandExtractor
    {
        [TestMethod]
        public void ToReturnInterpretedString()
        {
            string input = "1 1123 56898*";
            List<string> expectedOutput = new()
            {
                "1",
                "11",
                "2",
                "3",
                "5",
                "6",
                "8",
                "9",
                "8",
                "*"
            };

            var output = CommandExtractor.ExtractCommands(input);

            for (int i = 0;i < output.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], output[i]);
            }
        }
    }
}
