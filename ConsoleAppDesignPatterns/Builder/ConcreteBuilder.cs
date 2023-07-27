using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilderStep1, IBuilderStep2, IBuilderStep3
    {
        private Product product;

        public ConcreteBuilder()
        {
            product = new Product();
        }

        public IBuilderStep2 Step1(/* parameters */)
        {
            // Implement Step 1 logic
            return this;
        }

        IBuilderStep3 IBuilderStep2.Step2()
        {
            return this;
        }

        ConcreteBuilder IBuilderStep3.Step3()
        {
            return this;
        }

        public Product Build( )
        {
            return product;
        }

    }
}
