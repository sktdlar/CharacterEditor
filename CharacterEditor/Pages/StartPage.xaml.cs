using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterEditor.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void ExitPage_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void SelectCharacterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectCharacterPage());
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewUnitPage());
        }
    }
}
