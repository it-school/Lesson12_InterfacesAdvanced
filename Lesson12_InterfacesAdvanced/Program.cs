using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IParent
    {
        void ParentMethod(params Object[] a);
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
        public void ParentMethod(params Object[] a)
        {
            Console.WriteLine("Это метод родителя!" + a.ToString());
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

    enum UI : long { Name, Family, ShortName = 5, Age, Sex }


    class Program
    {

        static void Main(string[] args)
        {
            UI user1;
            for (user1 = UI.Name; user1 <= UI.Sex; user1++)
                Console.WriteLine("Элемент: \"{0}\", значение {1}", user1, (int)user1);

            Console.ReadLine();

            Console.WriteLine("Объект класса вызывает методы трех интерфейсов!");

            Interfaces.Pars ct = new Interfaces.Pars();
            ct.ParentMethod("rrr");
            ct.Son1Method();
            ct.Son2Method();
            Console.WriteLine("Интерфейсный объект 1 вызывает свои методы!");

            Interfaces.IParent ip = (IParent)ct;
            ip.ParentMethod();
            Console.WriteLine("Интерфейсный объект 2 вызывает свои методы!");

            Interfaces.ISon1 ip1 = (ISon1)ct;
            ip1.ParentMethod();
            ip1.Son1Method();
            Console.WriteLine("Интерфейсный объект 3 вызывает свои методы!");

            Interfaces.ISon2 ip2 = (ISon2)ct;
            ip2.ParentMethod();
            ip2.Son2Method();
        }
    }
}