using CONSOLE.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using CONSOLE.Base_Methods;

namespace CONSOLE
{
    public class Commands
    {
        public void AddStudent(List<Student> s_list, string[] input, bool def = false)
        {
            if (def)
            {
                s_list.Add(new Student());
            }
            else
            {
                s_list.Add(new Student()
                {
                    name = input[1],
                    age = Convert.ToInt32(input[2]),
                    gender = input[3],
                    school = input[4],
                    term = Convert.ToInt32(input[5]),
                    average_grade = Convert.ToDouble(input[6]),
                    doppel_stunde = Convert.ToInt32(input[7])
                });
            }
            
        }
        public void AddWorker(List<Worker> w_list, string[] input, bool def = false)
        {
            if (def)
            {
                w_list.Add(new Worker());
            }
            else
                w_list.Add(new Worker()
            {
                name = input[1],
                age = Convert.ToInt32(input[2]),
                gender = input[3],
                work = input[4],
                experience = Convert.ToInt32(input[5]),
                profession = input[6],
                hps = Convert.ToInt32(input[7])
            });
        }
        public void PrintStudents(List<Student> s_list, string[] input)
        {
            foreach (Student cur in s_list)
            {
                cur.print_base_info();
                cur.print_secondary_info();
            }
        }
        public void PrintWorkers(List<Worker> w_list, string[] input)
        {
            foreach (Worker cur in w_list)
            {
                cur.print_base_info();
                cur.print_secondary_info();
            }
        }
        public void ShiftStudents(List<Student> s_list, string[] input)
        {
            Student cur=Search.StudentByName(s_list, input[1]);
            Console.WriteLine("amount of hours " + input[1] + " did learned for " + input[2]+" months");
            Console.WriteLine(": " + cur.get_shift_hours(Convert.ToInt32(input[2])));
        }
        public void ShiftWorkers(List<Worker> w_list, string[] input)
        {
            Worker cur = Search.WorkerByName(w_list, input[1]);
            Console.WriteLine("amount of full shifts " + input[1] + " did learned for " + input[2] + " hours");
            Console.WriteLine(": " + cur.get_shifts(Convert.ToInt32(input[2])));
        }

    }
}
