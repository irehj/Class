using System;
namespace samplesima
{
    public class Animal
    {
        public Animal()
        {

        }
        public string Breath()
        {
            return "숨";
        }
        public string Sleep()
        {
            return "8 hours";
        }
        public virtual string Eat()
        {
            return "3끼";
        }
        public string Die()
        {
            return "end";
        }
    }
}
