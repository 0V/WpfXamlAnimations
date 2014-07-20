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

namespace HorrorControls
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //            CreateEyes(150);
        }

        /// <summary>
        /// ぐりぐり動く移動可能な目を指定数作りhorrorPanel内に配置します
        /// </summary>
        public void CreateEyes(int count)
        {
            var thickness = new Thickness(20);
            var cursor = Cursors.Hand;
            for (int i = 0; i < count; i++)
            {
                var eyeControl = new HorrorEye();
                eyeControl.Margin = thickness;
                eyeControl.Cursor = cursor;
                horrorPanel.Children.Add(eyeControl);
            }
        }
    }
}
