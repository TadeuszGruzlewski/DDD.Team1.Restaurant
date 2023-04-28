using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Foundations;
using DDD.Primitives.Finance;

namespace Dinner;

internal record Dish(string Name, string Description, Price Price) : ValueObject
{
    // public Image Image .....

    public override bool AssertInvariants(List<InvariantError> errors)
    {
        return true;
    }
}
