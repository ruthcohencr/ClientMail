using System;
using System.Collections.Generic;
using System.Data.Entity;
using MailClient.Model;

namespace MailClient.Context
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<MailClientContext>
    {
        protected override void Seed(MailClientContext context)
        {
            base.Seed(context);
            List<string> list = new List<string>() { "eli@gmail.com", "gali@gmail.com", "lev@gmail.com", "yehuda@gmail.com" };
            List<string> emptyList = new List<string>();
            List<string> listCC = new List<string>() { "eli@gmail.com", "gali@gmail.com", "lev@gmail.com", "yehuda@gmail.com" };

            //string list =  "eli@gmail.com," + "gali@gmail.com," + "lev@gmail.com,"+ "yehuda@gmail.com" ;
            //string emptyList = "";
            //string listCC = "eli@gmail.com,"+ "gali@gmail.com,"+ "lev@gmail.com,"+ "yehuda@gmail.com" ;

            context.MailMessage.Add(new MailMessage("Itay Saragany", "Welcome mail", list, listCC, "hello world 1", DateTime.Now));
            context.MailMessage.Add(new MailMessage("Meir Swisa", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(5)));
            context.MailMessage.Add(new MailMessage("Lev Strelnikov", "Cloud mision", list, emptyList, "mision 2", DateTime.Now.AddDays(10)));
            context.MailMessage.Add(new MailMessage("Kara Hayun", "Welcome mail", list, emptyList, "hello world 1", DateTime.Now.AddDays(-400)));
            context.MailMessage.Add(new MailMessage("Rivka Simol", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(45)));
            context.MailMessage.Add(new MailMessage("Ron Cohen", "Children conversation", list, emptyList, "mision 2", DateTime.Now.AddDays(100)));
            context.MailMessage.Add(new MailMessage("Meir Swisa", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(5)));
            context.MailMessage.Add(new MailMessage("Lev Strelnikov", "Cloud mision 2", list, emptyList, "mision 2", DateTime.Now.AddDays(10)));
            context.MailMessage.Add(new MailMessage("Kara Hayun", "Welcome mail", list, emptyList, "hello world 1", DateTime.Now.AddDays(-400)));
            context.MailMessage.Add(new MailMessage("Rivka Simol", "First mision", list, emptyList, "mision 1", DateTime.Now.AddDays(45)));
            context.MailMessage.Add(new MailMessage("Ron Cohen", "Children conversation", list, emptyList, "mision 2", DateTime.Now.AddDays(100)));
            context.SaveChanges();
        }
    }
}