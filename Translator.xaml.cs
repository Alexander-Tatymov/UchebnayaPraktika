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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Translator.xaml
    /// </summary>
    public partial class Translator : Window
    {
        public Translator()
        {
            InitializeComponent();
        }

         private readonly Dictionary<string, string> Words = new Dictionary<string, string>
        {
            { "жарко", "Hot" },
            { "тепло", "Warm" },
            { "ясно", "Clear" },
            { "солнечно", "Sunny" },
            { "ветрено", "Windy" },
            { "дождь", "Rain" },
            { "туман", "Fog" },
            { "туманно", "Foggy" },
            { "дымка", "Mist" },
            { "лёгкая дымка", "Haze" },
            
        };


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }

        private void Translate_Click(object sender, RoutedEventArgs e)
        {
            string input = WordA.Text.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                WordB.Text = "";
                return;
            }

            if (Words.TryGetValue(input, out string translation))
            {
                WordB.Text = translation;
            }
            else
            {
                MessageBox.Show("Ошибка, такого слова нет!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                WordB.Text = "";
            }
        }

    }


}
