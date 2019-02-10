using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Segfy.Core.Interfaces;
using Segfy.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy.Core.Services
{
    public class BuscaService : IBuscaService
    {
        private readonly IMongoCollection<Seguro> seguros;

        public BuscaService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("SegfyDB"));
            var database = client.GetDatabase("SegfyDB");
            seguros = database.GetCollection<Seguro>("Seguro");
        }

        public List<Seguro> Get(string placa)
        {
            return seguros.Find(seguros => seguros.SeguroItem == placa).ToList();
        }
    }
}
