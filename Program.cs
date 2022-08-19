using System;

namespace Classes{
    class Program{
        static void Main(string[] args){
          BankAccount firstUserAccount = new BankAccount("Ana",232);
          BankAccount secondUserAccount = new BankAccount("lazaro",230);
        

          firstUserAccount.Deposit(-232);

          Console.WriteLine(firstUserAccount.Balance);
          
         

        }
    }          
}   

class ConsoleLogger:ILogger{
    public void Log(string message){
        Console.WriteLine($"Logger: {message} ");
    }
}


//declarection of public contract
interface ILogger{   
    void Log(string message)
}


class BankAccount{
    //Type definition: Attribute and behaviors that an object
    //will have
    private string name;
    private readonly ILogger logger;
    public decimal Balance{ 
        get;private set; 
    }
    
    
    public BankAccount (string name,decimal balance,ILogger logger){
        if(string.IsNullOrEmpty(name)){
            throw new ArgumentException("Invalid name entry!",nameof(name));
        }
        if(balance <= 0){
            throw new Exception("Balance must be positive!");
        }
        this.name = name;
        Balance = balance;
        this.logger = logger
    }

    public void Deposit(decimal amount){
        if(amount<=0) {
            logger.log("Deposit less or equal to zero not allowed!");
            return
        }
        Balance+= amount;
    }

}