using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MailClient.Repository;
using MailClient.ViewModel;

namespace MailClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MailStartView : Window
    {
        public MailStartView()
        {
            InitializeComponent();

            // Option 1  - hard coded mailing list
            IRepository testRepository = new TestRepository();
            DataContext = new MailClientViewModel(testRepository);


            //System.Xml.Serialization.XmlSerializer xsSubmit = new System.Xml.Serialization.XmlSerializer(typeof(TestRepository));
            //var subReq = new TestRepository();
            //var xml = "";

            //using (var sww = new System.IO.StringWriter())
            //{
            //    using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(sww))
            //    {
            //        xsSubmit.Serialize(writer, subReq);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}

            ////   Option 2 load from xml file
            //XmlRepository xml = XmlRepository.Init();
            //IRepository xmlRepository = new MailingListRepository(xml);

            //DataContext = new MailClientViewModel(xmlRepository);



            ////// Option 3 load from DB
            //IRepository dbRepository = new DbRepository();
            //DataContext = new MailClientViewModel(dbRepository);

        }
    }
}
