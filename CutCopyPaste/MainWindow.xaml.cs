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

namespace CutCopyPaste
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pastText = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            pastText = textbox1.SelectedText;
            
        }

        private void paste_Click(object sender, RoutedEventArgs e)
        {

            if (textbox2.Text != "")
            {
                textbox2.Text += pastText;
            }
            else
            {
                textbox2.Text = pastText;
            }

        }
        private void cut_Click(object sender, RoutedEventArgs e)
        {
            pastText = textbox1.SelectedText;
            textbox1.SelectedText = "";

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
        }
    }
}
