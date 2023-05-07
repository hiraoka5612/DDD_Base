using System;

namespace DDD_Base.WinForm.ViewModels
{
    public sealed class SampleViewModel : ViewModelBase
    {
        public string IdText { get; set; }
        public string NameText { get; set; }
        public string DateText { get; set; }

        public void Search()
        {
            throw new NotImplementedException();
        }
    }
}
