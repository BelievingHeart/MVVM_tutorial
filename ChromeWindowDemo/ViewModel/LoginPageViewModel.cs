

using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using ChromeWindowDemo.Commands;

namespace ChromeWindowDemo
{
    public class LoginPageViewModel : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }


        private async Task Login(IHavePassword havePasswordObject)
        {
            var length = havePasswordObject.Password.Length;
            await Task.Delay(5000);

        }

     

        public LoginPageViewModel()
        {
            LoginCommand = new ParameterizedCommand(async havePasswordObject => await Login(havePasswordObject as IHavePassword));
        }
    }
}
