using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse.Library
{
    public class MorseDecoder
    {
        public List<Letter> list { get; set; }

        public MorseDecoder()
        {
            this.list = new List<Letter>();
            this.fillList();
        }

        public void fillList()
        {

            //Buchstaben
            Letter letter1 = new Letter("A", ".-");
            Letter letter2 = new Letter("B", "-...");
            Letter letter3 = new Letter("C", "-.-.");
            Letter letter4 = new Letter("D", "-..");
            Letter letter5 = new Letter("E", ".");
            Letter letter6 = new Letter("F", "..-.");
            Letter letter7 = new Letter("G", "--.");
            Letter letter8 = new Letter("H", "....");
            Letter letter9 = new Letter("I", "..");
            Letter letter10 = new Letter("J", ".---");
            Letter letter11 = new Letter("K", "-.-");
            Letter letter12 = new Letter("L", ".-..");
            Letter letter13 = new Letter("M", "--");
            Letter letter14 = new Letter("N", " -.");
            Letter letter15 = new Letter("O", "-- -");
            Letter letter16 = new Letter("P", ".--.");
            Letter letter17 = new Letter("Q", "--.-");
            Letter letter18 = new Letter("R", ".-.");
            Letter letter19 = new Letter("S", "...");
            Letter letter20 = new Letter("T", " - ");
            Letter letter21 = new Letter("U", "..-");
            Letter letter22 = new Letter("V", "...-");
            Letter letter23 = new Letter("W", ".--");
            Letter letter24 = new Letter("X", " -..-");
            Letter letter25 = new Letter("Y", " -.--");
            Letter letter26 = new Letter("Z", "--..");

            list.Add(letter1);
            list.Add(letter2);
            list.Add(letter3);
            list.Add(letter4);
            list.Add(letter5);
            list.Add(letter6);
            list.Add(letter7);
            list.Add(letter8);
            list.Add(letter9);
            list.Add(letter10);
            list.Add(letter11);
            list.Add(letter12);
            list.Add(letter13);
            list.Add(letter14);
            list.Add(letter15);
            list.Add(letter16);
            list.Add(letter17);
            list.Add(letter18);
            list.Add(letter19);
            list.Add(letter20);
            list.Add(letter21);
            list.Add(letter22);
            list.Add(letter23);
            list.Add(letter24);
            list.Add(letter25);
            list.Add(letter26);

            //Zahlen
            Letter num1 = new Letter("1", ".----");
            Letter num2 = new Letter("2", "..---");
            Letter num3 = new Letter("3", "...--");
            Letter num4 = new Letter("4", "....-");
            Letter num5 = new Letter("5", ".....");
            Letter num6 = new Letter("6", " -....");
            Letter num7 = new Letter("7", "--...");
            Letter num8 = new Letter("8", "-- -..");
            Letter num9 = new Letter("9", "----.");
            Letter num10 = new Letter("0", "-----");

            list.Add(num1);
            list.Add(num2);
            list.Add(num3);
            list.Add(num4);
            list.Add(num5);
            list.Add(num6);
            list.Add(num7);
            list.Add(num8);
            list.Add(num9);
            list.Add(num10);
        }

        public string getMorseFromLetter(string letter)
        {
            for(int i = 0; i < list.Count; i++)
            {
                //Buchstabe
                if (letter.Equals(this.list[i].letter))
                {
                    if(this.list[i].code == null)
                    {
                        throw new NullReferenceException();
                    }
                    return this.list[i].code;
                }
                //Leerzeichen
                else
                {
                    if(letter.Equals(" "))
                    {
                        return "   ";
                    }
                }
            }

            throw new Exception();
        }
    }
}
