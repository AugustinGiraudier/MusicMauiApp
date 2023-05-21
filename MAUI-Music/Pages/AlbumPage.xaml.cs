using MAUI_Music.Model;

namespace MAUI_Music.Pages;

public partial class AlbumPage : ContentPage
{

	public Album Album { get; set; }
	public string summary { get; set; }

	public AlbumPage(Album album = null)
	{
		InitializeComponent();
		Album = album;

		int minutesCount = 0;
		foreach (var item in Album.Musics)
		{
			minutesCount += item.Duration;
		}

		summary = $"{Album.Musics.Count} morceaux, {minutesCount} minutes";

		BindingContext = this;
	}


}