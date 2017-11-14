using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long post blah blah blah...";
            // accessing a static method on an instance object..
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            // Using already defined extension Max
            IEnumerable<int> numbers = new List<int>(){1, 5, 3, 18, 7, 8, 9};
            var max = numbers.Max();

            Console.WriteLine(max);

            
        }
    }

    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            // defensive coding
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords shoube be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }

}
