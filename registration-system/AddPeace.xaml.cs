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

namespace registration_system
{
    /// <summary>
    /// Логика взаимодействия для AddPeace.xaml
    /// </summary>
    public partial class AddPeace : Window
    {
        private Peace peace;
        private List<string> peaces;
        public AddPeace()
        {
            InitializeComponent();
            peaces = new List<string>();
            peace = new Peace();
            BoxItem.Items.Add(TypeOfPeace.Add);
            BoxItem.Items.Add(TypeOfPeace.Remove);
        }

        public AddPeace (List<string> it)
        {
            InitializeComponent();
            peaces = new List<string>();
            foreach (string i in it)
            {
                peaces.Add(i);
            }
            peace = new Peace();
            BoxItem.Items.Add(TypeOfPeace.Add);
            BoxItem.Items.Add(TypeOfPeace.Remove);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            
            if (BoxItem.SelectedItem == null || TextItem == null || CountItem == null)
            {
                MessageBox.Show("ERROR!");
            }
            else
            {
                peace.Type = (TypeOfPeace)BoxItem.SelectedItem;
                peace.Name = TextItem.Text;
                peace.Ammout = CountItem.Text;
                peaces.Add(peace.ToString());

                new MainWindow(peaces).Show();
                
            }
        }
    }
}
