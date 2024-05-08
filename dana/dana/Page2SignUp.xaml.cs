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

namespace dana
{
    /// <summary>
    /// Interaction logic for Page2SignUp.xaml
    /// </summary>
    public partial class Page2SignUp : Page
    {
        login_Entities db = new login_Entities();
        public Page2SignUp()
        {
            InitializeComponent();
        }

        private void usS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passS_TextChanged1(object sender, TextChangedEventArgs e)
        {

        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uesr_ uesr = new uesr_();
            if (passS.Text.Length >= 8 && Regex.IsMatch(passS.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$"))
            {
                //must be from 18 to 60 
                uesr.Username = usS.Text;
                uesr.Password_ = passS.Text;
              ///  int Age = int.Parse(Agey.Text);
                if (Agey.Text = 18 && Agey.Text >= 60)
                {
                    int Age = int.Parse(Agey.Text);
                }
             //   combo.Text = ComboBox.SelectedIndex;
             if(comboC.Text == comboG.SelectedItem && comboG.SelectedItem== "0" )
                {
                    comboG.SelectedIndex = 0;

                }
          
                else if (comboG.Text == comboG.SelectedItem && comboG.SelectedItem == "1")
                {
                    comboG.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("check your combo box");
                }
                if (comboC.Text == comboC.SelectedItem && comboC.SelectedItem == "0")
                {
                    comboC.SelectedIndex = 0;

                }

                else if (comboC.Text == comboC.SelectedItem && comboC.SelectedItem == "1")
                {
                    comboC.SelectedIndex = 1;
                }
                else if (comboC.Text == comboC.SelectedItem && comboC.SelectedItem == "2")
                {
                    comboC.SelectedIndex = 2;
                }
                else if (comboC.Text == comboC.SelectedItem && comboC.SelectedItem == "3")
                {
                    comboC.SelectedIndex = 3;
                }
                else if (comboC.Text == comboC.SelectedItem && comboC.SelectedItem == "4")
                {
                    comboC.SelectedIndex = 4;
                }
                else
                {
                    MessageBox.Show("check your combo box");
                }

                uesr.Phone_number = phSin.Text;
              //  comboC.Text = ComboBox.SelectedIndex;
                db.uesr_.Add(uesr);
                db.SaveChanges();
                MessageBox.Show("SignUP is done");
                Page1SignIN page1 = new Page1SignIN();
                this.NavigationService.Navigate(page1);



            }
            else
            {
                MessageBox.Show("check your password");
            }
        }
    }
}
