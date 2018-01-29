using System.Threading.Tasks;

namespace Wiki.js_desktop.Application.WindowServices
{
    public interface IMessageBox
    {
        Task<bool> ShowMessage(ConfirmationMessage confirmationMessage);

        void ShowInformation(MessageInformation messageInformation);
    }
}