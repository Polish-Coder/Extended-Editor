using UnityEngine;

public class ExtendedStyle
{
    public Color32 FontColor = new();
    public Color32 FontHoverColor = new();
    public int FontSize = -1;
    public FontStyle FontStyle = new();
    public TextAnchor Alignment = new();
    public Vector2 ContentOffset = new();
    public Color32 BackgroundColor = new();

    public ExtendedStyle() { }

    public ExtendedStyle(GUIStyle other)
    {
        FontColor = other.normal.textColor;
        FontHoverColor = other.hover.textColor;
        FontSize = other.fontSize;
        FontStyle = other.fontStyle;
        Alignment = other.alignment;
        ContentOffset = other.contentOffset;
    }

    public GUIStyle ConvertToGUIStyle()
    {
        GUIStyle style = new();

        SetGUIStyle(new());

        return style;
    }

    public GUIStyle ConvertToGUIStyle(GUIStyle other)
    {
        GUIStyle style = new(other);

        SetGUIStyle(style);

        return style;
    }

    void SetGUIStyle(GUIStyle style)
    {
        style.normal.textColor = !FontColor.Equals(new Color32()) ? FontColor : style.normal.textColor;
        style.hover.textColor = !FontHoverColor.Equals(new Color32()) ? FontHoverColor : style.normal.textColor;
        style.fontSize = FontSize != -1 ? FontSize : style.fontSize;
        style.fontStyle = !FontStyle.Equals(new FontStyle()) ? FontStyle : style.fontStyle;
        style.alignment = !Alignment.Equals(new TextAnchor()) ? Alignment : style.alignment;
        style.contentOffset = !ContentOffset.Equals(Vector2.zero) ? ContentOffset : style.contentOffset;
        style.normal.background = !BackgroundColor.Equals(new Color32()) ? SolidTexture(BackgroundColor) : style.normal.background;
    }

    static Texture2D SolidTexture(Color32 color)
    {
        Texture2D texture = new(1, 1);
        texture.SetPixel(0, 0, color);
        texture.Apply();
        return texture;
    }
}