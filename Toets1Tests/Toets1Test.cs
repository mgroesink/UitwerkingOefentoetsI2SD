using I1SD_Toets1_Start;

namespace Toets1Tests
{
    public class Toets1Test
    {
        [Fact]
        public void TestHallo()
        {
            var result = MyFunctions.Hallo();
            Assert.Equal("Welkom bij deze ASP-NET / C# toets", result);
        }

        [Fact]
        public void TestGetNumberSequence()
        {
            var result = MyFunctions.GetNumberSequence(5);
            Assert.Equal(5, result.Count);
            Assert.Equal((1, 1), result[0]);
            Assert.Equal((2, 4), result[1]);
            Assert.Equal((3, 27), result[2]);
            Assert.Equal((4, 16), result[3]);
            Assert.Equal((5, 3125), result[4]);
        }

        [Fact]
        public void TestGetNumberSequenceInvalid()
        {
            Assert.Throws<ArgumentException>(() => MyFunctions.GetNumberSequence(4));
            Assert.Throws<ArgumentException>(() => MyFunctions.GetNumberSequence(21));
        }
    }
}