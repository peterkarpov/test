using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            A c = new C();

            c.M();

            int i = 1;

            string s = "2";

            s = Convert.ToString(i);
            i = Convert.ToInt32(s);

            var n = ((IConvertible)i).ToInt32(null);

            IComparable comparable = i;

            

            IConvertible convert = i;

            convert.ToInt32(null);

            Console.ReadLine();
        }
    }

    public class A
    {
        public string name;

        public A()
        {
            Console.WriteLine("run constructor A");
        }

        public A(string _name)
        {
            name = _name;
            Console.WriteLine("run constructor A and have name{0}", name);
        }

        public virtual void M()
        {
            Console.WriteLine("run method on class A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("run constructor B");
        }

        public override void M()
        {
            Console.WriteLine("run method on class B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("run constructor C");
        }

        public new void M()
        {
            Console.WriteLine("run method on class C");
        }
    }
    
}
