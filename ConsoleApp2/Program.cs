using System;


class School {
    //datatypes and variables
    static void Main(string[] args) {
        //variables
        int age = 24;
        float height = 1.31f;
        char initial = 'D';
        bool isStudent = true;
        string name = "Kailash";

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("initial: " + initial);
        Console.WriteLine("Is Student: " + isStudent);


        //control statements

        int num = 8;
        if (num > 5)
            Console.WriteLine("greater");
        else if (num < 2)
            Console.WriteLine("smaller");
        else
            Console.WriteLine("default");


        //switch statement

        int num2 = 2;
        switch (num2)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            default:
                Console.WriteLine("Other number");
                break;
        }


        //loops 

       

        for (int i = 0; i <= 5; i++)
            Console.WriteLine("Result is " + i);

        int j = 40;
        while (j > 30) {

            Console.WriteLine("while loop"+j);
            j--;
           }
  



    }


   



}