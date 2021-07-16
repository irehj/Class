using System;
namespace samplesima
{
    public class Calc
    {
        public Calc()
        {

        }
        public int Plus(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;

            return result;
        }

        public int Mius(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;

            return result;
        }
        public int Multi(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;

            return result;
        }
        public int Div(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;

            return result;
        }

    }

}