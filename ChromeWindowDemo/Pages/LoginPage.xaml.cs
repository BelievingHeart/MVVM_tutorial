using System.Security;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ChromeWindowDemo.Commands;

namespace ChromeWindowDemo
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : PageBase<LoginPageViewModel>, IHavePassword
    {

        public LoginPage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Provide the ability to bind for PasswordBox.SecurePassword
        /// </summary>
        public SecureString Password => PasswordInput.SecurePassword;
    }
}
