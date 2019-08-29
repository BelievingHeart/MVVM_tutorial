using System.Security;

namespace ChromeWindowDemo
{
    public interface IHavePassword
    {
        SecureString Password { get; }
    }
}