using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDic
{
    class Languages
    {
        private string input;
        public enum langs {unknown,en,kana,kata,th}; 
       
        public Languages() { }
        public Languages(string input)
        {
            this.input = input;

        }

        public langs Check()
        {
            if (this.input.Length < 1) return langs.unknown;
            int input = (int)this.input[0];
            if (input > 96 && input < 123)
            {
                return langs.en;
            }
            else if (input > 12351 && input < 12448)
            {//kana
                return langs.kana;
            }
            else if (input > 12447 && input < 12544)
            {//kata
                return langs.kata;
            }
            else if (input > 3584 && input < 3674)
            {
                return langs.th;
            }
            else
            {
                return langs.unknown;
            }
            
        }

        public int ToAscii()
        {
            return (int)this.input[0];
        }


    }
}
