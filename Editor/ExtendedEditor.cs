using System;
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

    #region Divider
    public static void Divider()
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void Divider(int thickness)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void Divider(RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void Divider(int thickness, RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
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

    #region Layouts
    public static void HorizontalLayout(Action action)
    {
        GUILayout.BeginHorizontal();

        action();

        GUILayout.EndHorizontal();
    }

    public static void VerticalLayout(Action action)
    {
        GUILayout.BeginVertical();

        action();

        GUILayout.EndVertical();
    }

    public static void AreaLayout(Rect size, Action action)
    {
        GUILayout.BeginArea(size);

        action();

        GUILayout.EndArea();
    }
    #endregion

    static Texture2D SolidTexture(Color32 color)
    {
        Texture2D texture = new(1, 1);
        texture.SetPixel(0, 0, color);
        texture.Apply();
        return texture;
    }
}