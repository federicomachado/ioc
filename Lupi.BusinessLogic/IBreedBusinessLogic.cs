using System;
using System.Collections.Generic;
using Lupi.Data.Entities;

namespace Lupi.BusinessLogic
{
    public interface IBreedBusinessLogic
    {
        void Add(Breed breed);
        IEnumerable<Breed> Get();
        Breed Get(Guid id);
    }
}