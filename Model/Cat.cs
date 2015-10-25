using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private int _health;
        private string _curColour;
        public Cat(string age, CatColour col)
        {
            Age = age;
            Colour = col;
            _health = 5;
        }
        public CatColour Colour { set; get; }
        

      

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
                else Console.WriteLine("Ваш питомец сконфужен, он привык к своему прежнему имени");
            }
            get { return _name; }
        }

        public object CurrentColour { get; set; }

        public readonly string Age;

        public string CheckCurColour()
        {
            if(_health >= 5)
                _curColour= Colour.HealthColour;
            else _curColour= Colour.SickColour;
            return _curColour;
        }

        public int Feed()
        {
            _health = _health + 1;
            return _health;
        }
        public int Punish()
        {
            if (_health > 0)
                _health = _health - 1;
            else if(_health==0)
                Console.WriteLine("Ваш питомец очень болен. Прекратите его наказывать");
            return _health;
        }

       

    }
}
