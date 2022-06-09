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

namespace Napkin_Quick_Thought
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Checked = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        void ClearText()
        {
            pgThought.Inlines.Clear();
        }

        private void rtbThought_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!Checked)
            {
                ClearText();
                rtbThought.FontStyle = FontStyles.Normal;
            }
        }
    }
}
