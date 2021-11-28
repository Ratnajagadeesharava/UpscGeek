using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using UpscGeek.Core.Entities.Enum;

namespace UpscGeek.Core.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        
        public string SubjectName { get; set; }
       
        public Papers Paper { get; set; }
    }
}