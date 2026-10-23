using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServedStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> studentQueue = new Queue<string>();
            int servedStudents = 0;
            int choice;

            Stack<string> Student = new Stack<string>();
            /* Name - [Grantlee Joshua M. Sibayan]
             * Student service system
             */

            do
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("      STUDENT SERVICE QUEUE SYSTEM ");
                Console.WriteLine("===========================================");
                Console.WriteLine("[1] Add Student");
                Console.WriteLine("[2] Show Waiting Student");
                Console.WriteLine("[3] Served Next Student");
                Console.WriteLine("[4] Show Last Served Student");
                Console.WriteLine("[5] Exit");
                Console.WriteLine("Enter Choice");
                

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Add Student: ");
                        string newStudent = Console.ReadLine();
                        studentQueue.Enqueue(newStudent);
                        Console.WriteLine("Student added sucessfully!");
                        break;

                    case 2:
                        Console.WriteLine("All Student in Waiting: ");
                        if (studentQueue.Count == 0)
                            Console.WriteLine("No Student on the waiting list.");
                        else
                            foreach (string student in studentQueue)
                                Console.WriteLine("- " + student);
                        break;

                    case 3:
                        if (studentQueue.Count > 0)
                        {
                            string finished = studentQueue.Dequeue();
                            Console.WriteLine($"Student Served: {finished}");
                            Student.Push(finished);
                            servedStudents++;
                            Console.WriteLine("Student Sucessfully Served");
                        }
                        else
                        {
                            Console.WriteLine("No student in waiting.");
                        }
                        break;

                    case 4:
                        if (Student.Count > 0)
                            Console.WriteLine(Student.Peek());
                        else
                            Console.WriteLine("Stack is empty.");
                        break;

                    case 5:
                        Console.WriteLine("Thank You For the Service");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;


                }

            } while (choice != 5);
        }
    }
}
