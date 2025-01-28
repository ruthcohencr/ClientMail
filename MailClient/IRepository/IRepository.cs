using System.Collections.Generic;
using System.Collections.ObjectModel;
using MailClient.Model;

namespace MailClient.Repository
{
    public interface IRepository
    {
        List<MailMessage> MailingList { get;}
    }
}