using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MailClient.Command;
using MailClient.Model;
using MailClient.Repository;

namespace MailClient.ViewModel
{
    public class MailClientViewModel : ViewModelBase
    {
        private IRepository _repository;
        private ObservableCollection<MailObjectViewModel> _mailingList = new ObservableCollection<MailObjectViewModel>();
 
        public ObservableCollection<MailObjectViewModel> MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }

        public MailClientViewModel(IRepository repository )
        {
            _repository = repository;
            foreach (var mail in repository.MailingList)
            {
                MailingList.Add(new MailObjectViewModel(mail,_repository));
            }
            SelectedMail = MailingList.FirstOrDefault();
        }

        private MailObjectViewModel _selectedMail;

        public MailObjectViewModel SelectedMail
        {
            get { return _selectedMail; }
            set {
                _selectedMail = value;
                SelectedMail.Model.UpdateIsRead(true);
                if (_repository is DbRepository rep)
                {
                    // Update Data Base
                    rep.UpdateIfRead(SelectedMail.Model.ID,true);
                }
                OnPropertyChanged();
            }
        }

        
    }
}
