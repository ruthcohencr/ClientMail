namespace MailClient.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MailClient.Model;

    public partial class MailClientContext : DbContext
    {
        public MailClientContext()
            : base("name=MailClientContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<ContactList> ContactList { get; set; }
        public virtual DbSet<MailMessage> MailMessage { get; set; }
    }
}
