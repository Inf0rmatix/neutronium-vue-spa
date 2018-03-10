﻿using System.ComponentModel;
using Spekulatius.Application.LifeCycleHook;
using Spekulatius.Application.Navigation;
using Spekulatius.Application.WindowServices;
using Vm.Tools.Application;

namespace Spekulatius
{
    public class ApplicationLifeCycle: IApplicationLifeCycle
    {
        private readonly IMessageBox _MessageBox;
        private readonly IApplication _Application;

        public ApplicationLifeCycle(IMessageBox messageBox, IApplication application)
        {
            _MessageBox = messageBox;
            _Application = application;
        }

        public void OnNavigating(RoutingEventArgs routingEvent)
        {
        }

        public void OnNavigated(RoutedEventArgs routedEvent)
        {
        }

        public async void OnClosing(CancelEventArgs cancelEvent)
        {
            cancelEvent.Cancel = true;
            var confirmationMessage = new ConfirmationMessage(Resource.ConfirmationNeeded, Resource.DoYouWantToCloseApplication);
            var close = await _MessageBox.ShowMessage(confirmationMessage);
            if (close)
                _Application.ForceClose();
        }

        public void OnSessionEnding(CancelEventArgs cancelEvent)
        {
        }

        public void OnClosed()
        {
        }
    }
}
