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

namespace Dubovik_Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Square> square_action;

        public MainWindow()
        {
            InitializeComponent();
            square_action = new ObservableCollection<Square>();

            listBox.ItemsSource = square_action;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();

            if (dialog.ShowDialog() != true)
            {
                square_action.Add(new Square(Convert.ToDouble(dialog.textBoxA.Text), Convert.ToDouble(dialog.textBoxB.Text)));
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                DialogWindow dialog = new DialogWindow();
                dialog.textBoxA.Text = ((Square)listBox.SelectedItem).a.ToString();
                dialog.textBoxB.Text = ((Square)listBox.SelectedItem).b.ToString();
                
                if (dialog.ShowDialog() != true)
                {
                    square_action[listBox.SelectedIndex] = new Square(Convert.ToDouble(dialog.textBoxA.Text), Convert.ToDouble(dialog.textBoxB.Text));
                }
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            square_action.Remove((Square)listBox.SelectedValue);
        }
    }
}
