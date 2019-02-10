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
    public class SeguroService : ISeguroService
    {
        private readonly IMongoCollection<Seguro> seguros;

        public SeguroService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("SegfyDB"));
            var database = client.GetDatabase("SegfyDB");
            seguros = database.GetCollection<Seguro>("Seguro");
        }

        public List<Seguro> Get()
        {
            return seguros.Find(seguros => true).ToList();
        }

        public Seguro Get(string id)
        {
            return seguros.Find<Seguro>(seg => seg.Id == id).FirstOrDefault();
        }

        public Seguro Create(Seguro seguro)
        {
            seguros.InsertOne(seguro);
            return seguro;
        }

        public void Update(Seguro seguroIn)
        {
            seguros.ReplaceOne(seg => seg.Id == seguroIn.Id, seguroIn);
        }

        public void Remove(string id)
        {
            seguros.DeleteOne(seg => seg.Id == id);
        }
    }
}
