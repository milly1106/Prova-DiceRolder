using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Shapes;

namespace DiceRolder
{
    public partial class MainPage : ContentPage
    {
        Random gerando = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        public virtual int Next { get; }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int numero = gerando.Next(1, 11);
            DADOS.Text = $"{numero}";
        }
      
        
    }
}