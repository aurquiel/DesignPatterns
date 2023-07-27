using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Momento
{
    public class Memento
    {
        private string _article;

        public Memento(string article)
        {
            _article = article;
        }

        public string Article { get => _article;}
    }
}
