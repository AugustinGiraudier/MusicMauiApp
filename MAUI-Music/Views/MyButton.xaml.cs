namespace MAUI_Music.Views;

public partial class MyButton : ContentView
{

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
       propertyName: nameof(Text),
       returnType: typeof(string),
       declaringType: typeof(MyButton),
       defaultValue: ""
       );
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty IconProperty = BindableProperty.Create(
    propertyName: nameof(Icon),
    returnType: typeof(ImageSource),
    declaringType: typeof(MyButton),
    defaultValue: null
    );
    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public MyButton()
	{
		InitializeComponent();
        BindingContext = this;
	}
}