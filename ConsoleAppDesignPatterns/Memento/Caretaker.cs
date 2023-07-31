using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Memento
{
    public class Caretaker
    {
        List<Memento> savedArticles = new();

        public void AddMemento(Memento memento)
        {
            savedArticles.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return savedArticles[index];
        }
    }
}
