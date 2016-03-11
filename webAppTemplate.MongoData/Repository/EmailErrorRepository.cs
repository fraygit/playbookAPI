using playbook.MongoData.Interface;
using playbook.MongoData.Model;
using playbook.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playbook.MongoData.Repository
{
    public class EmailErrorRepository : EntityService<EmailError>, IEmailErrorRepository
    {
    }
}
