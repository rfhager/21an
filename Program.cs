using System;
using System.Threading;
namespace _21an
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Psuedo code
            //Skapa en variabel för senaste vinnare (ingen har ännu spelat detta programmet? eller tomt?)

            //Skapa en do loop för att användaren visa menyn och låta användaren välja

            //Skapa menyn (en switchcase sats)

            //1. skapa en randomvariabel, deklarera variabler för att spara användaren och datorns
            //poäng, användarens poängvariabel = random.Next(1, 10) detta upprepas +=, detta
            //repeteras för datorn

            //while (användarens poäng < 21) sedan if, om ja gör dra ett kort, om nej gå vidare
            //(break), else fel input
            //För datorn så skapar vi med en while loop
            //(datornsPoäng < 21 && datornsPoäng < användarensPoäng) dra ett kort

            //Jämför vem som vann med if
            //(användarensPoäng <= 21 && användarensPoäng > datornsPoäng)
            //{Be användaren skriva in sitt namn, lagra i senaste vinnaren} samt else
            //Console.Clear();

            //2. 
            //Console.Clear();

            //3.

            //4. Environment.Exit(0);
            #endregion

            string lastWinner = "Ingen har utmanat datorn ännu i detta spelet!";
            Console.WriteLine("Välkommen till 21:an!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa spelets regler");
                Console.WriteLine("4. Avsluta programmet");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Random randomGenerator = new Random();
                        int userScore = randomGenerator.Next(1, 11) + randomGenerator.Next(1, 11);
                        int computerScore = randomGenerator.Next(1, 11) + randomGenerator.Next(1, 11);
                        int newCard;

                        Console.WriteLine();
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        Console.WriteLine("Din poäng: " + userScore);
                        Console.WriteLine("Datorns poäng: " + computerScore);
                        Console.WriteLine();

                        while (userScore < 21)
                        {
                            Console.WriteLine("Vill du ha ett nytt kort? (j/n)");
                            string userReply = Console.ReadLine().ToLower();

                            if (userReply == "j")
                            {
                                newCard = randomGenerator.Next(1, 11);
                                Console.WriteLine("Ditt nya kort är värt " + newCard + " poäng");
                                userScore += newCard;
                                Console.WriteLine("Din totalpoäng är " + userScore);
                                Console.WriteLine("Din poäng: " + userScore);
                                Console.WriteLine("Datorns poäng: " + computerScore);
                                Console.WriteLine();

                            }
                            else if (userReply == "n")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Du har inte valt ett giltligt alternativ.");
                            }
                        }
                        if (userScore > 21)
                        {
                            Console.WriteLine("Du har förlorat, datorn vann!");
                            lastWinner = "Datorn";
                            Console.WriteLine();
                            Console.WriteLine("Klicka på valfri knapp för att gå tillbaka till menyn.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        while (computerScore < 21 && computerScore < userScore)
                        {
                            newCard = randomGenerator.Next(1, 11);
                            Console.WriteLine("Datorn drog ett kort värt " + newCard + " poäng");
                            computerScore += newCard;
                            Console.WriteLine("Din poäng: " + userScore);
                            Console.WriteLine("Datorns poäng: " + computerScore);
                            Console.WriteLine();
                            Thread.Sleep(1500);
                        }
                        if (computerScore > 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv in ditt namn:");
                            lastWinner = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Klicka på valfri knapp för att gå tillbaka till menyn.");
                            Console.ReadKey();
                            Console.Clear();
                        } 
                        else
                        {
                            lastWinner = "Datorn";
                            Console.WriteLine("Du har förlorat, datorn vann!");
                            Console.WriteLine();
                            Console.WriteLine("Klicka på valfri knapp för att gå tillbaka till menyn.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break; 
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Den senaste vinnaren är: " + lastWinner);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Klicka på valfri knapp för att gå tillbaka till menyn.");
                        Console.ReadKey();
                        Console.Clear();
                        break; 
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("I 21:an kommer du att spela mot datorn och försöka tvinga datorn att få över 21 poäng.");
                        Console.WriteLine("Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng.");
                        Console.WriteLine("När spelet börjar dras två kort till både dig och datorn.");
                        Console.WriteLine("Därefter får du dra hur många kort som du vill tills du är nöjd med din totalpoäng, " +
                            "\ndu vill komma så nära 21 som möjligt utan att få mer än 21 poäng.");
                        Console.WriteLine("När du inte vill dra fler kort så kommer datorn att dra kort tills den har mer eller lika många poäng som dig.");
                        Console.WriteLine("Du vinner om datorn får mer än totalt 21 poäng när den håller på att dra kort.");
                        Console.WriteLine("Datorn vinner om den har mer poäng än dig när spelet är slut så länge som datorn inte har mer än 21 poäng.");
                        Console.WriteLine("Om det skullebli lika i poäng så vinner datorn. Om du får mer än 21 poäng när du drar kort så har du förlorat.");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Programmet kommer nu att avslutas.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Du har inte valt ett giltligt alternativ.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}