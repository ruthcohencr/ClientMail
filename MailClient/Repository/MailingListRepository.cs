using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Model;

namespace MailClient.Repository
{
    public class MailingListRepository : IRepository
    {
        private List<MailMessage> _mailingList;

        public List<MailMessage> MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }

        public MailingListRepository(IRepository repository)
        {
            MailingList = repository.MailingList;
        }
    }
}
