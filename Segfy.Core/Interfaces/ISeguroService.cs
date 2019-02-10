using Segfy.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy.Core.Interfaces
{
    public interface ISeguroService
    {
        List<Seguro> Get();

        Seguro Get(string id);

        Seguro Create(Seguro seguro);

        void Update(Seguro seguroIn);

        void Remove(string id);
    }
}
