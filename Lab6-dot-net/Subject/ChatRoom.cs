using Lab6_dot_net.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_dot_net.Subject
{
    public class ChatRoom : ISubject
    {
        public string Name { get; private set; }
        private List<IObserver> _observers = new List<IObserver>();

        public ChatRoom(string name)
        {
            Name = name;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.Name} приєднався до кiмнати {Name}.");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"{observer.Name} залишив кiмнату {Name}.");
        }

        public void Notify(string message, IObserver sender)
        {
            foreach (var observer in _observers)
            {
                // Повiдомлення отримують всi користувачi окрiм вiдправника
                if (observer != sender)
                {
                   observer.Update(message, sender, this);
                }
            }
        }
    }
}
