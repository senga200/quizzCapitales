namespace quizz
{
    class Program
    {
        static int count = 0;
        static string Question1()
        {
            string question = "";
            string reponse = "paris";

            while (question.Trim() == "")
            {
                Console.Write("Quelle est la capitale de la France : ");
                question = Console.ReadLine().ToLower();
                if (question == "")
                {
                    Console.WriteLine("entre ta réponse");
                }
                if (question == reponse)
                {
                    Console.WriteLine("bravo. Cette question était facile !");
                    count++;
                }
                else
                {
                    Console.WriteLine("dommage tu t'es trompé, la bonne réponse était : " + reponse);
                    break;
                }
            }
            return question;
        }

        static string Question2()
        {
            string question = "";
            string reponse = "vienne";

            while (question.Trim() == "")
            {
                Console.Write("Quelle est la capitale de l'Autriche : ");
                question = Console.ReadLine().ToLower();
                if (question == "")
                {
                    Console.WriteLine("entre ta réponse");
                }
                if (question == "vienne")
                {
                    Console.WriteLine("bravo !");
                    count++;
                }
                else
                {
                    Console.WriteLine("dommage tu t'es trompé, la bonne réponse était : " + reponse);
                    break;
                }
            }
            return question;
        }

        static string Question3()
        {
            string question = "";
            string reponse = "amsterdam";

            while (question.Trim() == "")
            {
                Console.Write("Quelle est la capitale des Pays Bas : ");
                question = Console.ReadLine().ToLower();
                if (question == "")
                {
                    Console.WriteLine("entre ta réponse");
                }
                if (question == reponse)
                {
                    Console.WriteLine("bravo, continue !");
                    count++;
                }
                else
                {
                    Console.WriteLine("dommage tu t'es trompé, la bonne réponse était : " + reponse);
                    break;
                }
            }
            return question;
        }

        static string Question4()
        {
            string question = "";
            string reponse = "berne";

            while (question.Trim() == "")
            {
                Console.Write("Quelle est la capitale de la Suisse : ");
                question = Console.ReadLine().ToLower();
                if (question == "")
                {
                    Console.WriteLine("entre ta réponse");
                }
                if (question == "berne")
                {
                    Console.WriteLine("bravo. Cette question n'était pas facile !");
                    count++;
                }
                else
                {
                    Console.WriteLine("dommage tu t'es trompé, la bonne réponse était : " + reponse);
                    break;
                }
            }
            return question;
        }

        static string Question5()
        {
            string question = "";
            string reponse = "budapest";

            while (question.Trim() == "")
            {
                Console.Write("Quelle est la capitale de la Hongrie : ");
                question = Console.ReadLine().ToLower();
                if (question == "")
                {
                    Console.WriteLine("entre ta réponse");
                }
                if (question == "budapest")
                {
                    Console.WriteLine("bravo. Continue !");
                    count++;
                }
                else
                {
                    Console.WriteLine("dommage tu t'es trompé, la bonne réponse était : " + reponse);
                    break;
                }
            }
            return question;
        }



        static void Main()
        {
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Console.WriteLine("tu as " + count + " bonne(s) réponse(s) sur 5");
        }
    }
}