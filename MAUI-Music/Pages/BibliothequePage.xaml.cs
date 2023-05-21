using MAUI_Music.Model;
using System.Collections.ObjectModel;

namespace MAUI_Music.Pages;

public partial class BibliothequePage : ContentPage
{
	public List<Album> Albums { get; set; }

	public BibliothequePage()
	{
		InitializeComponent();

		Albums = new List<Album>
		{
			new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
				Musics=new List<Music>{
					new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
			},
            new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
                Musics=new List<Music>{
                    new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
            },
            new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
                Musics=new List<Music>{
                    new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
            },
            new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
                Musics=new List<Music>{
                    new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
            },
            new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
                Musics=new List<Music>{
                    new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
            },
            new Album{Name="Ceinture Noire", Author="GIMS", Date="12/03/2018", Genre="rap", Image="ceinturenoire", Year=2018,
                Musics=new List<Music>{
                    new Music{Name="Habibi", Duration=120, Index=1},
                    new Music{Name="Bella", Duration=130, Index=2},
                }
            },
        };

		BindingContext = this;
	}

    private void OnAlbumClicked(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Album clickedAlbum)
            Navigation.PushAsync(new AlbumPage(clickedAlbum));

        ((CollectionView)sender).SelectedItem = null;
    }
}
