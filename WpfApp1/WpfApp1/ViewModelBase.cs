using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using WpfApp1;

public class MainWindowViewModel : ObservableObject
{
    private string _title = "Hello, Zcb!";

    public MainWindowViewModel()
    {
        ButonClickCommand = new RelayCommand(OnButtonClick);
    }

    private void OnButtonClick()
    {
        ;
    }

    public string Title
    {
        get { return _title; }
        set
        {
            if (_title != value)
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
    }

    private string _content = "Welcome to WPF!";

    public string Content
    {
        get { return _content; }
        set => SetProperty(ref _content, value);
    }

    public RelayCommand ButonClickCommand { get; }
}