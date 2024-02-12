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
    /// Логика взаимодействия для SelectCharacterPage.xaml
    /// </summary>
    public partial class SelectCharacterPage : Page
    {
        public SelectCharacterPage()
        {
            InitializeComponent();
            var users = CRUD.GetUsers();
            UnitsList.ItemsSource = users.ToList();
        }
        private void SelectCharacterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!(UnitsList.SelectedItem is null))
            { 
                NavigationService.Navigate(new CharacterEditorPage(UnitsList.SelectedItem as Unit));
            }
            else
            {
                MessageBox.Show("Не выбран персонаж");
            }
        }

        private void AddNewUnitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewUnitPage());
        }
    }
}
