using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneFlightTimeCalculator.ProgramFiles
{
    [BsonIgnoreExtraElements]
    public class Component
    {
        //[BsonId]
        public string ComponentName
        { get; set; }

        [BsonElement("Model")]
        [BsonIgnoreIfNull]
        public string Model
        { get; set; }

        [BsonElement("Specifications")]
        [BsonIgnoreIfNull]
        public string Specifications
        { get; set; }

        [BsonElement("Weight")]
        [BsonIgnoreIfNull]
        public decimal Weight
        { get; set; }
    }


}
