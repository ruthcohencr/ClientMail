using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Model
{
    public class ContactList
    {
        [Key]
        public int ID { get; set; }

        [StringLength(25)]
        public string NickName { get; set; }

        [StringLength(25)]
        public string  EmailAddress { get; set; }
    }
}
