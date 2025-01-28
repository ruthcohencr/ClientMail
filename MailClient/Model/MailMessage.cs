using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MailClient.Model
{
    public class MailMessage : INotifyPropertyChanged
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        private string _from;
        [XmlAttribute("From")]
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        //private List<string> _to;

        //[XmlArray("To")]
        //public virtual List<string> To
        //{
        //    get { return _to; }
        //    set { _to = value; }
        //}


        public ICollection<string> To { get; set; }
        public string ListForTo
        {
            get { return string.Join(",", To); }
            set { To = value.Split(',').ToList(); }
        }

        public ICollection<string> Cc { get;
            set; }

        public string ListForCc
        {
            get
            {
                if (Cc.Count != 0)
                {
                    return string.Join(",", Cc);
                }
                else return string.Empty;
            }

            set { Cc = value.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList(); }
        }



        //private List<string> _cc;

        //[XmlArray("Cc")]
        //public virtual List<string> Cc
        //{
        //    get { return _cc; }
        //    set { _cc = value; }
        //}


        private DateTime _sentDateTime;

        [XmlElement("SentDateTime")]
        public DateTime SentDateTime
        {
            get { return _sentDateTime; }
            set { _sentDateTime = value; }
        }


        private bool _isRead;


        [XmlAttribute("IsRead")]
        public bool IsRead
        {
            get { return _isRead; }
            set
            {
                _isRead = value;
                OnPropertyChanged();
            }
        }

        [XmlAttribute("Subject")]
        public string Subject { get; set; }
        [XmlAttribute("Content")]
        public string Content { get; set; }

        public MailMessage(string from, string subject, List<string> to, List<string> cc, string content, DateTime sentDateTime)
        {
            From = from;
            Subject = subject;
            To = to;
            Cc = cc;
            Content = content;
            SentDateTime = sentDateTime;
        }


        public MailMessage()
        { }

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateIsRead(bool read)
        {
            //  IsRead = IsRead == false ? true : true;
            IsRead = read;
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
