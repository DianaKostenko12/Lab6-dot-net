using Lab6_dot_net.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_dot_net.Observer
{
    public interface IObserver
    {
        string Name {  get; }
        void Update(string message, IObserver sender, ISubject chatRoom);
        void SendMessage(string message, ISubject chatRoom);
        void JoinChatRoom(ISubject chatRoom);
    }
}
