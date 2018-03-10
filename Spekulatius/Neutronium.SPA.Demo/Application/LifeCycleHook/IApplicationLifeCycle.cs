using System.ComponentModel;
using Spekulatius.Application.Navigation;

namespace Spekulatius.Application.LifeCycleHook
{
    public interface IApplicationLifeCycle
    {
        void OnNavigating(RoutingEventArgs routingEvent);

        void OnNavigated(RoutedEventArgs routedEvent);

        void OnClosing(CancelEventArgs cancelEvent);

        void OnSessionEnding(CancelEventArgs cancelEvent);

        void OnClosed();
    }
}
