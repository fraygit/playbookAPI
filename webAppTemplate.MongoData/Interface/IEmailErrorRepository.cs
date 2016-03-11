using playbook.MongoData.Model;
using playbook.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playbook.MongoData.Interface
{
    public interface IEmailErrorRepository : IEntityService<EmailError>
    {
    }
}
