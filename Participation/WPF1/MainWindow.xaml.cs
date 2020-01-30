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

namespace WPF1
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EntryForm ef = new EntryForm();
            ef.Name = txtName.Text;
            ef.Address = txtAddress.Text;
            ef.ZipCode = Convert.ToInt32(txtZip.Text);

            lstUsers.Items.Add(ef);
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
