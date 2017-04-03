using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit;

            while (true)
            {
                Console.WriteLine("Hello and Welcome to Elfin Fortunes! Our Local Oracle has agreed to share her \nknowledge of the furute with us everyday elves for a limited time!");

                Console.Write("\nReady? Press \"Enter\" now!! \nIf at any time you decide not to tempt fate, simply type \"Quit\" and we won't \npass along your information to the Oracle!");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

                //First Name Please! 

                Console.Write("\nWhat is your first name? : ");
                string firstName = Console.ReadLine();
                firstName = firstName.ToLower();
                if (firstName.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

                //Respond
                Console.Write("Excellent! We're off to a great start! ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

                //Last Name...?

                Console.Write("\nWhat is your last name? : ");
                string lastName = Console.ReadLine();
                lastName = lastName.ToLower();
                if (lastName.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

                //Respond
                Console.Write("Thank you! Now on to the important information! ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }


                //Age of User

                Console.Write("\nHow old are you? \nPlease enter age as a number! Ex: 25 : ");

                bool trueF;
                int age;
                int two;
                two = 2;
                trueF = int.TryParse(Console.ReadLine(), out age);

                while (trueF == false)
                {
                    Console.Write("\nSorry, but that's not a number! I know we live very long lives so one's age can be differcult to remember, but Please, try again! \nHow old are you? : ");
                    trueF = int.TryParse(Console.ReadLine(), out age);
                }
                if (age % two == 0)
                {
                    Console.WriteLine("\n...Interesting!");
                }
                else if (age % 2 != 0)
                {
                    Console.WriteLine("\nVery insiteful indeed!");
                }


                //Respond
                Console.Write("\nMoving right along... ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }


                //Birth Month = 
                Console.Write("\nWhat is your Birth Month? \n-NOTE: Please enter birth month as a number, 1-12! Ex: May=5 : ");

                bool enter;
                int bMonth;
                enter = int.TryParse(Console.ReadLine(), out bMonth);

                if (enter == false)
                {
                    Console.WriteLine("\n...You do realize that the Oracle is a messenger of the gods right...?");
                }
                if (enter == true)
                {
                    if (bMonth >= 1 && bMonth <= 4)
                    {
                        Console.WriteLine("\nAh, the winter months...");
                    }
                    else if (bMonth >= 5 && bMonth <= 8)
                    {
                        Console.WriteLine("\nI do love Spring and Summer!");
                    }
                    else if (bMonth >= 9 && bMonth <= 12)
                    {
                        Console.WriteLine("\nHoliday seasons are wonderful!");
                    }
                    else
                    {
                        Console.WriteLine("\n...You do realize that the Oracle is a messenger of the gods right...?");
                    }
                }


                //Respond
                Console.Write("\nNow for something more prismatic! ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }


                //ROYGBIV FUN!
                Console.Write("\nWhat is your favorite ROYGBIV color? \n-NOTE: Please type \"Help\" to view a list of these colors if needed : ");
                string color = (Console.ReadLine());
                color = color.ToLower();

                while (color != "red" && color != "orange" && color != "yellow" && color != "green" && color != "blue" && color != "indigo" && color != "violet")
                {
                    if (color == "help")
                    {
                        Console.Write("\nROYGBIV colors are: Red, Orange, Yellow, Green, Blue, Indigo, and Violet! \nWhat is your favorite color? : ");
                        color = (Console.ReadLine());
                        color = color.ToLower();
                    }
                    else if(color == "quit")
                    {
                        Console.WriteLine("\nNobody likes a quitter...");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("I'm sorry, that's not an acceptable color! Please tenter a ROYGBIV color, \"help\", or \"quit\"");
                        color = (Console.ReadLine());
                        color = color.ToLower();
                    }

                }

                if (color == "red")
                {
                    Console.WriteLine("\n...\"Burning Red\"...");
                }
                else if (color == "orange")
                {
                    Console.WriteLine("\nLike autumn leaves!");
                }
                else if (color == "yellow")
                {
                    Console.WriteLine("\n...\"Walking on sunshine\"...");
                    //Katrina & The Waves 1983
                }
                else if (color == "green")
                {
                    Console.WriteLine("\nReminds me of Springtime!");
                }
                else if (color == "blue")
                {
                    Console.WriteLine("\n\"Da ba dee da ba die...\"");
                    //Eiffel 65 "I'm Blue"
                }
                else if (color == "indigo")
                {
                    Console.WriteLine("\nThe perfect balace between blue and purple!");
                }
                else if (color == "violet")
                {
                    Console.WriteLine("\nMy favorite flower!");
                }
                else if (color == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }
                

                //Respond
                Console.Write("\nJust one more! ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }


                //Siblings = ?
                Console.Write("\nFinal Question! How Many siblings do you have? : ");

                bool input;
                int sib;
                input = int.TryParse(Console.ReadLine(), out sib);


                if (input == false)
                {
                    Console.WriteLine("\n...You know, lying to the gods earthly medium could have negavtive repercussions on your future...");
                }
                if (input == true)
                {
                    if (sib == 0)
                    {
                        Console.WriteLine("\nLucky You!");
                    }

                    else if (sib == 1)
                    {
                        Console.WriteLine("\nI know your pain!");
                    }
                    else
                    {
                        Console.WriteLine("\n...I'm so sorry! ");
                    }
                }


                //Respond
                Console.Write("\nJust one moment! ");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }


                //Computing...!

                Console.WriteLine("\nOkay, that's all we need! If your ready for me to take these to the Oracle press\"Enter\" now! \nIf you'd rather be kept in suspense, this is your last chance to type \"Quit\"!");
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

               

                //Results are in! User:
                Console.WriteLine("\nGood News! The gods have spoken and the Oracle has revealed the results of your prophecy!");

                Console.Write("\n:" + firstName + " " + lastName + ", you will retire in: ");



                //years till retirement
                if (age % two == 0)
                {
                    Console.Write("\n1,000 years...a mere drop in the bucket to a young elf like yourself, with: ");
                }
                else if (age % 2 != 0)
                {
                    Console.Write("\n80 years...that's nothing to an elf, with: ");
                }


                //money in the bank...!

                if (enter == false)
                {
                    Console.Write("\n$0.00 in the bank...if only you had a birth month...! Your ");
                }
                if (enter == true)
                {
                    if (bMonth >= 1 && bMonth <= 4)
                    {
                        Console.Write("\n$1,500.00 in the bank. Your ");
                    }
                    else if (bMonth >= 5 && bMonth <= 8)
                    {
                        Console.Write("\n$12,000.00 in the bank. Your ");
                    }
                    else if (bMonth >= 9 && bMonth <= 12)
                    {
                        Console.Write("\n$5,000.00 in the bank. Your ");
                    }
                    else
                    {
                        Console.Write("\n$0.00 in the bank...if only you had a true birth month...! Your ");
                    }
                }


                //and a vacation home in lovely...

                if (input == false)
                {
                    Console.Write("\nlovely vacation home is a Drafty Tower located in the middle of the River Styx\n...if only the gods had saw fit to bless you with 0 or more siblings...and ");
                }
                if (input == true)
                {
                    if (sib == 0)
                    {
                        Console.Write("\nelegant vacation home is an Ice Palace located in the Norwegian Mountains and ");
                    }
                    else if (sib == 1)
                    {
                        Console.Write("\nVacation home is Casa Caracol, a beautiful Seashell home located in Isla Mujeres near the Caribbean Ocean and ");
                    }
                    else if (sib == 2)
                    {
                        Console.Write("\naUnique vacation home is located underwater at Atlantis, The Palm Hotel & Resort, and ");
                    }
                    else if (sib == 3)
                    {
                        Console.Write("\naVacation home is a Celtic Castle in the Scottish Highlands and ");
                    }
                    else
                    {
                        Console.Write("\naPeaceful vacation home is a Tree House located in the Costa Rican rainforest and ");
                    }
                }


                //mode of transportation!

                if (color == "red")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your vicious Hydra! ");
                }
                else if (color == "orange")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your elegant Unicorn!");
                }
                else if (color == "yellow")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your loyal White Siberian Tiger! ");
                }
                else if (color == "green")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your mystical Emerald Dragon! ");
                }
                else if (color == "blue")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your fierce War Elephant! ");
                }
                else if (color == "indigo")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your majestic Gryphon! ");
                }
                else if (color == "violet")
                {
                    Console.WriteLine("\nyour preferred mode of transportation is your clever Pink Dolphin! ");
                }


                //Ending Message!
                Console.Write("\nThank you for participating in this once in a lifetime oportunity! We hope you \nlearned...Wait A Minute...\nYou're not a real elf! \"Your an Elvish impersonator! \n...You sicken me, Deceitful One!!\"");
                //Quote = Veggie Tales "My Baby Elf"
                exit = (Console.ReadLine());
                if (exit.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    break;
                }

                break;
            }
           
        }
    }
}
