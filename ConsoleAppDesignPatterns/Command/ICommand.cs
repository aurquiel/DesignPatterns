﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}