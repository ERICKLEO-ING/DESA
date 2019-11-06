using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace Adicion.View
{
    /// <summary>
    /// Logica di interazione per VirtualKeyboard.xaml
    /// </summary>
    public partial class Teclado : Window, INotifyPropertyChanged
    {
        #region Public Properties
        public Window WIN;
        public PasswordBox P;
        public TextBox T;
        public TextBox L;
        public int Tipo;
        private bool _showNumericKeyboard;
        public bool ShowNumericKeyboard
        {
            get { return _showNumericKeyboard; }
            set { _showNumericKeyboard = value; this.OnPropertyChanged("ShowNumericKeyboard"); }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            private set { _result = value; this.OnPropertyChanged("Result"); }
        }

        #endregion

        #region Constructor

        public Teclado(PasswordBox owner, Window wndOwner)
        {
            Tipo = 1;
            InitializeComponent();
            this.Owner = wndOwner;
            P = owner;
            WIN = wndOwner;
            this.DataContext = this;
            lblTexto.Visibility = Visibility.Hidden;
            lblPass.Visibility = Visibility.Visible;
            Result = "";
            P.Password = "";
        }
        public Teclado(TextBox owner, Window wndOwner)
        {
            Tipo = 0;
            InitializeComponent();
            this.Owner = wndOwner;
            T = owner;
            WIN = wndOwner;
            this.DataContext = this;
            lblTexto.Visibility = Visibility.Visible;
            Result = "";
            T.Text = "";
        }
        public Teclado(TextBox owner, UserControl wndOwner)
        {
            Tipo = 2;
            InitializeComponent();
            L = owner;
            this.DataContext = this;
            lblTexto.Visibility = Visibility.Visible;
            Result = "";
            L.Text = "";
        }
        #endregion

        #region Callbacks

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                switch (button.CommandParameter.ToString())
                {
                    case "LSHIFT":
                        Regex upperCaseRegex = new Regex("[A-Z]");
                        Regex lowerCaseRegex = new Regex("[a-z]");
                        Button btn;
                        foreach (UIElement elem in AlfaKeyboard.Children) //iterate the main grid
                        {
                            Grid grid = elem as Grid;
                            if (grid != null)
                            {
                                foreach (UIElement uiElement in grid.Children)  //iterate the single rows
                                {
                                    btn = uiElement as Button;
                                    if (btn != null) // if button contains only 1 character
                                    {
                                        if (btn.Content.ToString().Length == 1)
                                        {
                                            if (upperCaseRegex.Match(btn.Content.ToString()).Success) // if the char is a letter and uppercase
                                                btn.Content = btn.Content.ToString().ToLower();
                                            else if (lowerCaseRegex.Match(button.Content.ToString()).Success) // if the char is a letter and lower case
                                                btn.Content = btn.Content.ToString().ToUpper();
                                        }

                                    }
                                }
                            }
                        }
                        break;

                    case "ALT":
                    case "ESC":
                        Result = "";
                        if (Tipo == 2)
                        {
                            L.Text = Result;
                        }
                        if (Tipo == 1)
                        {
                            P.Password = Result;
                            lblPass.Content = string.Empty.PadLeft(Result.Count(), '*');
                        }
                        if (Tipo == 0)
                        {
                            T.Text = Result;
                        }
                        this.Close();
                        break;
                    case "CTRL":
                        break;

                    case "RETURN":
                        // this.DialogResult = true;
                        this.Close();
                        break;

                    case "BACK":
                        if (Result.Length > 0)
                        {
                            Result = Result.Remove(Result.Length - 1);
                            if (Tipo == 2)
                            {
                                L.Text = Result;
                            }
                            if (Tipo == 1)
                            {
                                P.Password = Result;
                                lblPass.Content = string.Empty.PadLeft(Result.Count(), '*');
                            }
                            if (Tipo == 0)
                            {
                                T.Text = Result;
                            }
                        }
                        break;

                    default:
                        Result += button.Content.ToString();
                        if (Tipo == 2)
                        {
                            L.Text += button.Content.ToString();
                        }
                        if (Tipo == 1)
                        {
                            P.Password += button.Content.ToString();
                            lblPass.Content = string.Empty.PadLeft(Result.Count(), '*');
                        }
                        if (Tipo == 0)
                        {
                            T.Text += button.Content.ToString();
                        }
                        break;
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
