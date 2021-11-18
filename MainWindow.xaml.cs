using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace NewSuperIdleFarmer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int unidades = 0;
        private int contador = -5;
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            void dispatcherTimer_Tick(object sender, EventArgs e)
            {
                contador+=5;
                if(contador > 100)
                {
                    unidades++;
                    texto.Content = $"Veces que deberías cerrar este programa e irte a dormir: {unidades}";
                    contador = 0;
                }
                progress.Value = contador;
            }
        }

    }
}
