using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Builder
{
    public interface IBuilderStep2
    {
        public IBuilderStep3 Step2(/* parameters */);
    }

}
