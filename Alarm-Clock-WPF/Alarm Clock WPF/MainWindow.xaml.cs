using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Dynamic;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Web;
using System.Timers;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace Alarm_Clock_WPF
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer1 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer2 = new DispatcherTimer();
        public MainWindow()
        {
            System.Windows.Threading.DispatcherTimer dispathcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer1.Tick += new EventHandler(dispatcherTimer1_Tick);
            dispatcherTimer2.Tick += new EventHandler(dispatcherTimer2_Tick);
            dispatcherTimer1.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer1.Start();
            dispatcherTimer2.Start();
            InitializeComponent();
        }

        private void dispatcherTimer1_Tick(object sender, EventArgs e)
        {
            CountTime.Content = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");

            if (CountTime.Content.Equals(TriggerTime.Content))
            {
                DateTime now2 = DateTime.Now;
                string date1 = DateTime.Today.ToString("D");
                string time2 = now2.GetDateTimeFormats('t')[0];
                //Label Leave Animation
                //DoubleAnimation animation = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
                //label4.BeginAnimation(OpacityProperty, animation);
                System.Diagnostics.Process.Start("https://www.youtube.com/");
                //Music
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\deltagi\Documents\Wake up theme 01.wav");
                sp.Play();
                //Video
                //Video beach = new Video(@"C:\Users\deltagi\Desktop\Jarvis\...avi");
                //beach.Play();
                label1.Content = "Done";
                //Actual Wake Up Call
                dispatcherTimer1.Stop();
            }
        }

        private void dispatcherTimer2_Tick(object sender, EventArgs e)
        {
            //Alarm settings
            if (CountTime.Content == TriggerTime.Content)
            {
                DateTime now2 = DateTime.Now;
                string date1 = DateTime.Today.ToString("D");
                string time2 = now2.GetDateTimeFormats('t')[0];
                //Label Leave Animation
                //DoubleAnimation animation = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
                //label4.BeginAnimation(OpacityProperty, animation);
                System.Diagnostics.Process.Start("https://www.youtube.com/");
                //Music
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\deltagi\Documents\Wake up theme 01.wav");
                sp.Play();
                //Video
                //Video beach = new Video(@"C:\Users\deltagi\Desktop\Jarvis\...avi");
                //beach.Play();
                label1.Content = "Done";
                //Actual Wake Up Call
                dispatcherTimer1.Stop();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TriggerTime.Content = DateTime.Today.Hour.ToString("15") + ":" + DateTime.Today.Minute.ToString("07") + ":" + DateTime.Today.Second.ToString("10");
        }
    }
}
