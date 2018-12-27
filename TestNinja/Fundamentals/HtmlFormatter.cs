using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.Fundamentals
{
   public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
