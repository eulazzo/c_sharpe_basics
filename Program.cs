using System;

namespace Loop{
    class Program{
        static void Main(string[] args){
            string[] names = {"joao","lorena","jhon Doe"};  
            
            foreach (var name in names){   
                Console.WriteLine(name);
            }

            for (var i = 0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }

            if(string.Equals(names[0], "joao", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("The are equals");
            }
        }
    }
}

