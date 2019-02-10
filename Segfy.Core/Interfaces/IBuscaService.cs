using Segfy.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy.Core.Interfaces
{
    public interface IBuscaService
    {
        List<Seguro> Get(string placa);
    }
}
