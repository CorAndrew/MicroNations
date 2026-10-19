using System;
using System.Collections.Generic;
using System.Text;

namespace MicroNations
{
    public class Partita
    {
        public string Casa { get; set; }
        public string Ospiti { get; set; }
        public int GoalCasa { get; set; }
        public int GoalOspiti { get; set; }

        public Partita(string c, string o, int gc, int go)
        {
            Casa = c;
            Ospiti = o;
            GoalCasa = gc;
            GoalOspiti = go;
        }

        public Partita() { }
    }
}
