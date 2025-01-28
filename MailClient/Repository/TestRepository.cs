using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MailClient.Model;

namespace MailClient.Repository
{
    [XmlRoot("MessagesList")]
    public class TestRepository : IRepository
    {

        private List<MailMessage> _mailingList;

        [XmlArrayItem("MailMessage")]
        public List<MailMessage> MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }
        public TestRepository()
        {
            MailingList = new List<MailMessage>();
            List<string> list = new List<string>() { "eli@gmail.com", "gali@gmail.com", "lev@gmail.com", "yehuda@gmail.com" };
            List<string> emptyList = new List<string>();
            List<string> listCC = new List<string>() { "eli@gmail.com", "gali@gmail.com", "lev@gmail.com", "yehuda@gmail.com" };

            //string list = "eli@gmail.com" + "gali@gmail.com" + "lev@gmail.com" + "yehuda@gmail.com";
            //string emptyList = "";
            //string listCC = "eli@gmail.com" + "gali@gmail.com" + "lev@gmail.com" + "yehuda@gmail.com";

            MailingList.Add(new MailMessage("Itay Saragany", "Welcome mail", list, listCC, "hello world 1", DateTime.Now));
            MailingList.Add(new MailMessage("Meir Swisa", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(5)));
            MailingList.Add(new MailMessage("Lev Strelnikov", "Cloud mision", list, emptyList, "mision 2", DateTime.Now.AddDays(10)));
            MailingList.Add(new MailMessage("Kara Hayun", "Welcome mail", list, emptyList, "hello world 1", DateTime.Now.AddDays(-400)));
            MailingList.Add(new MailMessage("Rivka Simol", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(45)));
            MailingList.Add(new MailMessage("Ron Cohen", "Children conversation", list, emptyList, "mision 2", DateTime.Now.AddDays(100)));
            MailingList.Add(new MailMessage("Meir Swisa", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(5)));
            MailingList.Add(new MailMessage("Lev Strelnikov", "Cloud mision 2", list, emptyList, "mision 2", DateTime.Now.AddDays(10)));
            MailingList.Add(new MailMessage("Kara Hayun", "Welcome mail", list, emptyList, "hello world 1", DateTime.Now.AddDays(-400)));
            MailingList.Add(new MailMessage("Rivka Simol", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(45)));
            MailingList.Add(new MailMessage("Ron Cohen", "Children conversation", list, emptyList, "mision 2", DateTime.Now.AddDays(100)));
        }
    }
}
