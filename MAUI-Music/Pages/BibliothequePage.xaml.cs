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
			new Album{Name="Ceinture Noire", Author="GIMS", Date="2018", Genre="rap", Image="ceinturenoire", Year=2018,
				Musics=new List<Music>{
					new Music{Name="Tant pis", Duration=3, Index=1},
                    new Music{Name="Caméléon", Duration=4, Index=2},
                    new Music{Name="Fuegolando", Duration=4, Index=3},
                    new Music{Name="La même", Duration=4, Index=4},
                    new Music{Name="Loup garou", Duration=4, Index=5},
                    new Music{Name="Entre nous c'est mort", Duration=4, Index=6},
                    new Music{Name="Laissez-moi tranquille", Duration=4, Index=7},
                    new Music{Name="Mi Gna", Duration=4, Index=8},
                    new Music{Name="Tu reviendras", Duration=4, Index=9},
                }
			},
            new Album{Name="Random Access Memory", Author="Daft Punk", Date="2023", Genre="electro", Image="ram", Year=2023,
                Musics=new List<Music>{
                    new Music{Name="Give Life Back to Music", Duration=4, Index=1},
                    new Music{Name="The Game of Love", Duration=3, Index=2},
                    new Music{Name="Giorgio by Moroder", Duration=3, Index=3},
                    new Music{Name="Within", Duration=3, Index=4},
                    new Music{Name="Instant Crush ", Duration=3, Index=5},
                    new Music{Name="Lose Yourself to Dance", Duration=3, Index=6},
                    new Music{Name="Touch", Duration=3, Index=7},
                    new Music{Name="Get Lucky", Duration=3, Index=8},
                    new Music{Name="Beyond", Duration=3, Index=9},
                    new Music{Name="Motherboard", Duration=3, Index=10},
                }
            },
            new Album{Name="L’adresse", Author="47ter", Date="2019", Genre="pop", Image="ter", Year=2019,
                Musics=new List<Music>{
                    new Music{Name="Un air qui fait", Duration=4, Index=1},
                    new Music{Name="Personne", Duration=3, Index=2},
                    new Music{Name="L’adresse", Duration=3, Index=3},
                    new Music{Name="On avait dit", Duration=3, Index=4},
                    new Music{Name="30", Duration=3, Index=5},
                    new Music{Name="Sans toi", Duration=3, Index=6},
                    new Music{Name="Harakiri", Duration=3, Index=7},
                    new Music{Name="Côte Ouest", Duration=3, Index=8},
                }
            },
            new Album{Name="Curtain Call 2", Author="Eminem", Date="2022", Genre="rap", Image="eminem", Year=2022,
                Musics=new List<Music>{
                    new Music{Name="Godzilla", Duration=3, Index=1},
                    new Music{Name="Lucky You", Duration=3, Index=2},
                    new Music{Name="Lighters", Duration=3, Index=3},
                    new Music{Name="Gnat", Duration=3, Index=4},
                    new Music{Name="Cinderella Man", Duration=3, Index=5},
                    new Music{Name="Walk On Water", Duration=3, Index=6},
                    new Music{Name="Rap God", Duration=3, Index=7},
                    new Music{Name="Love The Way You Lie", Duration=3, Index=8},
                }
            },
            new Album{Name="racine carrée", Author="Stromae", Date="2013", Genre="rap", Image="stromae", Year=2013,
                Musics=new List<Music>{
                    new Music{Name="Ta fête", Duration=3, Index=1},
                    new Music{Name="Papaoutai", Duration=3, Index=2},
                    new Music{Name="bâtard", Duration=3, Index=3},
                    new Music{Name="ave cesaria", Duration=3, Index=4},
                    new Music{Name="Tous les mêmes", Duration=3, Index=5},
                    new Music{Name="Formidable", Duration=3, Index=6},
                    new Music{Name="moules frites", Duration=3, Index=7},
                    new Music{Name="carmen", Duration=3, Index=8},
                    new Music{Name="humain à l'eau", Duration=3, Index=9},
                    new Music{Name="quand c'est ?", Duration=3, Index=10},
                    new Music{Name="sommeil", Duration=3, Index=11},
                    new Music{Name="merci", Duration=3, Index=12},
                }
            },
            new Album{Name="Sale el Sol", Author="Shakira", Date="2010", Genre="pop", Image="shakira", Year=2010,
                Musics=new List<Music>{
                    new Music{Name="Sale el Sol", Duration=3, Index=1},
                    new Music{Name="Loca", Duration=3, Index=2},
                    new Music{Name="Antes de las Seis", Duration=3, Index=3},
                    new Music{Name="Gordita", Duration=3, Index=4},
                    new Music{Name="Addicted to You", Duration=3, Index=5},
                    new Music{Name="Lo Que Más", Duration=3, Index=6},
                    new Music{Name="Mariposas", Duration=3, Index=7},
                    new Music{Name="Rabiosa", Duration=3, Index=8},
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
