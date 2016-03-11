using playbook.MongoData.Entities.Base;

namespace playbook.MongoData.Model
{
    public class User : MongoEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
