using UnityEngine;
using UnityEditor;

public static class ExtendedEditor
{
    #region Text
    public static void Text(string content)
    {
        GUILayout.Label(content);
    }

    public static void Text(string content, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The text style is null");
            return;
        }

        GUILayout.Label(content, style.ConvertToGUIStyle(EditorStyles.label));
    }
    #endregion

    #region Image
    public static void Image(Texture image)
    {
        GUILayout.Box(image);
    }

    public static void Image(Texture image, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The image style is null");
            return;
        }

        GUILayout.Box(image, style.ConvertToGUIStyle(GUI.skin.box));
    }
    #endregion

    #region Space
    public static void Space()
    {
        GUILayout.Space(10);
    }

    public static void Space(int pixels)
    {
        GUILayout.Space(pixels);
    }
    #endregion

    #region Button
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
    #endregion
}