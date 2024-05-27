using Lab6_dot_net.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_dot_net.Subject
{
    public interface ISubject
    {
        string Name { get; }
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message, IObserver observer);
    }
}
