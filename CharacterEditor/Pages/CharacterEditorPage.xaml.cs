using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CharacterEditor.Pages
{
    /// <summary>
    /// Логика взаимодействия для CharacterEditorPage.xaml
    /// </summary>
    public partial class CharacterEditorPage : Page
    {
        Unit CurrentUnit {  get; set; }
        public CharacterEditorPage(Unit currentUnit)
        {
            InitializeComponent();
            CurrentUnit = currentUnit;
            Refresh();
            var timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void IncreaseStrenght_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUnit.MStrength <= CurrentUnit.Strength) { }
            else
            {
                CurrentUnit.Strength += 1;
                Refresh();
            }
        }

        private void IncreaseDexterity_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUnit.MDexterity <= CurrentUnit.Dexterity)
            {

            }
            else
            {
                CurrentUnit.Dexterity += 1;
                Refresh();
            }
        }

        private void IncreaseInteligence_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUnit.MInteligence <= CurrentUnit.Inteligence)
            {

            }
            else
            {
                CurrentUnit.Inteligence += 1;
                Refresh();
            }
        }

        private void IncreaseVitality_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUnit.MVitality <= CurrentUnit.Vitality)
            {

            }
            else
            {
                CurrentUnit.Vitality += 1;
                Refresh();
            }
        }
        public void Refresh()
        {
            DataContext = null;
            DataContext = CurrentUnit;
            InventoryCb.ItemsSource = CurrentUnit.Weapons.ToList();
            InventoryCb.DisplayMemberPath = "Name";
        }

        private void AddNewWeaponPage_Click(object sender, RoutedEventArgs e)
        {
            InventoryBtn inventoryBtn = new InventoryBtn(CurrentUnit);
            inventoryBtn.Show();
            
        }

        private void InventoryCb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (CurrentUnit.ActiveWeapon is null)
            {
                CurrentUnit.ActiveWeapon = (IWeapon)InventoryCb.SelectedItem;
                CurrentUnit.PDamage += CurrentUnit.ActiveWeapon.PDamage;
                CurrentUnit.MDamage += CurrentUnit.ActiveWeapon.MDamage;
                CurrentUnit.MMana += CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.Mana += CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.MInteligence += CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Inteligence += CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Armor += CurrentUnit.ActiveWeapon.Armor;
                CurrentUnit.MHealth += CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.Health += CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.MDexterity += CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.Dexterity += CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.MStrength += CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.Strength += CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.MVitality += CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.Vitality += CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.CritChance += CurrentUnit.ActiveWeapon.CritChance;
                CurrentUnit.CritDamage += CurrentUnit.ActiveWeapon.CritDamage;
            }
            else
            {
                CurrentUnit.PDamage -= CurrentUnit.ActiveWeapon.PDamage;
                CurrentUnit.MDamage -= CurrentUnit.ActiveWeapon.MDamage;
                CurrentUnit.MMana -= CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.Mana -= CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.MInteligence -= CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Inteligence -= CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Armor -= CurrentUnit.ActiveWeapon.Armor;
                CurrentUnit.MHealth -= CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.Health -= CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.MDexterity -= CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.Dexterity -= CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.MStrength -= CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.Strength -= CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.MVitality -= CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.Vitality -= CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.CritChance -= CurrentUnit.ActiveWeapon.CritChance;
                CurrentUnit.CritDamage -= CurrentUnit.ActiveWeapon.CritDamage;

                CurrentUnit.ActiveWeapon = (IWeapon)InventoryCb.SelectedItem;
                CurrentUnit.PDamage += CurrentUnit.ActiveWeapon.PDamage;
                CurrentUnit.MDamage += CurrentUnit.ActiveWeapon.MDamage;
                CurrentUnit.MMana += CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.Mana += CurrentUnit.ActiveWeapon.Mana;
                CurrentUnit.MInteligence += CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Inteligence += CurrentUnit.ActiveWeapon.Inteligence;
                CurrentUnit.Armor += CurrentUnit.ActiveWeapon.Armor;
                CurrentUnit.MHealth += CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.Health += CurrentUnit.ActiveWeapon.Health;
                CurrentUnit.MDexterity += CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.Dexterity += CurrentUnit.ActiveWeapon.Dexterity;
                CurrentUnit.MStrength += CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.Strength += CurrentUnit.ActiveWeapon.Strenght;
                CurrentUnit.MVitality += CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.Vitality += CurrentUnit.ActiveWeapon.Vitality;
                CurrentUnit.CritChance += CurrentUnit.ActiveWeapon.CritChance;
                CurrentUnit.CritDamage += CurrentUnit.ActiveWeapon.CritDamage;
            }
            if (CurrentUnit.Mana > CurrentUnit.MMana)
            {
                CurrentUnit.Mana = CurrentUnit.MMana;
            }
            if (CurrentUnit.Health > CurrentUnit.MHealth)
            {
                CurrentUnit.Health = CurrentUnit.MHealth;
            }
            if (CurrentUnit.Dexterity > CurrentUnit.MDexterity)
            {
                CurrentUnit.Dexterity = CurrentUnit.MDexterity;
            }
            if(CurrentUnit.Strength > CurrentUnit.MStrength)
            {
                CurrentUnit.Strength = CurrentUnit.MStrength;
            }
            if(CurrentUnit.Vitality > CurrentUnit.MVitality)
            {
                CurrentUnit.Vitality = CurrentUnit.MVitality;
            }
            if(CurrentUnit.Inteligence > CurrentUnit.MInteligence)
            {
                CurrentUnit.Inteligence = CurrentUnit.MInteligence;
            }
        }
    }
}
