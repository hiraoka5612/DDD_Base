using DDD_Base.Infrastructure;
using DDD_Base.Infrastructure.Fake;
using DDD_Base.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace DDD_Base.WinForm.Views
{
    public partial class UserVIew : Form
    {
        private UserViewModel _viewModel = new UserViewModel();
        public UserVIew()
        {
            InitializeComponent();

            UserIdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.IdText));
            UserNameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.NameText));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }
    }
}
