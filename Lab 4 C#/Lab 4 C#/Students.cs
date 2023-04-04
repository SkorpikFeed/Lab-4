using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_C_
{
    internal class Students
    {
        private List<string> names = new List<string>();
        private List<string> surnames = new List<string>();
        private List<string> middleNames = new List<string>();
        private int count = 0;
        public Students() 
        {
        }
        public Students(string name,string surname,string middle) 
        {
            names.Add(name);
            surnames.Add(surname);
            middleNames.Add(middle);
            count++;
        }
        public string this[int index]
        {
            set 
            {
                string[] parts = value.Split(' ');
                if(index < 0 || index > count)
                {
                    System.Console.WriteLine("You entered wrong index");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if(index == count) 
                {
                    names.Add(parts[0]);
                    surnames.Add(parts[1]);
                    middleNames.Add(parts[2]);
                    count++;
                }
                else
                {
                    names[index] = parts[0];
                    surnames[index] = parts[1];
                    middleNames[index] = parts[2];
                }
            }
            get 
            {
                if(index < 0 || index > count)
                {
                    System.Console.WriteLine("You entered wrong index");
                    return null;
                }
                else
                {
                    return names[index] + " " + surnames[index] + " " + middleNames[index];
                }
            }
        }
        public int Count
        {
            get { return count; }
        }

    }
}
