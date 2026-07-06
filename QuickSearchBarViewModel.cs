namespace MangaWorld.Models;

public class QuickSearchBarViewModel
{
    public string FormId { get; init; } = "searchForm";

    public string? Search { get; init; }

    public string CurrentSort { get; init; } = string.Empty;

    public string WrapperClass { get; init; } = string.Empty;

    public string SortToggleId { get; init; } = "sortToggle";

    public string SortDropdownId { get; init; } = "sortDropdown";

    public string SortValueInputId { get; init; } = "sortValue";

    public bool LiveSubmit { get; init; }

    public bool SubmitOnSort { get; init; }

    public bool GlobalSearch { get; init; }
}
