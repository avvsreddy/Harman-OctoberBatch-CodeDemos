using System.Xml.Linq;

namespace LinqToXmlDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = XDocument.Load("XMLFile1.xml");

            var titles = from title in xml.Descendants("title")
                         select title.Value;

            var titlesNAuthors = from book in xml.Descendants("book")
                                 where book.Element("genre").Value == "Fantasy"
                                 select new
                                 {
                                     Title = book.Element("title").Value,
                                     Author = book.Element("author").Value
                                 };

            Console.WriteLine(titlesNAuthors.ToString());

            var document = new XElement("Books",
                                from book in xml.Descendants("book")
                                where book.Element("genre").Value == "Fantasy"
                                select new XElement("Book",
                                    new XElement("Title", book.Element("title").Value),
                                    new XElement("Author", book.Element("author").Value)));

            document.Save("newbooks.xml");

            /*
             * <Books>
             *  <Book>
             *      <Title>sdfsdfsdfds</Title>
             *      <Author>sdfsdfsdf</Author>
             *  </Book>
             *   <Book>
             *      <Title>sdfsdfsdfds</Title>
             *      <Author>sdfsdfsdf</Author>
             *  </Book>
             *  
             *  </Books>
             *  
             *      
             */

            //foreach (var book in titlesNAuthors)
            //{
            //    Console.WriteLine(book.Title + " " + book.Author);
            //}

        }
    }
}
