﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmXamarin
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _handler;
        private bool _isEnabled = true;
        public DelegateCommand(Action handler)
        {
            _handler = handler;
        }
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set {
                _isEnabled = value;
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this,EventArgs.Empty);
                }
            }
        }
        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            _handler();
        }
    }
}
