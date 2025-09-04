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
            PrimaryContrastText = "#FFFFFF", 
            Secondary = "#625B71",
            SecondaryContrastText = "#FFFFFF",
            Tertiary = "#7D5260",
            TertiaryContrastText = "#FFFFFF",
            Info = "#0288D1",
            InfoContrastText = "#FFFFFF",
            Success = "#00C853",
            SuccessContrastText = "#FFFFFF",
            Warning = "#FFD600",
            WarningContrastText = "#000000",
            Error = "#D32F2F",
            ErrorContrastText = "#FFFFFF",

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
            PrimaryContrastText = "#000000", 
            Secondary = "#CCC2DC",
            SecondaryContrastText = "#000000",
            Tertiary = "#EFB8C8",
            TertiaryContrastText = "#000000",
            Info = "#81D4FA",
            InfoContrastText = "#000000",
            Success = "#00E676",
            SuccessContrastText = "#000000",
            Warning = "#FFD54F",
            WarningContrastText = "#000000",
            Error = "#EF5350",
            ErrorContrastText = "#000000",

            Background = "#121212",
            Surface = "#1E1E1E",
            TextPrimary = "#E6E1E5",
            TextSecondary = "#C7C1CF",

            AppbarBackground = "#121212",
            AppbarText = "#FFFFFF",
        }
    };
}