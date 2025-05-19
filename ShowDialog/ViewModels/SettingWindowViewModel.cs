using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismWPF.ViewModels
{
    public class SettingWindowViewModel : BindableBase, IDialogAware
    {
        private string _title = "Setting Window";
        public SettingWindowViewModel()
        {
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public event Action<IDialogResult> RequestClose;
        public bool CanCloseDialog()
        {
            return true;
        }
        public void OnDialogClosed()
        {
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
