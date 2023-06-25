using DDD.Foundations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner;

internal class Dinner<DinnerId> : Entity<DinnerId> where DinnerId: EntityId
{
    public DinnerId Id { get; init; }

    internal Dinner(DinnerId id) : base(id)
    { Id = id; }

}
