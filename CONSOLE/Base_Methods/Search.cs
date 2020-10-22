using CONSOLE.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CONSOLE.Base_Methods
{
    public static class Search
    {
        public static Student StudentByName(List<Student> s_list, string name)
        {
            foreach (Student cur in s_list) 
            {
                Student ret_stud;
                if (cur.name == name)
                {
                    ret_stud = cur;
                    return ret_stud;
                }
            }
            return null;
        }
        public static Worker WorkerByName(List<Worker> s_list, string name)
        {
            foreach (Worker cur in s_list)
            {
                Worker ret_stud;
                if (cur.name == name)
                {
                    ret_stud = cur;
                    return ret_stud;
                }
            }
            return null;
        }
    }
}
