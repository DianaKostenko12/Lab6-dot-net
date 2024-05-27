using Lab6_dot_net.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_dot_net.Observer
{
    public class ChatParticipant : IObserver
    {
        public string Name { get; private set; }
        private List<ISubject> chatRooms = new List<ISubject>();
        public ChatParticipant(string name)
        {
            Name = name;
        }

        public void Update(string message, IObserver sender, ISubject chatRoom)
        {
            Console.WriteLine($"{Name} отримав повiдомлення вiд {sender.Name} в кiмнатi {chatRoom.Name}: {message}");
        }

        public void SendMessage(string message, ISubject chatRoom)
        {
            chatRoom.Notify(message,this);
        }

        public void JoinChatRoom(ISubject chatRoom)
        {
            chatRooms.Add(chatRoom);
            chatRoom.Attach(this);
        }
    }
}
