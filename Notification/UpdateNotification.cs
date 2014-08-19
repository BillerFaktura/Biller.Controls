using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Biller.Controls.Notification
{
    public class UpdateNotification : Notification
    {
        public UpdateNotification()
            : base()
        {  }

        public void SetActions(Action<object> ChangelogClick, Action<object> UpdateNowClick, Action<object> UpdateLaterClick)
        {
            ChangelogCommand = new Biller.Controls.DelegateCommand(ChangelogClick);
            UpdateNowCommand = new Biller.Controls.DelegateCommand(UpdateNowClick);
            UpdateLaterCommand = new Biller.Controls.DelegateCommand(UpdateLaterClick);
        }

        private double progress;
        public double Progress
        {
            get { return progress; }

            set
            {
                if (progress == value) return;
                progress = value;
                OnPropertyChanged("Progress");
            }
        }

        private System.Windows.Visibility progressBarVisibility = System.Windows.Visibility.Collapsed;
        public System.Windows.Visibility ProgressBarVisibility
        {
            get { return progressBarVisibility; }

            set
            {
                if (progressBarVisibility == value) return;
                progressBarVisibility = value;
                OnPropertyChanged("ProgressBarVisibility");
            }
        }

        private System.Windows.Visibility textVisibility = System.Windows.Visibility.Visible;
        public System.Windows.Visibility TextVisibility
        {
            get { return textVisibility; }

            set
            {
                if (textVisibility == value) return;
                textVisibility = value;
                OnPropertyChanged("TextVisibility");
            }
        }

        public ICommand ChangelogCommand { get; set; }
        public ICommand UpdateNowCommand { get; set; }
        public ICommand UpdateLaterCommand { get; set; }
    }
}
