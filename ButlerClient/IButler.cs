using System.Threading.Tasks;

namespace ButlerClient
{
    public interface IButler
    {
        Task<string> InstallAsync(WebhookRequest request);
    }
}
