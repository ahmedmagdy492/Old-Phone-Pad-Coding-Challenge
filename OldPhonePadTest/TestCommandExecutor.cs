namespace OldPhonePadTest
{
    using Microsoft.VisualStudio.TestPlatform.TestHost;
    using OldPhonePad;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class TestCommandExecutor
    {
        [TestMethod]
        public void ToReturnOriginalStringMinus1Char()
        {
            List<string> input = new()
            {
                "8",
                "999",
                "*"
            };
            string expectedOutput = "T";

            Assert.AreEqual(expectedOutput, CommandExecutor.InterpretAndExecute(input));
        }

        [TestMethod]
        public void ToThrowExceptionIncaseOfUnknownCommandProvided()
        {
            List<string> input = new()
            {
                "8",
                "bbb", // unknown command
                "*"
            };

            Assert.ThrowsException<UnknownCommandException>(() =>
            {
                CommandExecutor.InterpretAndExecute(input);
            });
        }
    }
}