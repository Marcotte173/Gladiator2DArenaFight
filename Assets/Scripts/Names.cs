using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Names
{
    static Random rand = new Random();
    static List<string> list = new List<string> 
    {
            "Angela","Amy", "Anna","Alison","Adam","Alex","Anthony","Alistair","Alfred","Alexa","Ainsley",
            "Beth", "Bonnie", "Bailey","Beuford", "Barbara","Bernard", "Bill", "Bryce", "Belle","Barrie",
            "Carol", "Candice", "Cindy","Cole", "Charles","Chris","Chance", "Caleb","Caddie","Caitlyn", "Connor", "Carl",
            "Donna", "Deborah","Doug",  "Don", "Dwight", "Dexter", "Daphne",
            "Elaine", "Emily","Edward", "Eric",
            "Farrah","Fred","Frank", "Fran",
            "Gina", "George", "Gerald",
            "Heather",  "Harold","Hank",
            "Isabelle", "Ian",
            "Jolene",  "Jake", "James", "Jackson", "Jesse", "John", "Jack", "Janet",
            "Katherine", "Karl", "Keon", "Kevan",
            "Laura","Lewis","Larry",
            "Mary",  "Matt","Martin","Melvin","Maebel", "Maddox","Meagen","Magda","Marvin","Mitch","Micah","Mia","Mark","Micheal",
            "Olivea",
            "Piper" 
    };

    internal static string Return()
    {
        return list[rand.Next(0, list.Count)];
    }

}