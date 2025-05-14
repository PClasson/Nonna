using MudBlazor;

namespace Nonna.Web.Themes
{
    public static class NonnaThemes
    {
        public static MudTheme PrimaryTheme = new MudTheme()
        {
            PaletteDark = new PaletteDark()
            {
                Primary = "#ffffff",  // Straight white for clarity
                Secondary = "#81a079",  // Olive-toned green for warmth
                Tertiary = "#3e101b",  // Deep red for elegance
                Background = "#e0d3c3",  // Creamy beige for an inviting feel
                Surface = "#f5e7d3",  // Softer beige for subtle contrast
                TextPrimary = "#3e101b",  // Rich red for primary text
                TextSecondary = "#81a079",  // Green for secondary elements
                Info = "#81a079",
                Success = "#5cb85c",  // Keeping green for success indicators
                Warning = "#f0ad4e",  // Warm amber for warnings
                Error = "#d9534f",  // Strong red for errors
            },
            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" }
                },
                H3 = new H3Typography
                {

                }
            }
        };
    }
}
