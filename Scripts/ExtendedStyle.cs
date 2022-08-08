using UnityEngine;

public class ExtendedStyle
{
    public Color32 FontColor = new();
    public Color32 FontHoverColor = new();
    public int FontSize = -1;

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
    }
}