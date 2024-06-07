using Xunit;
using ClearMeasureLibrary;

namespace ClearMeasureLibrary.Test
{
    public class TestWriteOutClass
    {
        //[Fact]
        //public void WriteOutValueRespondsWhenGivenIncorrectValue()
        //{
        //    // Test Values 1 - 15
        //    Program p = new Program();
        //    float integer = 1.2f;

        //    string[] v = p.WriteOut(integer);

        //    // Act and Assert
        //    Assert..Equal( v is not null);
        //}

        [Fact]
        public void WriteOutValueIsNotNullWhenGivenInteger()
        {
            // Test Values 1 - 15
            Program p = new Program();
            int integer = 2;

            string[] v = p.WriteOut(integer);

            // Act and Assert
            Assert.True(v is not null);
        }

        [Fact]
        public void WriteOutValueIsStringArray()
        {
            // Test Values 1 - 15
            Program p = new Program();
            int integer = 15;

            string[] v = p.WriteOut(integer);

            // Act and Assert
            Assert.True(v is string[]);
        }

        [Fact]
        public void WriteOutValueIsStringArrayInCorrectSize()
        {
            // Test Values 1 - 15
            Program p = new Program();
            int integer = 15;

            string[] v = p.WriteOut(integer);

            // Act and Assert
            Assert.True(v.Length == integer);
        }

        [Fact]
        public void WriteOutValuesOneThroughFifteenCorrect()
        {
            // Test Values 1 - 15
            Program p = new Program();
            int integer = 15;

            string[] v = p.WriteOut(integer);

            // Act and Assert
            // String Arrays Are Zero Based So Remove 1 From All Values
            Assert.True(v[3 - 1] == "Erik");
            Assert.True(v[5 - 1] == "Cheatham");
            Assert.True(v[6 - 1] == "Erik");
            Assert.True(v[9 - 1] == "Erik");
            Assert.True(v[10 - 1] == "Cheatham");
            Assert.True(v[12 - 1] == "Erik");
            Assert.True(v[15 - 1] == "Erik Cheatham");
        }
    }
}
