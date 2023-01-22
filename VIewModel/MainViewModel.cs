
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace My_ToDo.VIewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(Text))
                return;
            items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove( string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(Detail)}?Text={s}");
            
                //new Dictionary<string, object>
                //{
                //    {nameof(Detail), new object());
                //}

        }
    }
}
