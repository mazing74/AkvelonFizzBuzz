namespace FizzBuzz.Tests
{
    public class FizzBuzzDetectorTests
    {
        private readonly FizzBuzzDetector _detector = new();


        [Fact]
        public void GetOverlappings_Should_ReturnZeroCount_WhenNoWordIsReplaced()
        {
            string input = "Welcome Everyone";

            var result = _detector.getOverlappings(input);

            Assert.Equal("Welcome Everyone", result.Output);
            Assert.Equal(0, result.Count);
        }
        [Fact]
        public void GetOverlappings_Should_ReturnExpectedOutput_ForSampleInput()
        {
            string input = @"Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";

            var result = _detector.getOverlappings(input);

            string expected = @"Mary had Fizz little Buzz Fizz lamb, little Fizz Buzz had Fizz little lamb FizzBuzz fleece was Fizz as Buzz";

            Assert.Equal(expected, result.Output);
            Assert.Equal(9, result.Count);
        }
        [Fact]
        public void GetOverlappings_Should_Throw_WhenInputIsNull()
        {
            Assert.Throws<ArgumentException>(
                () => _detector.getOverlappings(null));
        }

        [Fact]
        public void GetOverlappings_Should_Throw_WhenLengthIsLessThan7()
        {
            Assert.Throws<ArgumentException>(
                () => _detector.getOverlappings("Hello"));
        }


    }
}
