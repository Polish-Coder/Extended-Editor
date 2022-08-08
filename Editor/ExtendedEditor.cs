using UnityEngine;
using UnityEditor;

public static class ExtendedEditor
{
    public static void Text(string content, ExtendedStyle style = null)
    {
        if(style != null)
            GUILayout.Label(content, style.ConvertToGUIStyle(EditorStyles.label));
        else
            GUILayout.Label(content);
    }

    public static void Space(int pixels = 10)
    {
        GUILayout.Space(pixels);
    }

    public static bool Button(string text)
    {
        return GUILayout.Button(text);
    }

    public static bool Button(string text, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The button style is null");
            return false;
        }

        return GUILayout.Button(text, style.ConvertToGUIStyle(EditorStyles.miniButton));
    }

    public static bool Button(Texture image)
    {
        return GUILayout.Button(image);
    }

    public static bool Button(Texture image, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The button style is null");
            return false;
        }

        return GUILayout.Button(image, style.ConvertToGUIStyle(EditorStyles.miniButton));
    }
}