using System;
using ExampleUsingSet.Entities;

namespace ExampleUsingSet {
    internal class Program {
        static void Main(string[] args) {

            HashSet<User> set = new HashSet<User>();
            Console.Write("How many students for course A? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                int code = int.Parse(Console.ReadLine());

                set.Add(new User(code));
            }
            Console.Write("How many students for course B? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                int code = int.Parse(Console.ReadLine());

                set.Add(new User(code));
            }
            Console.Write("How many students for course C? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                int code = int.Parse(Console.ReadLine());

                set.Add(new User(code));
            }
            Console.WriteLine("Total students: " +  set.Count);


        }
    }
}