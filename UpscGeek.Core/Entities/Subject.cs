using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using UpscGeek.Core.Entities.Enum;

namespace UpscGeek.Core.Entities
{
    public class Subject
    {
        // [BsonId]
        // [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("SubjectName")]
        public string SubjectName { get; set; }
        [BsonElement("Paper")]
        public Papers Paper { get; set; }
    }
}