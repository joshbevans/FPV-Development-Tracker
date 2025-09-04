using MudBlazor;

namespace FPVDevelopment.Components.Themes;

public static class AppThemes
{
    // Single theme containing both light + dark palettes
    public static readonly MudTheme AppTheme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#6750A4",
            Secondary = "#625B71",
            Tertiary = "#7D5260",
            Info = "#0288D1",
            Success = "#00C853",
            Warning = "#FFD600",
            Error = "#D32F2F",

            Background = "#FFFBFE",
            Surface = "#FFFBFE",
            TextPrimary = "#1C1B1F",
            TextSecondary = "#49454F",

            AppbarBackground = "#1F1F1F",
            AppbarText = "#FFFFFF",
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#D0BCFF",
            Secondary = "#CCC2DC",
            Tertiary = "#EFB8C8",
            Info = "#81D4FA",
            Success = "#00E676",
            Warning = "#FFD54F",
            Error = "#EF5350",

            Background = "#121212",
            Surface = "#1E1E1E",
            TextPrimary = "#E6E1E5",
            TextSecondary = "#C7C1CF",

            AppbarBackground = "#121212",
            AppbarText = "#FFFFFF",
        }
    };
}