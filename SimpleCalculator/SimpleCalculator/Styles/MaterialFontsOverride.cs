namespace SimpleCalculator.Styles;
using Uno.Extensions.Markup;

public sealed class MaterialFontsOverride : ResourceDictionary
{
    public MaterialFontsOverride()
    {
        this.Build(
            r => r
            .Add("LabelLargeFontSize", 32));


    }
}
