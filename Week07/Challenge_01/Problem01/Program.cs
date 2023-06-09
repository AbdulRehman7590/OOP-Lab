using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01.BL;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Press one to play game.");
                Console.WriteLine("Press two to exit.");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    bool gamerunning = true;
                    int score = 0;
                    Deck obj = new Deck();
                    obj.Shuffle();
                    Card card1 = obj.DealCard();
                    while (gamerunning)
                    {
                        int remain_check = obj.LeftCards;
                        Card card2 = obj.DealCard();
                        Console.WriteLine("*******");
                        Console.WriteLine(card1.FullCard);
                        Console.WriteLine("*******");
                        Console.WriteLine("Remaining card : " + remain_check);
                        Console.WriteLine("Enter 1 if next card is higher. ");
                        Console.WriteLine("Enter 2 if next card is lower. ");
                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (card_check == 1)
                        {
                            if (card2.Value >= card1.Value)
                            {
                                score++;
                                card1 = card2;

                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("Sorry you lost the game ");
                                Console.WriteLine("The card was : " + card2.FullCard);
                                Console.WriteLine("Your score is  : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (card_check == 2)
                        {
                            if (card2.Value < card1.Value)
                            {
                                score++;
                                card1 = card2;

                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("Sorry you lost the game ");
                                Console.WriteLine("The card was : " + card2.FullCard);
                                Console.WriteLine("Your score is  : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (obj.LeftCards == 0 && card2 == null)
                        {
                            gamerunning = false;
                            Console.WriteLine("Congrats! You have scored maximum");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        }

                    }

                }
            }
            while (option != 2);
        }
    }
}
