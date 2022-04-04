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
using ClassLibraryAuthorization.AppDataFiles;

namespace WpfFitness.Pages
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        private Users _currentUser = new Users();

        public Client()
        {
            InitializeComponent();

            DataContext = _currentUser;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                FitnessEntities.GetContext().ChangeTracker
                                .Entries()
                                .ToList()
                                .ForEach(p => p.Reload());
                DGridClient.ItemsSource = FitnessEntities.GetContext().Users.ToList();
            }
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            FitnessEntities.GetContext().Users.Add(_currentUser);

            try
            {
                FitnessEntities.GetContext().SaveChanges();
                MessageBox.Show("Пользователь добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
