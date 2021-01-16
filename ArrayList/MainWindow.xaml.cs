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

namespace ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        void add(object sender, RoutedEventArgs e){ 
            arrayList.Add(message.Text);
            MessageBox.Show(message.Text + " has been add.");
        }

        void show(object sender, RoutedEventArgs e){
            MessageBox.Show("These are all data.");
            foreach(string msg in arrayList){
                MessageBox.Show(msg.ToString());
            }           
        }

        void remove(object sender, RoutedEventArgs e){
            arrayList.Clear();
            MessageBox.Show("all data have been remove.");
        }
    }
}
