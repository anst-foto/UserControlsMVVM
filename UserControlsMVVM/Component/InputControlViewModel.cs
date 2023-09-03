namespace UserControlsMVVM.Component;

public class InputControlViewModel : BaseViewModel
{
    private string _label;
    public string Label
    {
        get => _label; 
        set => SetField(ref _label, value);
    }
    
    private string _input;
    public string Input
    {
        get => _input; 
        set => SetField(ref _input, value);
    }
}