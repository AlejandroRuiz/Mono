using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading;

namespace MvvmXamarin
{
	public class Model: INotifyPropertyChanged
	{
		public readonly SynchronizationContext context;
		public Model()
		{
			context = SynchronizationContext.Current;
		}
		private string text="Write Here";
		public string Text {
			get
            {
                return text;
            }
			set
			{
				text = value;
				OnPropertyChanged("Text");
			}
		}

        private int Times = 0;
        private string timesstring="Click";
        public string TimesString
        {
            get {
                return timesstring;
            }
            set {
                timesstring = value;
                OnPropertyChanged("TimesString");
            }
        }
        private ICommand clickEvent;
        public ICommand ClickEvent
        {
            get {
                return clickEvent ?? new DelegateCommand(ExecuteClickCommand);
            }
        }
        private void ExecuteClickCommand()
        {
            Times++;
           TimesString = string.Format("Clicked {0}",Times);
            
        }
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string Name)
		{
			if (PropertyChanged == null)
				return;
			context.Post((s)=>{
				PropertyChanged(this, new PropertyChangedEventArgs((string)s));
			},Name);
		}
	}
}