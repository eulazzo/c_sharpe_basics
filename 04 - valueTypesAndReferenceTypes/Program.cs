/*
using System;

namespace Loop{
    class Program{
        static void Main(string[] args){
            //Output should be 100 cuz of reference value. firstNumber and secondNumber point to the same object.
            Number firstNumber = new Number();
            firstNumber.x = 20;

            Number secondNumber = firstNumber;
            secondNumber.x = 100;

            Console.WriteLine(firstNumber.x);

            //the value has directly been assigned to the variable, in that case i = 10;
            //They reference is diferent. 

            int i = 10;
            int j = i;
            j = 300;

            Console.WriteLine(i);

            //Types of nullable values
            int? x = null;
            if(x==null)
              Console.WriteLine("null");
        }   
    }
}


class Number{
    public int x;
}

*/