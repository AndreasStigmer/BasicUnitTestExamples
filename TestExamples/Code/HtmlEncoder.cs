using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExamples.Code
{
    public  class HtmlEncoder
    {
        public string Strong(string content)
        {
            return $"<strong>{content}</strong>";
        }
        public string Italic(string content)
        {
            return $"<i>{content}</i>";
        }
        public string Paragraph(string content)
        {
            return $"<p>{content}</p>";
        }
    }
}
