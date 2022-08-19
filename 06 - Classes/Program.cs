/*

using System;

namespace Classes{
    class Program{
        static void Main(string[] args){
          BankAccount firstUserAccount = new BankAccount("Ana",232);
          BankAccount secondUserAccount = new BankAccount("lazaro",230);
        

          firstUserAccount.Deposit(232);

          Console.WriteLine(firstUserAccount.Balance);
          
         

        }
    }          
}   



class BankAccount{
    //Type definition: Attribute and behaviors that an object
    //will have
    private string name;
    public decimal Balance{ 
        get;private set; 
    }
    
    
    public BankAccount (string name,decimal balance){
        if(string.IsNullOrEmpty(name)){
            throw new ArgumentException("Invalid name entry!",nameof(name));
        }
        if(balance <= 0){
            throw new Exception("Balance must be positive!");
        }
        this.name = name;
        Balance = balance;
    }

    public void Deposit(decimal amount){
        if(amount<=0) throw new Exception("Deposit less or equal to zero not allowed!");
        Balance+= amount;
    }
*/

}




 