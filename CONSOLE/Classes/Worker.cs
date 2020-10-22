using System;
using System.Collections.Generic;
using System.Text;

namespace CONSOLE.Classes
{
    public class Worker: Person
    {
        public string work;
        public int experience;
        public string profession;
        public int hps;
        /* jojo 11 nonbinary best 11 akvamen 11 
           sasha 18 male worst 3 Fashion 26
        */
        public Worker()
        {
            work = "default";
            experience = 10;
            profession = "True_Fashion";
            hps = 10;
        }

        public int get_shifts(int value)
        {
            return value / hps;
        }

        public void print_secondary_info()
        {
            Console.WriteLine("Work:" + work + " Years of experience:" + experience + " Profession:" + profession + " Hours per shift:" + hps);
        }
    }
}
