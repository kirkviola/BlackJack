using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string FilePath { get; set; }

        public Card() { }
        public Card(string name, int value)
        {
            this.FilePath = name;
            this.Value = value;
        }

        public void ChangeValue()
        {
            this.Value = 1;
        }

    }
}
