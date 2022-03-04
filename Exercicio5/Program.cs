using System;

namespace Exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] rooms = new Student[10];
            Console.Write("Type the number os students that will reant a room: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("Type the name of the student: ");
                string name = Console.ReadLine();
                Console.Write("Type the email of the stundet: ");
                string email = Console.ReadLine();
                Console.Write("Type the number of the room chosed by the student: ");
                int numberRoom = int.Parse(Console.ReadLine());

                rooms[numberRoom] = new Student() { Name = name, Email = email };
            }

            Console.WriteLine($"Busy rooms:");
            for (int i = 0; i < 10; i++)
            {                
                if (rooms[i] != null)
                {                    
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");                    
                }
            }
            
        }
    }
}