// Updated by XamlIntelliSenseFileGenerator 5/28/2023 10:53:43 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E41E357DC4291376E202C46D2ABE19D54447BFCB7BE861EE510938A73D8ECD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WpfApp
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;

#line default
#line hidden


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextButton;

#line default
#line hidden


#line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button repeatButton;

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shuffleButton;

#line default
#line hidden


#line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label currentPositionLabel;

#line default
#line hidden


#line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider positionSlider;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Плеер;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 13 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectFolderButton_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.previousButton = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\MainWindow.xaml"
                    this.previousButton.Click += new System.Windows.RoutedEventHandler(this.PreviousButton_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.playButton = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.playButton.Click += new System.Windows.RoutedEventHandler(this.PlayButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.nextButton = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\MainWindow.xaml"
                    this.nextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.repeatButton = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\MainWindow.xaml"
                    this.repeatButton.Click += new System.Windows.RoutedEventHandler(this.RepeatButton_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.shuffleButton = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\MainWindow.xaml"
                    this.shuffleButton.Click += new System.Windows.RoutedEventHandler(this.ShuffleButton_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.currentPositionLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.positionSlider = ((System.Windows.Controls.Slider)(target));

#line 25 "..\..\MainWindow.xaml"
                    this.positionSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.PositionSlider_ValueChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button previousButton;
    }
}

