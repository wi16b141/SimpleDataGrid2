using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace SimpleDataGrid2.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private AnimalVM animal;

        public AnimalVM Animal
        {
            get { return animal; }
            set { animal = value; RaisePropertyChanged(); }
        }

        private AnimalVM selectedAnimal;

        public AnimalVM SelectedAnimal
        {
            get { return selectedAnimal; }
            set { selectedAnimal = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<AnimalVM> Animals { get; set; }
        public ObservableCollection<string> Habitates { get; set; }
        public RelayCommand BtnDeleteClicked { get; set; }
        
        public MainViewModel()
        {
            animal = new AnimalVM();
            Animals = new ObservableCollection<AnimalVM>();
            Habitates = new ObservableCollection<string>();

            LoadData();
            BtnDeleteClicked = new RelayCommand(() => Animals.Remove(selectedAnimal), () => { return selectedAnimal != null;  });

        }

        public void LoadData()
        {
            Habitates.Add("Dschungel");
            Habitates.Add("Süßwasser");
            Habitates.Add("Steppe");
            Habitates.Add("Luft");

            Animals.Add(new AnimalVM("Tiger", 10, "Raubkatze", "Dschungel", 7000, true));
            Animals.Add(new AnimalVM("Goldbrasse", 4, "Fisch", "Süßwasser", 70000, false));
            Animals.Add(new AnimalVM("Coala", 20, "Beuteltier", "Steppe", 6000, false));
            Animals.Add(new AnimalVM("Eisvogel", 1, "Vogel", "Luft", 5000, true));
        }
    }
}