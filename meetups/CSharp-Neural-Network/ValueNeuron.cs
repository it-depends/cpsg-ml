﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Neural_Network
{
    class ValueNeuron : Neuron
    {
        public ValueNeuron() : base(null, null) { }

        public override void FeedForward()
        {
            // do nothing
        }

        public override void PropagateBack()
        {
            // do nothing
        }

        public virtual void SetValue(double value)
        {
            Value = value;
        }

    }

    class BiasNeuron : ValueNeuron
    {
        public BiasNeuron()
        {
            base.SetValue(1);
        }

        public override void SetValue(double value)
        {
            throw new Exception("You can't set the value of a BiasNeuron");
        }
    }

}
