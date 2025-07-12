using MudBlazor;
using MudBlazor.Utilities;

namespace CompendioRpgBr.Web.Layout;

public sealed class CompendioRpgBrPalette : PaletteDark
{
    private CompendioRpgBrPalette()
    {
        Primary = new MudColor("#9966FF");
        Secondary = new MudColor("#F6AD31");
        Tertiary = new MudColor("#8AE491");
    }

    public static CompendioRpgBrPalette CreatePalette => new();
}