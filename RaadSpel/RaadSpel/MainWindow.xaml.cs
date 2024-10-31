using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RaadSpel
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
        int teRadenGetal;
        int aantalPogingen;
        Random random = new Random();

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void evaluatieButton_Click(object sender, RoutedEventArgs e)
        {
           if (int.TryParse(numberTextBox.Text, out int gebruikersgetal))
            {
                aantalPogingen++;

                if (gebruikersgetal == teRadenGetal)
                {
                    output1TextBox.Text = "Proficiat! U hebt het getal geraden!";
                }
                else if (gebruikersgetal > teRadenGetal)
                {
                    output1TextBox.Text = "Raad lager!";
                }
                else if (gebruikersgetal < teRadenGetal)
                {
                    output1TextBox.Text = "Raad hoger!";
                }
                output2TextBox.Text = $"Aantal keren geraden: {aantalPogingen}";
            }
           else
            {
                output1TextBox.Text = "Voer een geldig getal in!";
            }
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            teRadenGetal = random.Next(1, 101);
            aantalPogingen = 0;
            output1TextBox.Text = "Raad het getal!";
            output2TextBox.Text = "Aantal keren geraden: 0";
        }
    }
}