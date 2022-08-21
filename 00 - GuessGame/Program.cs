/*

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace GuessGame{
    class Program{
        static void Main(string[] args){
           string secretWord = "code";
           string myGuessTry =  "";
           int guessCount = 0;
           int guessLimit = 3;
           bool outOfGuesses = false;

           while(secretWord!=myGuessTry && !outOfGuesses){
              if(guessCount<guessLimit){
                 Console.WriteLine("Try to guess my secret word: ");
                 myGuessTry = Console.ReadLine();
                 guessCount++;
              }else {;
                outOfGuesses = true;
              }
           } 

           if(secretWord==myGuessTry){
             Console.WriteLine("Your Win!");
           }else{
             Console.WriteLine("Ops! It's seems that your guesses chances has ended!");
           }
        }
    } 
}

 


 
 

*/