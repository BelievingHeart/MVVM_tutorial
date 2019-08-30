

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ChromeWindowDemo.Commands;

namespace ChromeWindowDemo
{
    public class LoginPageViewModel : ViewModelBase
    {
        #region Properties
        /// <summary>
        /// Command that allows the login button binds to
        /// </summary>
        public ICommand LoginCommand { get; set; }
        public bool CanLogin { get; set; } = true;

        #endregion


        #region Implemetations
        //TODO: Extract this procedure using LINQ expression (Episode 10)
        /// <summary>
        /// Simulate a login scenario with remote server verifying password
        /// </summary>
        /// <param name="havePasswordObject"></param>
        /// <returns></returns>
        private async Task Login(IHavePassword havePasswordObject)
        {
            var length = havePasswordObject.Password.Length;
            if (!CanLogin) return;

            CanLogin = false;
            try
            {
                await Task.Delay(5000);
                throw new NullReferenceException();

            }
            catch
            {

            }
            finally
            {
                CanLogin = true;
            }

        }

        #endregion


        #region Constructor

        public LoginPageViewModel()
        {
            LoginCommand = new ParameterizedCommand(async havePasswordObject => await Login(havePasswordObject as IHavePassword));
        }

        #endregion
    }
}
