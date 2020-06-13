using System;

namespace Csharp
{
    //Base class
    public class Pages
    {
        //class property
        public int id { get; set; }
        public string name { get; set; }

        //constructor
        public Pages()
        {
            Console.WriteLine("constructor of Pages class");
        }

        //method
        public void Init()
        {
            Console.WriteLine("Pages init method ");
        }

         //overload method
        public void Init(string name)
        {
           Console.WriteLine("Pages init overload method " + name);
        }

        //virtual method
        public virtual void Print()
        {
            Console.WriteLine("Pages virtual method");
        }

        //proteced method - access in derived class
        protected void AcceptCookie()
        {
            Console.WriteLine("Protected method");
        }

    }
}