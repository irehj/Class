//using System;

//namespace samplesima
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calc calc = new Calc(); //생성자 - 생성할때 씀 calc 
//            Console.WriteLine(calc.Plus(2, 7));
//        }
//    }
//}

using System;

namespace samplesima
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); //생성자 - 생성할때 씀 calc 
            Console.WriteLine(animal.Breath());
            Console.WriteLine(animal.Eat());
            Console.WriteLine(animal.Sleep());
            Console.WriteLine(animal.Die());

            //Bat bat = new Bat();

            //Console.WriteLine(bat.Fly());
            //Console.WriteLine(bat.Eat());

            Animal bat = new Bat();
            Console.WriteLine(((Bat)bat).Fly());
            Console.WriteLine(bat.Eat());
        }
    }
}

//캡슐화 - 정보은닉
//상속 : 
//다형성 : 
//추상화 