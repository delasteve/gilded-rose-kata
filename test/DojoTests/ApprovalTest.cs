using Xunit;
using System;
using System.IO;
using System.Text;
using Dojo;

namespace DojoTests
{
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var lines = File.ReadAllLines("ThirtyDays.txt", Encoding.UTF8);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeOutput.ToString();

            var outputLines = output.Split("\r\n");

            for (var i = 0; i < Math.Min(lines.Length, outputLines.Length); i++) 
            {
                Assert.Equal(lines[i], outputLines[i]);
            }
        }
    }
}
