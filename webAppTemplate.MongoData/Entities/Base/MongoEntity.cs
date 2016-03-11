using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace playbook.MongoData.Entities.Base
{
    public class MongoEntity : IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
