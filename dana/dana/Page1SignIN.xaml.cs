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
    /// Interaction logic for Page1SignIN.xaml
    /// </summary>
    public partial class Page1SignIN : Page
    {
        login_Entities db = new login_Entities();   
        public Page1SignIN()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = db.uesr_.ToList();
            

        }

        private void us_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page3FORGAT fORGAT = new Page3FORGAT();
            this.NavigationService.Navigate(fORGAT);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            uesr_ uesr = new uesr_();
            uesr = db.uesr_.First(x => x.Username == us.Text && x.Password_ == pass.Text);
            if(uesr.Username == us.Text && uesr.Password_ == pass.Text)
            {
                MessageBox.Show("login is done");
                Page4profile page4 = new Page4profile();
                this.NavigationService.Navigate(page4);
            }
            
            DataGrid1.ItemsSource = db.uesr_.ToList();
            DataGrid1 = db.uesr_.Where(x => x.Username == us.Text && x.Password_ == pass.Text).Select(x=>  { x.Username, x.Password_});
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page2SignUp signUp = new Page2SignUp();
            this.NavigationService.Navigate(signUp);
        }

        private void us_TextChanged11(object sender, TextChangedEventArgs e)
        {

        }
    }
}
