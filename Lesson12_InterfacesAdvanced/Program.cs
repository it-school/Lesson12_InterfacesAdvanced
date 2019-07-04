using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IParent
    {
        void ParentMethod(params string[] a);
    }

    public interface ISon1 : IParent
    {
        void Son1Method();
    }

    public interface ISon2 : IParent
    {
        void Son2Method();
    }

    public class Pars : ISon1, ISon2
    {
        public void info()
        {
            Console.WriteLine("Class method");
        }

        public void ParentMethod(params string[] a)
        {
            string s = "";
            foreach (string item in a)
            {
                s += item.ToString() + " ";
            }
            Console.WriteLine("Это метод родителя: " + s);
            info();
        }
        public void Son1Method()
        {
            Console.WriteLine("Это метод старшего сына!");
        }
        public void Son2Method()
        {
            Console.WriteLine("Это метод младшего сына!");
        }
    }

    enum UI : long { Name, Family, ShortName = 5, Age=8, Sex }


    class Program
    {

        static void Main(string[] args)
        {
            UI user1;
            for (user1 = UI.Name; user1 <= UI.Sex; user1++)
                Console.WriteLine("Элемент: \"{0}\", значение {1}", user1, (int)user1);

            Console.ReadLine();

            Console.WriteLine("Объект экземпляр класса вызывает методы трех интерфейсов:");
            Pars ct = new Pars();
            ct.ParentMethod("Иванов", "Иван", "Сидорович");
            ct.Son1Method();
            ct.Son2Method();
            ct.info();
            Console.WriteLine();

            Console.WriteLine("Интерфейсный объект 1 вызывает свои методы!");
            IParent ip = (IParent)ct;
            ip.ParentMethod("Иванов");
            
            //ip.Son1Method();
            //ip.Son2Method();
            Console.WriteLine();

            Console.WriteLine("Интерфейсный объект 2 вызывает свои методы!");
            ISon1 ip1 = (ISon1)ct;
            ip1.ParentMethod("Иванов", "Сергей", "Иванович");
            ip1.Son1Method();
            //ip1.Son2Method();
            Console.WriteLine();

            Console.WriteLine("Интерфейсный объект 3 вызывает свои методы!");
            Interfaces.ISon2 ip2 = (ISon2)ct;
            ip2.ParentMethod("Иванов", "Николай", "Иванович");
            //ip2.Son1Method();
            ip2.Son2Method();
            Console.WriteLine();
        }
    }
}