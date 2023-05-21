namespace MAUI_Music.Views;

public partial class VueTest : ContentView
{
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(OneTool), string.Empty);
    
   

    public VueTest()
	{
		InitializeComponent();
	}
}
