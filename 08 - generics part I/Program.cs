/*

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Generics{
    class Program{
        static void Main(string[] args){
          ILogger logger = new FileLogger("MyLogger.txt");
          BankAccount firstUserAccount = new BankAccount("Ana",232,logger);
          BankAccount secondUserAccount = new BankAccount("lazaro",230,logger);
        
        
          List <BankAccount> accounts = new List<BankAccount>{
            firstUserAccount,
            secondUserAccount
          };

          foreach (BankAccount account in accounts){
             Console.WriteLine(account.Balance);
          }
        }
    }          
}  


class FileLogger :ILogger {
    private readonly string filePath;
    
    public FileLogger(string filePath){
        this.filePath = filePath;
    }

    public void Log(string message){
        File.AppendAllText(filePath,$"{message} {Environment.NewLine}");
    }    
}

class ConsoleLogger:ILogger{}


//declarection of public contract
interface ILogger{   
    void Log(string message){
        Console.WriteLine($"Logger: {message} ");
    }
}


class BankAccount{
    //Type definition: Attribute and behaviors that an object
    //will have
    private readonly ILogger logger;
    private string name;
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
        this.logger = logger;
    }

    public void Deposit(decimal amount){
        if(amount<=0) {
            logger.Log("Deposit less or equal to zero not allowed!");
            return;
        }
        Balance+= amount;
    }

}

*/