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
        private readonly string _age;
       
        public string Age {
            get { return _age; } 
        }


        public Cat(CatColour col, string age)
        {
            _age = age;
            Colour = col;
            _health = 5;
        }
        public CatColour Colour { set; get; }
        
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ваш питомец сконфужен, он привык к своему прежнему имени");
                }
            }

            get { return _name; }
        }

        public string CurrentColour
        {
            get
            {
                if (_health >= 5)
                {
                    return Colour.HealthColour;
                }
                else
                {
                    return Colour.SickColour;
                }
            
           }
        }

        public int Feed()
        {
            _health = _health + 1;
            return _health;
        }

        public int Punish()
        {
           _health = _health - 1;
           return _health;
        }

       

    }
}
