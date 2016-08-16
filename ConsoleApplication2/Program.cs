using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            Encoding encodingUTF8 = Encoding.UTF8;

            var md5 = MD5.Create().Hash;

            var hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("string")));

            Convert.ToBase64String(new byte[] { });

            var b1 = (byte)1;
            var b2 = (byte)2;
            var b255 = (byte)255;

            Byte[] encodedBytes = encodingUTF8.GetBytes(s);
            String decodedString = encodingUTF8.GetString(encodedBytes);

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
