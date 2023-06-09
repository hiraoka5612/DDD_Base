﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DDD_Base.WinForm.ViewModels
{

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName] string propertyName = null)
        {

            if (Equals(field, value))
            {
                return false;
            }

            field = value;

            var h = this.PropertyChanged;

            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }

            return true;

        }

        public virtual System.DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public void OnPropertyChanged()
        {
            PropertyChanged.Invoke(
                this,
                new PropertyChangedEventArgs(""));
        }

    }

}