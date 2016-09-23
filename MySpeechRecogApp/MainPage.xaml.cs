using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MySpeechRecogApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void TTS_Example_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TextToSpeechPage));
        }

        private void STTusingListContraint_Example_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SpeechToTextUsingList));
        }

        private void SRGSContinuous_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContinuousDictionaryRecog));
        }
    }
}
