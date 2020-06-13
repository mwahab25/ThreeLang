using System;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //input,read data
            string input= Console.ReadLine();
            //output,print data
            Console.WriteLine("Hello " + input);

            //Data types-Integer
            int id = 4;
            //Data types-string
            string title="Check valid login";
            //Data types-character
            char symbol='A';
            //Data types-double
            double peektime = 36.34;
            //Data types-boolean
            bool defaultflag = true;

            //Decision - if 
            if(peektime > 10)
            {
                //write code
            }
            
             //Decision - if else
            if(peektime <10)
            {
                //write code
            }
            else
            {
                //write code
            }

            //Decision - if else if
            if(peektime > 10)
            {
                //write code
            }
            else if(peektime == 10)
            {
                //write code
            }
            else
            {
                //write code
            }

            //Decision - nested if
            if(peektime < 10)
            {
                if(peektime < 5)
                {
                    //write code
                }
            }

            //Arrays
            int[] arr1=new int[3];
            arr1[0] = 4;
            arr1[1] = 5;
            arr1[2] = 3;

            int[] arr={1,3,5,6,7,8,9};

            //Collection -List
            List<int> list=new List<int>();
            list.Add(1);
            list.Add(3);

            //Collection -Dictionary
            Dictionary<int,string> dict=new Dictionary<int, string>();
            dict.Add(1,"chrome");
            dict.Add(2,"firefox");

            //Collection -Stack
            Stack<double> stack=new Stack<double>();
            stack.Push(2.3);
            stack.Push(4.6);

            stack.Pop();
            //Collection -Queue
            Queue<short> que=new Queue<short>();
            que.Enqueue(3);
            que.Enqueue(5);

            que.Dequeue();

            //Loops - foreach
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

             //Loops - for
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);     
            }

            //Loops - while
            int j=7;
            while(j > 3)
            {
                Console.WriteLine(j);
                j--;
            }
            
            j=10;
            //Loops -Do while
            do{
                Console.WriteLine(j);
                j--;
            }while(j<3);


            //classes and objects
            Pages page=new Pages();
            //pass value to property
            page.id=200;
            //call methods
            page.Init();
            page.Init("pass string");
            page.Print();

            HomePage homePage=new HomePage();
            homePage.num=7;

            homePage.HeadMenu();
            homePage.HeadNum();

            //call override method
            homePage.Print();

            //call Base class methods, properties
            homePage.name="name property";
            homePage.Init();

            
            
        }
    }
}
