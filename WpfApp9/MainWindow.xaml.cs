using System.Windows;
using System.Windows.Input;
using WpfApp9.Model;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2022),
                new Car("Honda", "Civic", 2021),
                new Car("Ford", "Focus", 2020)
            };
            listView.ItemsSource = cars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CarMenuWindow carMenuWindow = new CarMenuWindow();
            carMenuWindow.button.Content = "Add";
            carMenuWindow.Show();
        }

        public void AddNewCar(Car car)
        {
            List<Car> cars = listView.ItemsSource as List<Car>;
            cars.Add(car);
            listView.ItemsSource = null;
            listView.ItemsSource = cars;
        }
        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Car selectedCar = listView.SelectedItem as Car;
            if (selectedCar != null)
            {
                CarMenuWindow carMenuWindow = new CarMenuWindow(selectedCar);
                carMenuWindow.ShowDialog();
                if (carMenuWindow.UpdatedCar != null)
                {
                    int index = listView.SelectedIndex;
                    List<Car> cars = listView.ItemsSource as List<Car>;
                    cars[index] = carMenuWindow.UpdatedCar;
                    listView.ItemsSource = null;
                    listView.ItemsSource = cars;
                }
            }
        }
    }
}