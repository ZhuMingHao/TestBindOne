using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace TestBind
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            this.InitializeComponent();
           
        }
        private DateTimeOffset _dateFromDate;
        private TimeSpan _dateFromTime;
        private DateTimeOffset _dateToDate;
        private TimeSpan _dateToTime;


        private DateTimeOffset DateFromDate
        {
            get => _dateFromDate;
            set
            {
                _dateFromDate = value;
                OnPropertyChanged();
            }
        }
        private TimeSpan DateFromTime
        {
            get => _dateFromTime;
            set
            {

                _dateFromTime = value;
                OnPropertyChanged();

            }
        }

        private DateTimeOffset DateToDate
        {
            get => _dateToDate;
            set
            {
                _dateToDate = value;
                OnPropertyChanged();
            }
        }
        public TimeSpan DateToTime
        {
            get => _dateToTime;

            set
            {

                _dateToTime = value;
                OnPropertyChanged();

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        private string flat;
        private async void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            await TestDelay();
            flat = "has value";
        }
        private Task<bool> TestDelay()
        {
            return Task.Run(() =>
            {
                Task.Delay(1000);
                return true;
            });
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(flat);
        }
    }
}
