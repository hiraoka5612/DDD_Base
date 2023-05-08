using DDD_Base.Domain.Entities;
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
        private int countdownSeconds = 10;
        public UserVIew()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();

            UserIdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.IdText));
            UserNameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.NameText));

            AreasComboBox.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.SelectedAreaId));
            AreasComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Areas));
            AreasComboBox.ValueMember = nameof(AreaEntity.AreaId);
            AreasComboBox.DisplayMember = nameof(AreaEntity.AreaName);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;
            if(countdownSeconds < 0)
            {
                timer1.Stop();
                this.Close();
            } else
            {
                CloseLabel.Text ="残り" +  countdownSeconds.ToString() + "秒で画面をログオフします。";
            }
        }

        private void UserView_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Stop();
            countdownSeconds = 10;
            timer1.Start();
        }

        private void UserView_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            countdownSeconds = 10;
            timer1.Start();
        }
    }
}
