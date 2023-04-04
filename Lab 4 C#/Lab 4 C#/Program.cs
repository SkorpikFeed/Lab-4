using  Lab_4_C_;

class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter name of the student");
        string name = System.Console.ReadLine();
        System.Console.WriteLine("Enter surname of the student");
        string surname = System.Console.ReadLine();
        System.Console.WriteLine("Enter middle name of the student");
        string middle = System.Console.ReadLine();
        Students students = new Students(name, surname, middle);

        for(int i = 0; i > -1; i++)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("If you want to change information about the student enter 1");
            System.Console.WriteLine("If you want to add new student enter 2");
            System.Console.WriteLine("If you want to STOP enter 3");
            System.Console.WriteLine("If you want to get table of the students enter 4");
            System.Console.ForegroundColor = System.ConsoleColor.White;
            string symb = System.Console.ReadLine();
            switch(symb)
            {
                case "1":
                    System.Console.WriteLine("Enter number of the student");
                    int number = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Enter name of the student");
                    string name1 = System.Console.ReadLine();
                    System.Console.WriteLine("Enter surname of the student");
                    string surname1 = System.Console.ReadLine();
                    System.Console.WriteLine("Enter middle name of the student");
                    string middle1 = System.Console.ReadLine();
                    students[number] = name1 + " " + surname1 + " " + middle1;
                    break;
                case "2":
                    System.Console.WriteLine("Enter name of the student");
                    string name2 = System.Console.ReadLine();
                    System.Console.WriteLine("Enter surname of the student");
                    string surname2 = System.Console.ReadLine();
                    System.Console.WriteLine("Enter middle name of the student");
                    string middle2 = System.Console.ReadLine();
                    students[students.Count] = name2 + " " + surname2 + " " + middle2;
                    break;
                case "3":
                    i = -2;
                    break;
                case "4":
                    for(int j = 0; j < students.Count; j++)
                    {
                        System.Console.WriteLine(students[j]);
                    }
                    break;
                default:
                    System.Console.WriteLine("You entered wrong number");
                    break;
            }
        }
    }
}