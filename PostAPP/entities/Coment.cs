using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAPP.entities
{
    public class Coments
    {
        public string Text { get; set; }

        public Coments()
        {

        }
        public Coments(string text)
        {
            Text = text;
        }
    }
}