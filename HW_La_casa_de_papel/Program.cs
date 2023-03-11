using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_La_casa_de_papel
{
    public class Human
   {
        string _city;
        string _name;

        public Human(string name)
        {
        }

        public Human(string city, string name)
        {
            _city = city;
            _name = name;

        }
        public void Show()
        {
            WriteLine($" Город: {_city} - Имя:{_name} ");

        }

   }
    public class Characters : Human 
    {
        string _position;
        public Characters(string city, string name, string position) : base(city, name)
        {
            position = _position ;

        }
        public new void Show()
        {
            base.Show();
            WriteLine($"Позиция в банде:{_position}$");
        }


        class Family:Characters
        {
           
            int _NumberOfMembers;
            string _members;

                public Family (string city, string name, string position, int NumberOfMembers, string members) : base(city, name, position)
            {
                _NumberOfMembers = NumberOfMembers;
                _members = members;

            }

            public new void Show_Family()
            {
                base.Show();
                WriteLine($"Количество членов семьи в криминале и кто: {_NumberOfMembers},  {_members}");

            }
        }

        class Fake: Characters
        {
            DateTime _dateOfPrison;
            string _ActSections;
                 public Fake(string city, string name, string position, int NumberOfMembers, string members, DateTime dateOfPrison, string ActSections ) : base(city, name, position)
                  {
            _dateOfPrison = dateOfPrison;
            _ActSections = ActSections;

                  }
            public new void Show_Fake()
            {
                base.Show();
                WriteLine($"Дата выхода из тюрьмы: {_dateOfPrison}\n Статья УК: {_ActSections}");

            }
        }

        class Police : Characters
        {
            string _side;
            string _post;
            public Police(string city,string name, string position, string side, string post) : base(city,name, position)
            {
                _side = side;
                _post = post;

            }

            public new void Show_Police()
            {
                base.Show();
                WriteLine($"Сторона: {_side}\n Должность: {_post}");

            }

        }
        class Death_or_Alive : Characters
        {
            int _age;
            string _final;

            public Death_or_Alive(string city, string name, string position, int age, string final) : base(city, name,position)
            {
                _age = age;
                _final = final;
            }
            public void Show_Life()
            {
                base.Show();
                WriteLine($"Возраст: {_age}, Жив? {_final}");

            }
        }


    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            Characters fake1 = new fake("Сантьяго", "Лопез", "Подставной Водитель", (2026, 03, 21), "228 УК РФ");

            Characters[] character =
            {
                fake1,
                new Characters("-","Профессор", "Стратег"),
                new Family ("Берлин", "Педро", " Исполняющий стратег", "2 ", "Брат и жена"),
                new Police ("Лиссабон","Ракель","Тактик и исполнитель"," За грабителей","Следователь"),
                new Death_or_alive("Найроби","Альба","Исполнитель-грабитель","26","Умерла во время перестрелки")

            };

            foreach (Characters item in character)
            {
                WriteLine(item);
                item.Show();
                

            }

        }
    }
}
