using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using MailClient.Model;

namespace MailClient.Repository
{
    [XmlRoot("MessagesList")]
    public class XmlRepository : IRepository
    {
        private List<MailMessage> _mailingList;

        [XmlArrayItem("MailMessage")]
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
            set
            {
                _mailingList = value;
            }
        }

        private XmlRepository()
        {
            //InitRepository();
           //Init();
        }

        //private void InitRepository()
        //{
        //    //XmlReader xmlReader = XmlReader.Create(@"C:\Users\ruthc\source\repos\MailClient\MailClient\Xml\MessagesDB.xml");
        //    //while (xmlReader.Read())
        //    //{
        //    //    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "MailMessage"))
        //    //    {
        //    //        if (xmlReader.HasAttributes)
        //    //            Console.WriteLine(xmlReader.GetAttribute("From") + ": " + xmlReader.GetAttribute("Content"));
        //    //    }

        //    //    Console.ReadKey();
        //    //}


        //    //XmlDocument document = new XmlDocument();
        //    //XmlReader reader = XmlReader.Create(@"C:\Users\ruthc\source\repos\MailClient\MailClient\Xml\MessagesDB.xml");
        //    //document.Load(reader);



        //}

        public static XmlRepository Init()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XmlRepository));
            using (StringReader fileStream = new StringReader(Properties.Resources.XMLFile1))
            {
                return (XmlRepository)serializer.Deserialize(fileStream);
            }
        }
    }
}


