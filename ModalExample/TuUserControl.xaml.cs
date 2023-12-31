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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModalExample
{
    /// <summary>
    /// Lógica de interacción para TuUserControl.xaml
    /// </summary>
    public partial class TuUserControl : UserControl
    {
        public TuUserControl()
        {
            InitializeComponent();
        }
        public void MostrarModal()
        {
            var animation = new DoubleAnimation
            {
                From = ActualHeight ,  // Altura inicial (fuera de la pantalla)
                To = 300,               // Altura final (en la parte superior)
                Duration = TimeSpan.FromSeconds(0.5)
            };

              this.Visibility = Visibility.Visible;
            // Asignar la animación al TranslateTransform del UserControl
            RenderTransform = new TranslateTransform();
            RenderTransform.BeginAnimation(TranslateTransform.YProperty, animation);
        }

        private void CerrarModal_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para cerrar el modal (puedes ocultar o cerrar el UserControl)
            var animation = new DoubleAnimation
            {
                From = 300,               // Altura inicial (en la parte superior)
                To = ActualHeight ,      // Altura final (fuera de la pantalla)
                Duration = TimeSpan.FromSeconds(0.5)
            };

            RenderTransform.BeginAnimation(TranslateTransform.YProperty, animation);
        }
    }
}
