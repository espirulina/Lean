using System.Collections.Generic;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer.Interfaces
{
    public interface IFitnessFunction
    {
        double Evaluate(Dictionary<string, string> statistics);
    }
}
