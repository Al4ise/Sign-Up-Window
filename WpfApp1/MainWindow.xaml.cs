using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool isEmpty (string s)
        {
            return s == null;
        }
        public bool specialCharIncluded (string s) {
            string specials = "!@*_?.,";
            char[] special = specials.ToCharArray();
            foreach (char c in special)
            {
                if (s.Contains (c)) return true;
            }
            return false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtFirstName == null)
            {
                MessageBox.Show("First name cannot be left empty");
            }
            else if (txtlastName == null)
            {
                MessageBox.Show("Last name cannot be left empty");
            }
            else if (txtUsername == null)
            {
                MessageBox.Show("Username cannot be left empty");
            }
            else if (!txtEmail.Text.Contains("@")) {
                MessageBox.Show("Invalid Email");
            }
            else if (txtPassword.Password.Length < 8 || !specialCharIncluded(txtPassword.Password)){
                 MessageBox.Show("One or more password requirements are unfulfilled");
            }
            else
            {
                MessageBox.Show("Sign Up Successful.\n " +
                    $"Username={txtUsername}\n" +
                    $"FirstName={txtFirstName}\n" +
                    $"LastName={txtlastName} \n" +
                    $"Password={txtPassword}"
                    );
            }

        }
    }
}
