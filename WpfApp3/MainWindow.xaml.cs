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
using System.Collections.ObjectModel;
using System.Security.Principal;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TelegramMessageClient client;
        public static string token = "1269041274:AAFrRMmzqHqjWYr4SZDSz6yq_xSTINh2kr4";
       public List<Worker> workers = new List<Worker>();
       


        public MainWindow()
        { 
            InitializeComponent();
            client = new TelegramMessageClient(this);
            ListBOX1.ItemsSource = client.messageLOGs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client.SendMessage(IDtextBox.Text, TextBox1Message.Text);

        }
    }
}
