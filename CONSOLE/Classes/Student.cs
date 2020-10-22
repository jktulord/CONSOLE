using System;
using System.Collections.Generic;
using System.Text;

namespace CONSOLE.Classes
{
    public class Student : Person
    {
        public string school;
        public int term;
        public double average_grade;
        public int doppel_stunde;
        /* jojo 11 nonbinary best 11 11 11 
           sasha 18 True worst 3 4,7 26
         */

        public Student()
        {
            school = "default";
            term = 10;
            average_grade = 3;
            doppel_stunde = 10;
        }

        public int get_shift_hours(int value)
        {
            return value * 4 * doppel_stunde * 2;
        }

        public void print_secondary_info()
        {
            Console.WriteLine("School:"+school+" Term:"+term+" Average_grade:"+average_grade+" Doppel_stunde:"+doppel_stunde);
        }

    }
}
