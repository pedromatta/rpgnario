using MudBlazor;
using MudBlazor.Utilities;

namespace RpgNario.Web.Layout;

public sealed class RpgNarioPalette : PaletteDark
{
    private RpgNarioPalette()
    {
        Primary = new MudColor("#A1887F");
        Secondary = new MudColor("#558B2F");
        Tertiary = new MudColor("#BF360C");

        Background = new MudColor("#212121");
        Surface = new MudColor("#333333");
        DrawerBackground = new MudColor("#212121");
        AppbarBackground = new MudColor("#272727");
    }
    public static RpgNarioPalette CreatePalette => new();
}