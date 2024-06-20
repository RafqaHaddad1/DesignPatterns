using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public  class Strategy
    {
        //The Strategy design pattern is a behavioral design pattern that enables an algorithm's behavior to be selected at runtime.
        //It defines a family of algorithms, encapsulates each algorithm, and makes them interchangeable. The Strategy pattern allows the client to choose which algorithm to use in a flexible and reusable way.

        public interface ITextFormatter
        {
            void Format(string text);
        }

        // Concrete Strategy 1: Plain Text Formatter
        public class PlainTextFormatter : ITextFormatter
        {
            public void Format(string text)
            {
                Console.WriteLine("Plain Text: " + text);
            }
        }

        // Concrete Strategy 2: HTML Formatter
        public class HtmlFormatter : ITextFormatter
        {
            public void Format(string text)
            {
                Console.WriteLine("HTML: <p>" + text + "</p>");
            }
        }

        // Concrete Strategy 3: Markdown Formatter
        public class MarkdownFormatter : ITextFormatter
        {
            public void Format(string text)
            {
                Console.WriteLine("Markdown: **" + text + "**");
            }
        }

        // Context
        public class TextEditor
        {
            private ITextFormatter _textFormatter;

            public void SetFormatter(ITextFormatter textFormatter)
            {
                _textFormatter = textFormatter;
            }

            public void PublishText(string text)
            {
                _textFormatter?.Format(text);
            }
        }
        public void Run()
        {
            TextEditor editor = new TextEditor();

            // Use plain text formatter
            editor.SetFormatter(new PlainTextFormatter());
            editor.PublishText("Hello, World!");

            // Use HTML formatter
            editor.SetFormatter(new HtmlFormatter());
            editor.PublishText("Hello, World!");

            // Use Markdown formatter
            editor.SetFormatter(new MarkdownFormatter());
            editor.PublishText("Hello, World!");

        }
        
        
    }
}
