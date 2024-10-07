using System.Collections.ObjectModel;

namespace MobileWithMAUI.Models;

public class PhotoViewModel
{
    private ObservableCollection<Photo> _photos { get; set; }

    public ObservableCollection<Photo> Photos
    {
        get => _photos;
        set => _photos = value;
    }

    public PhotoViewModel()
    {
        Photos =
        [
            new Photo { Name = "Foto 1", ImageUrl = "alarm.svg" },
            new Photo { Name = "Foto 2", ImageUrl = "avatar.svg" },
            new Photo { Name = "Foto 3", ImageUrl = "camera.svg" },
            new Photo { Name = "Foto 4", ImageUrl = "chat.svg" },
            new Photo { Name = "Foto 5", ImageUrl = "earphone.svg" },
            new Photo { Name = "Foto 6", ImageUrl = "email.svg" },
            new Photo { Name = "Foto 7", ImageUrl = "gallery.svg" },
            new Photo { Name = "Foto 8", ImageUrl = "location.svg" }
        ];
    }
}
