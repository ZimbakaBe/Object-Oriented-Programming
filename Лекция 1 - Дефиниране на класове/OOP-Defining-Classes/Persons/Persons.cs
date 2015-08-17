using System;

    class Persons
    {
        static void Main()
        {
            Person g = new Person("Georgi", 18);
            Console.WriteLine(g);

            Person i = new Person("Ivan", 16, "ivan.ivanov@gmail.com");
            Console.WriteLine(i);

        }
    }
