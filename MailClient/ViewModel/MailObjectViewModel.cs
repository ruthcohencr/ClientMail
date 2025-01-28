using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Command;
using MailClient.Model;
using MailClient.Repository;

namespace MailClient.ViewModel
{
    public class MailObjectViewModel : ViewModelBase
    {
        private IRepository _repository;
        private MailMessage _model;
        private RelayCommand _markAsUnread;

        public RelayCommand MarkAsUnread
        {
            get
            {
                if (_markAsUnread == null)
                {
                    _markAsUnread = new RelayCommand(() =>
                        {
                            _model.UpdateIsRead(false);
                            if (_repository is DbRepository rep)
                            {
                                rep.UpdateIfRead(_model.ID, false);
                            }
                        });
                }
                return _markAsUnread;
            }
        }

        public MailObjectViewModel(MailMessage model, IRepository repository)
        {
            _model = model;
            _repository = repository;
        }

        public MailMessage Model
        {
            get
            {
                return _model;
            }
        }


    }
}
