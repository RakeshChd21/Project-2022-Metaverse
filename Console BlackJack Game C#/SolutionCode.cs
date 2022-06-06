using System;
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Started with BlackJack Game
            Console.WriteLine("Hello Buddy 😎\nWelCome to Single-Player BlackJack Game Version 2.O");
            
            int playerCardVal=0;
            int dealerCardVal=0;
            
            Random random = new Random();

            playerCardVal += random.Next(1, 12); //Random number from 1 - 11
            playerCardVal += random.Next(1, 12); //Random number from 1 - 11

            if (playerCardVal > 21){
                playerCardVal -= 10;
            }

            dealerCardVal += random.Next(1, 12);
            dealerCardVal += random.Next(1, 12);

            if (dealerCardVal > 21){
                dealerCardVal -= 10;
            }

            //Player Turn
            while (true){
                if(playerCardVal == 21){
                    Console.WriteLine("You are at 21\n😎😎😎"); // 21 is highest score in this game. 
                    break;
                }
                Console.WriteLine("Your Card Value: " + playerCardVal.ToString() + "\nHit?");
                string answer = Console.ReadLine();

                if(answer == "y"){
                    playerCardVal += random.Next(1, 12);
                    if (playerCardVal > 21){
                        Console.WriteLine("\nYou Busted!\n😭😭😭");
                        break;
                    }
                    else{
                        continue;
                    }
                }
                else if( answer == "n"){
                    break;
                }
                else{
                    Console.WriteLine("Incorrect Response, Try Again!");
                    continue;
                }
            }

            //Dealer Turn
            Console.WriteLine("Your card value: " + playerCardVal.ToString());
            if (playerCardVal <= 21){
                //Player has not busted
                while (dealerCardVal < 21 && dealerCardVal < playerCardVal){
                    dealerCardVal += random.Next(1, 12);
                }

                //Check for Winner
                if(playerCardVal == dealerCardVal){
                    Console.WriteLine("You And Dealer Has Tied\n🥲🥲🥲");
                }
                else if(playerCardVal < dealerCardVal && dealerCardVal <= 21){
                    Console.WriteLine("Dealer Has Won\n😭😭😭");
                }
                else if(dealerCardVal > 21){
                    Console.WriteLine("Dealer Has Busted, You Have Won\n😀😀😀"); 
                }
                else if(dealerCardVal == 21){
                    Console.WriteLine("Dealer Has Won!\n😭😭😭");
                }
            }
            else {
                Console.WriteLine("Dealer Has Won, You Have Busted!");
            }
            Console.WriteLine("Dealer Value: " + dealerCardVal.ToString());
            Console.ReadLine();
        }
    }
}
