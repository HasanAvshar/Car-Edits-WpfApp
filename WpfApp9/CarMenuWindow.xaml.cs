using System.Windows;
using WpfApp9.Model;

namespace WpfApp9
{
    public partial class CarMenuWindow : Window
    {
        public Car UpdatedCar { get; set; }

        public CarMenuWindow()
        {
            InitializeComponent();
        }

        public CarMenuWindow(Car car) : this()
        {
            VendorTextBox.Text = car.Vendor;
            ModelTextBox.Text = car.Model;
            YearTextBox.Text = car.Year.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (button.Content == "Add")
            {
                Car newCar = new Car(VendorTextBox.Text, ModelTextBox.Text, int.Parse(YearTextBox.Text));
                (Application.Current.MainWindow as MainWindow)?.AddNewCar(newCar);
                this.Close();
            }
            else
            {
                UpdatedCar = new Car(VendorTextBox.Text, ModelTextBox.Text, int.Parse(YearTextBox.Text));
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
