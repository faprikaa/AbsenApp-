using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbsenApp.Model
{
    public class Matkul
    {
        [BsonId, BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("nama")]
        public string Nama { get; set; }

        public Matkul(string nama)
        {
            this.Nama = nama;
        }
    }
}
