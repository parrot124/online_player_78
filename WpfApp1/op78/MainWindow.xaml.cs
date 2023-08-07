using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public bool CheckEmail(string email)
        {
            string[] emailDomens = { "mail.ru", "@gmail.com", "yandex.ru" };
            string[] emailParts = email.Split("@");

            if (email.Contains(' ') || email.Split("@").Length != 2)
            {
                return false;
            }
            
            string domen = emailParts[1];

            if (!emailDomens.Contains(domen))
            { 
                return false;
            }

            return true;
        }
    }
}