using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public enum ActionKind 
    {
        Add, Substract, Multiply, Divide
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }
    }

    struct Coords
    {
        public int x;
        public int y;

    }

    class Program
    {

        public static int OpMethod (int a, int b, ActionKind c)
        {
            int sum = 0;
            switch(c)
            {
                case ActionKind.Add:
                    sum = a + b;
                    break;
                case ActionKind.Substract:
                    sum = a - b;
                    break;
                case ActionKind.Divide:
                    sum = a / b;
                    break;
                case ActionKind.Multiply:
                    sum = a * b;
                    break;
            }
            return sum;
        }

        public static void ChangeString(string s, string s1)
        {
            string temp;
            temp = s;
            s = s1;
            s1 = temp;
            Console.WriteLine(s +" "+ s1);
        }

        static void Main(string[] args)
        {

            Coords point = new Coords();
            point.x = 10;
            point.y = 10;

            //Person[] persons = new Person[2];
            //string name, surname;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    name = Console.ReadLine();
            //    surname = Console.ReadLine();
            //    persons[i] = new Person(name, surname);
            //}
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"{persons[i].Name}  {persons[i].Surname}");
            //}

            //int[][] nums = new int[2][];
            //nums[0] = new int [3]{1,2,3};
            //nums[1] = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (var item in nums)
            //{
            //    foreach (var mas in item)
            //    {
            //        Console.WriteLine(mas);
            //    }
            //}

            //int[] array = { -22, 10, -5, 444, -99, 11, -88, 2, -1, -44, -88, -7 };
            //List<int> temp = new List<int>();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //        temp.Add(array[i]);
            //}
            //for (int i = 1; i < temp.Count; i++)
            //{
            //    Console.WriteLine(temp[i]);
            //    i++;
            //}

            //ActionKind am;
            //am = ActionKind.Add;
            //Console.WriteLine((int)am);
            //string str = Console.ReadLine();


            //Console.WriteLine(OpMethod(58,10,(ActionKind)Enum.Parse(typeof(ActionKind), str)));

            ChangeString("yo", "nigga"); 
        }
    }
}
