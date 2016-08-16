using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace ConsoleApplication1
{
    //class Program
    //{
    //    //private static IRepository repository = new Repository();

    //    static void Main(string[] args)
    //    {

    //        Database.SetInitializer(
    //    new DropCreateDatabaseIfModelChanges<CodeFirst>());

    //        var Cities = new Repository().Cities.ToList();

    //        Console.WriteLine("run application");

    //        foreach (var city in Cities)
    //        {
    //            Console.WriteLine(city.Name);
    //        }

    //        Console.WriteLine("stop application");
    //        Console.ReadLine();
    //    }
    //}
}

namespace CompanyA
{
    public class Phone
    {
        public void Dial()
        {
            Console.WriteLine("Phone.Dial");
            EstablishConnection();
            // Выполнить действия по набору телефонного номера
        }
        protected virtual void EstablishConnection()
        {
            Console.WriteLine("Phone.EstablishConnection");
            // Выполнить действия по установлению соединения
        }
    }
}


namespace CompanyB
{
    public class BetterPhone : CompanyA.Phone
    {
        public void Dial()
        {
            Console.WriteLine("BetterPhone.Dial");
            EstablishConnection();
            base.Dial();
        }
        protected override void EstablishConnection()
        {
            Console.WriteLine("BetterPhone.EstablishConnection");
            // Выполнить действия по набору телефонного номера
        }
    }
}



public sealed class Program
{


    public static void Main()
    {
        //CompanyB.BetterPhone phone = new CompanyB.BetterPhone();

        //phone.Dial();



        //List<dynamic> dList = new List<dynamic>();

        //Dictionary<dynamic, dynamic> dDic = new Dictionary<dynamic, dynamic>();


        //dList.Add("1");
        //dList.Add(100);

        //dDic.Add(2, "2");
        //dDic.Add("3",3);

        //foreach (var item in dList)
        //{
        //    Console.WriteLine(item.ToString());


        //}

        //dDic.Add(typeof(CompanyA.Phone), typeof(CompanyB.BetterPhone));

        //foreach (var key in dDic.Keys)
        //{
        //    Console.WriteLine("key:" + key.ToString());
        //    Console.WriteLine("value:" + dDic[key].ToString());
        //}

        //Console.WriteLine(dDic[2] is String ? "это строка" : "это не строка");

        //Console.WriteLine(dDic["3"] is String ? "это строка" : "это не строка");

        /////////////////////////////////////////

        //string a = null;
        //string b = null;
        //string c = null;

        //a = b;
        //b = c;
        //c = a;

        //a = "1";

        //Console.WriteLine("c:" + c.ToString());

        //var x = new { Items = new List<int> { 1, 2, 3 }.GetEnumerator() };
        //while (x.Items.MoveNext())
        //{
        //    Console.WriteLine(x.Items.Current);
        //}

        /////////////////////////////////

        //var x = new { Items = new List<int> { 1, 2, 3 } };

        //foreach (var item in x.Items)
        //{
        //    Console.WriteLine(item);
        //}

        string a = null;

        var mm = new MailManager();

        var fax = new Fax(mm);



        mm.SimulateNewMail("from", "to", "subject");

        object o = (object)new ex("2");

        var e = new ex("2");

        object o3 = new ex("2");

        

        int i = 3;

        dynamic o4 = new ex("2");

        i.ToString();
        i.GetHashCode();
        i.GetType();

        var ex2 = new ex2("2").GetHashCode();


    var o2 = o;


        var str = "1";
        var integer = 1;

        string s1 = 1.ToString();

        int i2 = int.Parse("10");

        var i3 = Convert.ToBoolean(123);

        Console.WriteLine("HashCodeTest" + "111".GetHashCode());
        Console.WriteLine("HashCodeTest" + (111.ToString()).GetHashCode());

        Console.WriteLine("o3" + o3.GetType());


        Console.ReadLine();
    }

    public static T Min<T>(T o1, T o2) where T : IComparable<T>
    {
        if (o1.CompareTo(o2) < 0) return o1;
        return o2;
    }

    

    private static void CallMin()
    {
        string o1 = "Jeff", o2 = "Richter";
        var oMin = Min(o1, o2); // Ошибка CS0311
    }


    public class ex
    {
        public string str;

        public ex(string s)
        {
            str = s;
        }

        public sealed override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class ex2 : ex
    {
        public ex2(string s) : base(s)
        {
        }
    }








    // Этап 1. Определение типа для хранения информации,
    // которая передается получателям уведомления о событии

    internal class NewMailEventArgs : EventArgs
    {
        private readonly String m_from;
        private readonly String m_to;
        private readonly String m_subject;
        public NewMailEventArgs(String from, String to, String subject)
        {
            m_from = from;
            m_to = to;
            m_subject = subject;
        }
        public String From { get { return m_from; } }
        public String To { get { return m_to; } }
        public String Subject { get { return m_subject; } }
    }

    internal class MailManager
    {
        // Этап 2. Определение члена-события
        public event EventHandler<NewMailEventArgs> NewMail;

        // Этап 3. Определение метода, ответственного за уведомление 
        // зарегистрированных объектов о событии
        // Если этот класс изолированный, нужно сделать метод закрытым 
        // или невиртуальным
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            // Сохранить ссылку на делегата во временной переменной
            // для обеспечения безопасности потоков
            EventHandler<NewMailEventArgs> temp = Volatile.Read(ref NewMail);
            // Если есть объекты, зарегистрированные для получения
            // уведомления о событии, уведомляем их
            if (temp != null) temp(this, e);
        }

        // Этап 4. Определение метода, преобразующего входную
        // информацию в желаемое событие
        public void SimulateNewMail(String from, String to, String subject)
        {
            // Создать объект для хранения информации, которую
            // нужно передать получателям уведомления
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            // Вызвать виртуальный метод, уведомляющий объект о событии 
            // Если ни один из производных типов не переопределяет этот метод, 
            // объект уведомит всех зарегистрированных получателей уведомления
            OnNewMail(e);
        }
    }

    internal sealed class Fax
    {
        // Передаем конструктору объект MailManager
        public Fax(MailManager mm)
        {
            // Создаем экземпляр делегата EventHandler<NewMailEventArgs>, 
            // ссылающийся на метод обратного вызова FaxMsg
            // Регистрируем обратный вызов для события NewMail объекта MailManager
            mm.NewMail += FaxMsg;
        }
            // MailManager вызывает этот метод для уведомления 
            // объекта Fax о прибытии нового почтового сообщения
        private void FaxMsg(Object sender, NewMailEventArgs e)
        {
            // 'sender' используется для взаимодействия с объектом MailManager, 
            // если потребуется передать ему какую-то информацию
            // 'e' определяет дополнительную информацию о событии, 
            // которую пожелает предоставить MailManager
            // Обычно расположенный здесь код отправляет сообщение по факсу
            // Тестовая реализация выводит информацию на консоль
            Console.WriteLine("Faxing mail message:");
            Console.WriteLine(" From={0}, To={1}, Subject={2}",
            e.From, e.To, e.Subject);
        }
        // Этот метод может выполняться для отмены регистрации объекта Fax 
        // в качестве получтеля уведомлений о событии NewMail 
        public void Unregister(MailManager mm)
        {
            // Отменить регистрацию на уведомление о событии NewMail объекта 
            mm.NewMail -= FaxMsg;
        }

    }


}





