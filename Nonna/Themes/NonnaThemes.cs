using MudBlazor;

namespace Nonna.Web.Themes
{
    public static class NonnaThemes
    {
        public static MudTheme PrimaryTheme = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Background = "#fcf8f3",
                TextPrimary = "#1F1F21",
                TextSecondary = "#839c7d",
                Primary = "#839c7d",
                Secondary = "#7c6382",
                Tertiary = "#3e101b",  // Deep red for elegance
                Surface = "#FFFFFF",  // Softer beige for subtle contrast
                Info = "#81a079",
                Success = "#5cb85c",  // Keeping green for success indicators
                Warning = "#f0ad4e",  // Warm amber for warnings
                Error = "#d9534f",  // Strong red for errors
            },
            Typography = new Typography
            {
                H1 = new H1Typography()
                {
                    FontFamily = ["Italiana"],
                },
                H4 = new H4Typography()
                {
                    FontFamily = ["Meow Script"],
                },
                H5 = new H5Typography()
                {
                    FontFamily = ["Quicksand"],
                    FontSize = "2.5rem"
                },
                H6 = new H6Typography()
                {
                    FontFamily = ["Quicksand"]
                }
            }
        };
    }
}
