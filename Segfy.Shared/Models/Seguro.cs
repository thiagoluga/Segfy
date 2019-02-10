using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Segfy.Shared.Models
{
    public class Seguro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement]
        [BsonRequired]
        [DisplayName("CPF/CNPJ do Cliente")]
        public string ClienteDocumento { get; set; }

        [BsonElement]
        [BsonRequired]
        [DisplayName("Tipo do Seguro")]
        public int SeguroTipo { get; set; }

        [BsonElement]
        [BsonRequired]
        [DisplayName("Objeto Segurado")]
        public string SeguroItem { get; set; }
    }
}
