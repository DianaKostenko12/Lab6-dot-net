using Lab6_dot_net.Observer;
using Lab6_dot_net.Subject;
using System.Collections.Generic;

namespace Lab6_dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ISubject room1 = new ChatRoom("Кодери");
                ISubject room2 = new ChatRoom("Мозковий штурм");

                IObserver ChatParticipant1 = new ChatParticipant("Анна");
                IObserver ChatParticipant2 = new ChatParticipant("Борис");
                IObserver ChatParticipant3 = new ChatParticipant("Василь");
                IObserver ChatParticipant4 = new ChatParticipant("Петро");

                ChatParticipant1.JoinChatRoom(room1);
                ChatParticipant2.JoinChatRoom(room1);
                ChatParticipant3.JoinChatRoom(room2);
                ChatParticipant4.JoinChatRoom(room2);

                bool annaInRoom1 = true;
                bool borisInRoom1 = true;
                bool vasilInRoom2 = true;
                bool petroInRoom2 = true;

                while (true)
                {
                    Console.WriteLine("Привiт! Напиши своє iм'я:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Що бажаєш зробити? " +
                        "\n1 - Написати повiдомлення" +
                        "\n2 - Вийти з чату");

                    int answer = Convert.ToInt32(Console.ReadLine());

                    switch (name)
                    {
                        case "Анна":
                            if (annaInRoom1)
                            {
                                if (answer == 1)
                                {
                                    Console.WriteLine("Введи текст повiдомлення: ");
                                    ChatParticipant1.SendMessage(Console.ReadLine(), room1);
                                }
                                else if (answer == 2)
                                {
                                    room1.Detach(ChatParticipant1);
                                    annaInRoom1 = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Такого користувача немає в цiй групi.");
                            }

                            break;
                        case "Борис":
                            if (borisInRoom1)
                            {
                                if (answer == 1)
                                {
                                    Console.WriteLine("Введи текст повiдомлення: ");
                                    ChatParticipant2.SendMessage(Console.ReadLine(), room1);
                                }
                                else if (answer == 2)
                                {
                                    room1.Detach(ChatParticipant2);
                                    borisInRoom1 = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Такого користувача немає в цiй групi.");
                            }
                            break;
                        case "Василь":
                            if (vasilInRoom2)
                            {
                                if (answer == 1)
                                {
                                    Console.WriteLine("Введи текст повiдомлення: ");
                                    ChatParticipant3.SendMessage(Console.ReadLine(), room2);
                                }
                                else if (answer == 2)
                                {
                                    room2.Detach(ChatParticipant3);
                                    vasilInRoom2 = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Такого користувача немає в цiй групi.");
                            }

                            break;
                        case "Петро":
                            if (petroInRoom2)
                            {
                                if (answer == 1)
                                {
                                    Console.WriteLine("Введи текст повiдомлення: ");
                                    ChatParticipant4.SendMessage(Console.ReadLine(), room2);
                                }
                                else if (answer == 2)
                                {
                                    room2.Detach(ChatParticipant4);
                                    petroInRoom2 = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Такого користувача немає в цiй групi.");
                            }
                            break;
                        default:
                            Console.WriteLine("Такого iм'я не знайдено");
                            break;
                    }
                }
            }
        }
    }
}




