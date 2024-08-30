using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?  "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "Хорошего настроения";

            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponses(p);
            return View("Hello", p);
        }

        public ViewResult OutputData(Person p) 
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }

        private static PersonRepository db = new PersonRepository();


        /*public string Index(string hel)
        {
            *//*int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
            return Greeting;

            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;*/
        /*string res = ExeEnum();*/

        /*string res = ExeStruct();
        return res;*//*

        //упражнение 2
        *//*string res = StudyCsharp.SetStatus(3);
        return res;*/

        /*string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));
        return res;*/

        /*string res = StudyCsharp.GetFunction(0, 9);
        return res;*/

        /*string res = ExeFactorial(1);
        return res;*//*

        //упражнение 3
        *//*string res = ExeTriangle();
        return res;*//*

        //упражнение 4
        *//*string res = ExePolim();
        return res;*//*

        //упражение 5
        *//*string res = ExeCollection();*//*
        string res = ExeCollectionTr();
        return res;

    }*/

        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;

            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            string res = String.Format("информация о банковском счёте: {0}", 
        goldBankAccount);
            
            return res;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
                return String.Format("Факториал числа {0} равен {1} ", x, f);
            else
                return "Невозможно вычислить факториал";
        }

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }

        public string ExeCircle()
        {
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна: {1:0.##}", cir1.Name, cir1.Area);
            return sq;
        }

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder();
            Shape[] sh =
                        {
                            new Triangle(1,2,3),
                            new Circle(5),
                            new Triangle(5,6,7)
                        };
            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }

            return str.ToString();
        }

        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>()
                    {
                        new Circle(12),
                        new Circle(5),
                        new Circle(15),
                        new Circle(6),
                        new Circle(7)
                    };
            cirs.Add(new Circle(8));
            cirs.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура{0}", item.Name + "<p>");
            }

            return str.ToString();
        }

        public string ExeCollectionTr()
        {
            List<Triangle> tr = new List<Triangle>()
                    {
                        new Triangle(12, 10, 4),
                        new Triangle(5, 5, 4),
                        new Triangle(15, 2, 4),
                        new Triangle(6, 9, 1),
                        new Triangle(7, 1, 1)
                    };
            tr.Add(new Triangle(8, 5, 4));
            tr.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in tr)
            {
                str.AppendFormat("Это фигура{0}", item.Name + "<p>");
            }

            return str.ToString();
        }

    }
}