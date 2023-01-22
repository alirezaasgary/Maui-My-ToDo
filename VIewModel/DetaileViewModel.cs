using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_ToDo.VIewModel
{
    [QueryProperty("Text","Text")]
    public partial class DetailViewModel:ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBake()
        {
            //await Shell.Current.GoToAsync(nameof(MainPage));
            await Shell.Current.GoToAsync("..");

        }
    }
}
