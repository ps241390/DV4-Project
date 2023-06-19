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
using System.Windows.Threading;

namespace WpfAppIfIfI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 0;
        private DispatcherTimer _timer;
        private int _Millieseconds = 50;
        private bool _started = false;
        private int _clicks = 0;
        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += _timer_Tick;

        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {

                //MessageBox.Show("Not ready Yet, integer counter has now the value " + _counter);


                //MessageBox.Show("Hurray, now we are ready ;-)");

        }

        private void btChangeColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btIfStatement_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem ComboItemSelectedCar = (ComboBoxItem)cmbCar.SelectedItem;
            string selectedCar = ComboItemSelectedCar.Content.ToString();

            
        }

        private void btClickIt_Click(object sender, RoutedEventArgs e)
        {
            if (!_started)
            {
                _timer.Start();
            }
            _clicks++;
            tbClicks.Text = _clicks.ToString();
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_Millieseconds > 0)
            {
                _Millieseconds--;
                tbCounter.Text = _Millieseconds.ToString();
            }
            else
            {
                //extrawindow
                MessageBox.Show("The time is over, your number of clicks is " + _clicks);
                _timer.Stop();
                _clicks = 0;
                _started = false;
                _Millieseconds = 50;
            }
            //kaasje
        }

        private void btClickit(object sender, RoutedEventArgs e)
        {

        }

        private void Volkswagen(object sender, ContextMenuEventArgs e)
        {
           
        }
    }
}
   
