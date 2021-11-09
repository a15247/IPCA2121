using System;
using System.Xml.XPath;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName;
            XPathDocument document;
            XPathNavigator navigator;
            XPathNodeIterator node;
            string title;


            //prepare validation enviroment
            fileName = @"C:\Users\João\Documents\universidade.xml";

            //open xml file
            document = new XPathDocument(fileName);
            navigator = document.CreateNavigator();

            //Exemplo 1
            title = "SELECTALL TEACHERS INSIDE UNIVERSITY / TEACHERS";
            node = navigator.Select("/university/teachers/teacher");
            ShowNote(title, node);

            Console.ReadKey();
            
        }

        static void ShowNote (string title, XPathNodeIterator node)
        {
            //title
            Console.WriteLine(title);

            //count
            Console.WriteLine($" count: { node.Count}");

            //Show result
            while(node.MoveNext())
            {
                Console.WriteLine(node.Current.OuterXml);
            }

            //end
            Console.WriteLine("-------------------------");
        }
    }
}
