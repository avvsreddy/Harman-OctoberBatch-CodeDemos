using System.Xml.Linq;

namespace LinqToXMLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "one", "two", "three", "four", "five", "six" };

            // get all short words and display

            XDocument xml = XDocument.Load("Words.xml");

            var shortWords = from w in xml.Descendants("word")
                             where w.Value.Length <= 3
                             select w.Value;

            foreach (var word in shortWords) { Console.WriteLine(word); }
        }
    }
}
