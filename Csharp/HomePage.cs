using System;

namespace Csharp
{
    //inheritance
    public class HomePage : Pages,IHeader
    {
        public int num { get; set; }

        public HomePage()
        {
             Console.WriteLine("HomePage Constructor");
        }

        public void HeadMenu()
        {
            Console.WriteLine("implement interface HeadMenu method");
        }

        public int HeadNum()
        {
            int x =this.num +1;
            Console.WriteLine("implement interface HeadNum method");
            return x;
        }

        public override void Print()
        {
            Console.WriteLine("HomePage override method");
        }

        public void PotectedDetails()
        {
            //protected method from base class
            AcceptCookie();
        }
        
    }
}