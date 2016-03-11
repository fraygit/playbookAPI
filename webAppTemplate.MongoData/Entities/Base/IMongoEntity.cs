using MongoDB.Bson;

namespace playbook.MongoData.Entities.Base
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
