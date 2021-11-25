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
using LibVLCSharp.Shared;

namespace SharpPlayer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private LibVLC libvlc;
        public MainWindow()
        {
            InitializeComponent();

            LibVLCSharp.Shared.Core.Initialize("C:\\Apps\\vlc-3.0.16");
            libvlc = new LibVLC();
        }

        private void VideoView_Loaded(object sender, RoutedEventArgs e)
        {
            VideoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(new Media(libvlc, "video.mp4"));
            VideoView.MediaPlayer.Play();
        }
    }
}
