namespace SimpleCalculator.Styles;
using Uno.Extensions.Markup;
using Microsoft.UI.Xaml;

public sealed class MaterialFontsOverride : ResourceDictionary
{
    public MaterialFontsOverride()
    {
        this.Build(
            r => r
            .Add("LabelLargeFontSize", 32));

    }
}
