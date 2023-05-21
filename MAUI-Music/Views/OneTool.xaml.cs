namespace MAUI_Music.Views;

public partial class OneTool : ContentView
{
	public string Text {
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}
	public static BindableProperty TextProperty = BindableProperty.Create(nameof(TextProperty), typeof(string), typeof(OneTool), string.Empty);

	

	public OneTool()
	{
		InitializeComponent();
	}
}
