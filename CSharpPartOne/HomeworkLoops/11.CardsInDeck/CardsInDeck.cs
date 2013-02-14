/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
 * The cards should be printed with their English names. Use nested for loops and switch-case.*/
using System;

class CardsInDeck
{
    static void Main()
    {
        string[] cards = { "Deuce", "Three", "Four" ,"Five" ,"Six" ,"Seven" ,"Eight" ,"Nine" ,
                             "Ten" ,"Jack" ,"Queen" ,"King" ,"Ace" };
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        foreach (string card in cards)
        {           
            foreach (string suit in suits)
            {
                Console.WriteLine(card + " " + "of" + " " + suit);
            }
        }
    }
}

