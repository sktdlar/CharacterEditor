using CharacterEditor.Weapon;
using CharacterEditor.WeaponFolder;
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
using System.Windows.Shapes;

namespace CharacterEditor.Pages
{
    /// <summary>
    /// Логика взаимодействия для InventoryBtn.xaml
    /// </summary>
    public partial class InventoryBtn : Window
    {
        Unit currentUnit;
        public InventoryBtn(Unit unit)
        {
            InitializeComponent();
            currentUnit = unit;
            List<string> ListOfWeapons = new List<string>()
            {
                "Axe",
                "Dagger",
                "Hammer",
                "Sword",
                "Wand"
            };
            TypesOfWeaponCb.ItemsSource = ListOfWeapons;


        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
           if(TypesOfWeaponCb.SelectedItem != null)
            {
                if(TypesOfWeaponCb.SelectedIndex == 0)
                {
                    currentUnit.Weapons.Add(new Axe("Топор", LvlWCb.SelectedIndex));
                    this.Close();
                }
                else if(TypesOfWeaponCb.SelectedIndex == 1)
                {
                    currentUnit.Weapons.Add(new Dagger("Кинжал", LvlWCb.SelectedIndex));
                    this.Close();
                }
                else if(TypesOfWeaponCb.SelectedIndex == 2)
                {
                    currentUnit.Weapons.Add(new Hammer("Молот", LvlWCb.SelectedIndex));
                    this.Close();
                }
                else if(TypesOfWeaponCb.SelectedIndex == 3)
                {
                    currentUnit.Weapons.Add(new Sword("Меч", LvlWCb.SelectedIndex));
                    this.Close();
                }
                else if (TypesOfWeaponCb.SelectedIndex == 4)
                {
                    currentUnit.Weapons.Add(new Wand("Посох", LvlWCb.SelectedIndex));
                    this.Close();
                }
                
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {   

        }
    }
}
