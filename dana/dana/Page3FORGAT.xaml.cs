using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Page3FORGAT.xaml
    /// </summary>
    public partial class Page3FORGAT : Page
    {
        login_Entities db = new login_Entities();
        public Page3FORGAT()
        {
            InitializeComponent();
        }

        private void phF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PassF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void conF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uesr_ uesr = new uesr_();
            uesr = db.uesr_.First(x => x.Phone_number == phF.Text);
            if (PassF.Text == conF.Text && PassF.Text.Length >= 8 && Regex.IsMatch(PassF.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$"))
            {

                uesr.Phone_number = phF.Text;
                uesr.Password_ = PassF.Text;
                uesr.Password_ = conF.Text;
                db.uesr_.Addorupdate(uesr);
                db.SaveChanges();
                MessageBox.Show("change password is done");
            }
            else
            {
                MessageBox.Show("check your password");
            }
        }
    }
}
