using System.Linq;
using System.Windows;
using System.Xml.Schema;

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
            if (email.Contains(' ') || email.Contains('@') == false)
            {
                return false;
            }
            
            string[] domains = { "mail.ru", "gmail.com", "yandex.ru" };
            string domain = email.Split("@").Last();
            
            return domains.Contains(domain) ;
        }
    }
}