using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Momento
{
    public class Originator
    {
        private string _article;

        public string Article { get => _article; 
            set {
                Console.WriteLine("From Originator: Current Version of Article\n" + value + "\n");
                _article = value;
            } }

        public Memento StoreInMemento()
        {
            Console.WriteLine("From Originator: Saving to Memento");
            return new Memento(_article);
        }

        public string RestoreFromMemento(Memento memento)
        {
            _article = memento.Article;
            Console.WriteLine("From Originator: Previous Article Saved in Memento\n" + _article + "\n");
            return _article;
        }
    }
}
