using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Item magicWand = new Item ("Magic Wand","Attachment",2,10,0);
            SpellBook sbook = new SpellBook();

            Character wiz = new Character("Alfred The Wizard");
            wiz.AddItem(magicWand);
        }
    }
}


