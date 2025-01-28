using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Context;
using MailClient.Model;

namespace MailClient.Repository
{
    public class DbRepository : IRepository
    {
        private List<MailMessage> _mailingList;
        public List<MailMessage> MailingList
        {
            get
            {
                if (_mailingList == null)
                {
                    _mailingList = new List<MailMessage>();
                }
                return _mailingList;
            }
            set { _mailingList = value; }
        }

        public DbRepository()
        {
            InitMailingList();
        }

        public void InitMailingList()
        {
            using (var db = new MailClientContext())
            {
              MailingList = db.MailMessage.ToList();
            }
        }

        public void UpdateIfRead(int id,bool value)
        {
            using (var db = new MailClientContext())
            {
                var success = db.MailMessage.Where(m=> m.ID == id).FirstOrDefault();
                success.IsRead = value;
                db.SaveChanges();
            }
        }
    }
}
