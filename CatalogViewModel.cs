using MangaWorld.DTO;

namespace MangaWorld.Models
{
    public class CatalogViewModel
    {
        public CatalogQueryDto Query { get; set; } = new();

        public IReadOnlyList<Manga> Mangas { get; set; } = Array.Empty<Manga>();

        public IReadOnlyList<CatalogFilterOptionViewModel> Genres { get; set; } = Array.Empty<CatalogFilterOptionViewModel>();

        public IReadOnlyList<CatalogFilterOptionViewModel> Tags { get; set; } = Array.Empty<CatalogFilterOptionViewModel>();
    }
}