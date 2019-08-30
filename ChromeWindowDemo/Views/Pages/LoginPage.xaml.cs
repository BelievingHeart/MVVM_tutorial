using System.Security;
using System.Windows;

namespace ChromeWindowDemo
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : PageBase<LoginPageViewModel>, IHavePassword
    {

        public LoginPage()
        {
            LoadingAnimationType = PageAnimationType.SlideIn;
            InitializeComponent();
        }

        /// <summary>
        /// Provide the ability to bind for PasswordBox.SecurePassword
        /// </summary>
        public SecureString Password => PasswordInput.SecurePassword;

    }
}
