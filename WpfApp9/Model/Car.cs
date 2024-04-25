using System.Collections.ObjectModel;

namespace WpfApp9.Model
{
    public class Car
    {
        public ObservableCollection<Car> Cars { get; set; }

        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string vendor, string model, int year)
        {
            Vendor = vendor;
            Model = model;
            Year = year;
        }
    }
}
