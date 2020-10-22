using CONSOLE.Classes;
using CONSOLE.Methods;
using System;
using System.Collections.Generic;

namespace CONSOLE
{
    class Program
    {
        public static List<Student> student_list = new List<Student>();
        public static List<Worker> worker_list = new List<Worker>();
        public static Commands C = new Commands(); 
        static void Main(string[] args) 
        {


            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your command");
                string[] words = InputMethods.Read_Separated_String();

                switch (words[0])
                {
                    case "sAdd":
                        C.AddStudent(student_list, words);
                        break;
                    case "sAddDef":
                        C.AddStudent(student_list, words, true);
                        break;
                    case "wAdd":
                        C.AddWorker(worker_list, words);
                        break;
                    case "wAddDef":
                        C.AddWorker(worker_list, words, true);
                        break;
                    case "sPrint":
                        C.PrintStudents(student_list, words);
                        break;
                    case "wPrint":
                        C.PrintWorkers(worker_list, words);
                        break;
                    case "sShift":
                        C.ShiftStudents(student_list, words);
                        break;
                    case "wShift":
                        C.ShiftWorkers(worker_list, words);
                        break;
                    case "exit":
                        exit = true;
                        break;
                }
            }
            
        }
    }
}
