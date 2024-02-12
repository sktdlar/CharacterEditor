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
    /// Логика взаимодействия для AddNewUnitPage.xaml
    /// </summary>
    public partial class AddNewUnitPage : Page
    {
        Unit CurrentUnit;
        public AddNewUnitPage()
        {
            InitializeComponent();
        }

        private void AddNewUnitBtn_Click(object sender, RoutedEventArgs e)
        {
            if(TypeOfUnitsCB.SelectedIndex != 0 )
            {
                if(TypeOfUnitsCB.SelectedIndex == 1)
                {
                    CRUD.CreateUser(CurrentUnit = new Warrior(NameTB.Text));
                }
                else if(TypeOfUnitsCB.SelectedIndex == 2)
                {
                    CRUD.CreateUser(CurrentUnit = new Wizard(NameTB.Text));
                }
                else if (TypeOfUnitsCB.SelectedIndex == 3)
                {
                    CRUD.CreateUser(CurrentUnit = new Rogue(NameTB.Text));
                }
                NavigationService.Navigate(new CharacterEditorPage(CurrentUnit));
            }
        }
    }
}
