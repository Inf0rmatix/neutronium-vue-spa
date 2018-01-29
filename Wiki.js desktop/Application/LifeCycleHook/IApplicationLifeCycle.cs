using System.ComponentModel;
using Wiki.js_desktop.Application.Navigation;

namespace Wiki.js_desktop.Application.LifeCycleHook
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
