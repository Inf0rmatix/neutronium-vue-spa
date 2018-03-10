using System.Threading.Tasks;

namespace Spekulatius.Application.WindowServices
{
    public interface IMessageBox 
    {
        Task<bool> ShowMessage(ConfirmationMessage confirmationMessage);

        void ShowInformation(MessageInformation messageInformation);
    }
}