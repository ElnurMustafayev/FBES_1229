using ConfigurationApp.Models;

namespace ConfigurationApp.ViewModels
{
    public class PaletteViewModel
    {
        public Palette Palette { get; set; }

        public PaletteViewModel(Palette palette)
        {
            this.Palette = palette;
        }
    }
}