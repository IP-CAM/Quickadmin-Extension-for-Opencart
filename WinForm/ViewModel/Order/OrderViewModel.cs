namespace UI.ViewModel
{
    internal class OrderViewModel : ViewModelBase
    {
        private bool sendEmail;

        public OrderViewModel() { }

        public bool SendEmail
        {
            get => sendEmail;
            set
            {
                sendEmail = value;
                OnPropertyChanged(nameof(SendEmail));
            }
        }
    }
}
