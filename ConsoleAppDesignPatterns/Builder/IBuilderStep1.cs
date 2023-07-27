using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Builder
{
    public interface IBuilderStep1
    {
        public IBuilderStep2 Step1(/* parameters */);
    }

}
