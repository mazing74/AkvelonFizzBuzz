using System.Text;

namespace FizzBuzz
{
    enum WordType
    {
        normal,
        Fizz,
        Buzz,
        FizzBuzz,

    }
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
        }


        private void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.", "input");
            }
            if (!(input.Length <= 100 && input.Length >= 7))
            {
                throw new ArgumentException("Input must be between 7 and 100 characters long.", "input");
            }
        }

        private List<WordToken> Tokenize(string input)
        {
            List<WordToken> words = new();

            int wordIndex = 0;

            int i = 0;

            while (i < input.Length)
            {
                if (char.IsLetterOrDigit(input[i]))
                {
                    int start = i;
                    StringBuilder word = new();

                    while (i < input.Length)
                    {
                        char c = input[i];

                        if (char.IsLetterOrDigit(c))
                        {
                            word.Append(c);
                            i++;
                        }
                        else if (c == '\'' && i + 1 < input.Length && char.IsLetterOrDigit(input[i + 1]))
                        {
                            word.Append(c);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    wordIndex++;

                    words.Add(new WordToken(word.ToString(), wordIndex, start, i - start));
                }
                else
                {
                    i++;
                }
            }

            return words;
        }
        private WordType DetermineWordType(int index)
        {
        }
        private FizzBuzzResult BuildResult()
        {
        }
    }
}
