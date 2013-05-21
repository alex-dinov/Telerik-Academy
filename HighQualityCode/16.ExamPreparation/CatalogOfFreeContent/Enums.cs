using System;
using System.Linq;

namespace CatalogOfFreeContent
{
    public enum ContentCommand
    {
        AddBook,
        AddMovie, AddSong,
        AddApplication,
        Update, Find,
    }

    public enum ContentType
    {
        Book,
        Movie,
        Song,
        Application,
    }

    public enum ContentInfo
    {
        Title = 0,        
        Author,
        Size,
        Url,
    }
}
