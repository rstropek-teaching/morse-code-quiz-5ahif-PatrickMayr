using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse.Library
{
    public class Letter
    {
        public string letter { get; set; }
        public String code { get; set; }

        public Letter(string letter, String code) {
            this.letter = letter;
            this.code = code;
        }
    }
}
