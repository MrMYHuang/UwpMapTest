using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpMapTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // (near) center on Taiwan     
        Geopoint twCenter =
            new Geopoint(new BasicGeoposition()
            {
                Latitude = 23.6,
                Longitude = 120.982024

            });

        public MainPage()
        {
            this.InitializeComponent();
            var spacing = 1;
            for (var r = 0; r < 5; r++)
            {
                for (var c = 0; c < 5; c++)
                {
                    var e = new Ellipse {
                        Width = 100,
                        Height = 100,
                        Fill = new SolidColorBrush(Colors.Green)
                    };
                    var gp = new Geopoint(new BasicGeoposition()
                    {
                        Latitude = twCenter.Position.Latitude + r * spacing,
                        Longitude = twCenter.Position.Longitude + c * spacing

                    });
                    map.Children.Add(e);
                    MapControl.SetLocation(e, gp);
                    MapControl.SetNormalizedAnchorPoint(e, new Point(0.5, 0.5));

                }
            }
        }
    }
}
