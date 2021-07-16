using System;
namespace samplesima
{
    public class Bat : Animal
    {
        public Bat()
        {
        }
        public string Fly()
        {
            return "날다";
        }
        public override string Eat()
        {
            return "2끼";
        }     
        
    }
}

// override : 재정의
// vitual : 가상함수  
