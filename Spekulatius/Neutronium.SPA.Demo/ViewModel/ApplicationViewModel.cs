using System.Threading.Tasks;
using Neutronium.WPF.ViewModel;
using Spekulatius.Application.Navigation;
using Spekulatius.Application.WindowServices;
using Spekulatius.ViewModel.Modal;

namespace Spekulatius.ViewModel 
{
    public class ApplicationViewModel : Vm.Tools.ViewModel, IMessageBox 
    {
        public ApplicationInformation ApplicationInformation { get; } = new ApplicationInformation();
        public IWindowViewModel Window { get; }
        public NavigationViewModel Router { get; }

        private object _CurrentViewModel;
        public object CurrentViewModel 
        {
            get { return _CurrentViewModel; }
            private set { Set(ref _CurrentViewModel, value); }
        }

        private MessageModalViewModel _Modal;
        public MessageModalViewModel Modal 
        {
            get { return _Modal; }
            private set { Set(ref _Modal, value); }
        }


        public ApplicationViewModel(IWindowViewModel window, NavigationViewModel router)
        {
            Window = window;
            Router = router;
            Router.OnNavigated += Router_OnNavigated;
        }

        public Task<bool> ShowMessage(ConfirmationMessage confirmationMessage) 
        {
            var modal = new MainModalViewModel(confirmationMessage);
            Modal = modal;
            return modal.CompletionTask;
        }

        public void ShowInformation(MessageInformation messageInformation)
        {
            var modal = new MessageModalViewModel(messageInformation);
            Modal = modal;
        }

        private void Router_OnNavigated(object sender, RoutedEventArgs e)
        {
            CurrentViewModel = e.NewRoute.ViewModel;
        }

        public ApplicationViewModel StartRoute<T>()
        {
            Router.StartRoute<T>();
            return this;
        }
    }
}
