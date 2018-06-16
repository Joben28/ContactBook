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

namespace ContactBookApp.View
{
    /// <summary>
    /// Interaction logic for DetailPanelView.xaml
    /// </summary>
    public partial class DetailPanelView : UserControl
    {


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }



        public string FirstSubTitle
        {
            get { return (string)GetValue(FirstSubTitleProperty); }
            set { SetValue(FirstSubTitleProperty, value); }
        }



        public string SecondSubTitle
        {
            get { return (string)GetValue(SecondSubTitleProperty); }
            set { SetValue(SecondSubTitleProperty, value); }
        }



        public string[] DetailValues
        {
            get { return (string[])GetValue(DetailValuesProperty); }
            set { SetValue(DetailValuesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DetailValues.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DetailValuesProperty =
            DependencyProperty.Register("DetailValues", typeof(string[]), typeof(DetailPanelView), new PropertyMetadata(new string[] { }));



        // Using a DependencyProperty as the backing store for SecondSubTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondSubTitleProperty =
            DependencyProperty.Register("SecondSubTitle", typeof(string), typeof(DetailPanelView), new PropertyMetadata("SUB TITLE"));



        // Using a DependencyProperty as the backing store for FirstSubTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstSubTitleProperty =
            DependencyProperty.Register("FirstSubTitle", typeof(string), typeof(DetailPanelView), new PropertyMetadata("SUB TITLE"));




        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(DetailPanelView), new PropertyMetadata("TITLE"));



        public DetailPanelView()
        {
            InitializeComponent();
        }
    }
}
