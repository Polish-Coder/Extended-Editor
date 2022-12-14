using System;
using UnityEngine;
using UnityEditor;

public static class ExtendedEditor
{
    #region Window Size
    public static float WindowWidth(EditorWindow window)
    {
        return window.position.width;
    }

    public static float WindowHeight(EditorWindow window)
    {
        return window.position.height;
    }
    #endregion

    public static class Rects
    {
        public static Rect HorizontalCenter(float x, float y, float width, float height, EditorWindow window)
        {
            return new((x + WindowWidth(window) - width) / 2, y, width, height);
        }

        public static Rect HorizontalCenter(float width, float height, EditorWindow window)
        {
            return new((WindowWidth(window) - width) / 2, 0, width, height);
        }

        public static Rect CustomHorizontalCenter(float x, float y, float width, float height, float containerWidth)
        {
            return new((x + containerWidth - width) / 2, y, width, height);
        }

        public static Rect CustomHorizontalCenter(float width, float height, float containerWidth)
        {
            return new((containerWidth - width) / 2, 0, width, height);
        }

        public static Rect VerticalCenter(float x, float y, float width, float height, EditorWindow window)
        {
            return new(x, (y + WindowHeight(window) - height) / 2, width, height);
        }

        public static Rect VerticalCenter(float width, float height, EditorWindow window)
        {
            return new(0, (WindowHeight(window) - height) / 2, width, height);
        }

        public static Rect CustomVerticalCenter(float x, float y, float width, float height, float containerHeight)
        {
            return new(x, (y + containerHeight - height) / 2, width, height);
        }

        public static Rect CustomVerticalCenter(float width, float height, float containerHeight)
        {
            return new(0, (containerHeight - height) / 2, width, height);
        }
    }

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
    public static void HorizontalDivider()
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(Color32 color)
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(int thickness)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(int thickness, Color32 color)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = new(5, 5, 25, 25);
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(RectOffset margin, Color32 color)
    {
        GUIStyle style = new();
        style.fixedHeight = 2;
        style.margin = margin;
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(int thickness, RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void HorizontalDivider(int thickness, RectOffset margin, Color32 color)
    {
        GUIStyle style = new();
        style.fixedHeight = thickness;
        style.margin = margin;
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length)
    {
        GUIStyle style = new();
        style.fixedWidth = 2;
        style.fixedHeight = length;
        style.margin = new(25, 25, 5, 5);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, Color32 color)
    {
        GUIStyle style = new();
        style.fixedWidth = 2;
        style.fixedHeight = length;
        style.margin = new(25, 25, 5, 5);
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, int thickness)
    {
        GUIStyle style = new();
        style.fixedWidth = thickness;
        style.fixedHeight = length;
        style.margin = new(25, 25, 5, 5);
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, int thickness, Color32 color)
    {
        GUIStyle style = new();
        style.fixedWidth = thickness;
        style.fixedHeight = length;
        style.margin = new(25, 25, 5, 5);
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedWidth = 2;
        style.fixedHeight = length;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, RectOffset margin, Color32 color)
    {
        GUIStyle style = new();
        style.fixedWidth = 2;
        style.fixedHeight = length;
        style.margin = margin;
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, int thickness, RectOffset margin)
    {
        GUIStyle style = new();
        style.fixedWidth = thickness;
        style.fixedHeight = length;
        style.margin = margin;
        style.normal.background = SolidTexture(Color.gray);

        GUILayout.Box("", style);
    }

    public static void VerticalDivider(float length, int thickness, RectOffset margin, Color32 color)
    {
        GUIStyle style = new();
        style.fixedWidth = thickness;
        style.fixedHeight = length;
        style.margin = margin;
        style.normal.background = SolidTexture(color);

        GUILayout.Box("", style);
    }
    #endregion

    #region Button
    public static bool Button(string text)
    {
        return GUILayout.Button(text);
    }

    public static bool Button(Rect rect, string text)
    {
        return GUI.Button(rect, text);
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

    public static bool Button(Rect rect, string text, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The button style is null");
            return false;
        }

        return GUI.Button(rect, text, style.ConvertToGUIStyle(EditorStyles.miniButton));
    }

    public static bool Button(Texture image)
    {
        return GUILayout.Button(image);
    }

    public static bool Button(Rect rect, Texture image)
    {
        return GUI.Button(rect, image);
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

    public static bool Button(Rect rect, Texture image, ExtendedStyle style)
    {
        if (style == null)
        {
            Debug.LogError("The button style is null");
            return false;
        }

        return GUI.Button(rect, image, style.ConvertToGUIStyle(EditorStyles.miniButton));
    }
    #endregion

    #region Menu
    public static void Menu(ref int index, string[] tabs)
    {
        index = GUILayout.Toolbar(index, tabs);
    }

    public static void Menu(ref int index, string[] tabs, ExtendedStyle style)
    {
        index = GUILayout.Toolbar(index, tabs, style.ConvertToGUIStyle(EditorStyles.miniButton));
    }

    public static void Menu(ref int index, string[] tabs, ExtendedStyle style, GUI.ToolbarButtonSize buttonSize)
    {
        index = GUILayout.Toolbar(index, tabs, style.ConvertToGUIStyle(EditorStyles.miniButton), buttonSize);
    }
    #endregion

    #region Layouts
    public static void HorizontalLayout(Action action)
    {
        GUILayout.BeginHorizontal();

        action();

        GUILayout.EndHorizontal();
    }

    public static void HorizontalLayout(ExtendedStyle style, Action action)
    {
        GUILayout.BeginHorizontal(style.ConvertToGUIStyle(EditorStyles.label));

        action();

        GUILayout.EndHorizontal();
    }

    public static void VerticalLayout(Action action)
    {
        GUILayout.BeginVertical();

        action();

        GUILayout.EndVertical();
    }

    public static void VerticalLayout(ExtendedStyle style, Action action)
    {
        GUILayout.BeginVertical(style.ConvertToGUIStyle(EditorStyles.label));

        action();

        GUILayout.EndVertical();
    }

    public static void AreaLayout(Rect size, Action action)
    {
        GUILayout.BeginArea(size);

        action();

        GUILayout.EndArea();
    }

    public static void AreaLayout(Rect size, ExtendedStyle style, Action action)
    {
        GUILayout.BeginArea(size, style.ConvertToGUIStyle(EditorStyles.label));

        action();

        GUILayout.EndArea();
    }
    #endregion

    #region Fields
    public static UnityEngine.Object ObjectField(Rect rect, string text, UnityEngine.Object obj, Type type, bool allowSceneObjects)
    {
        return EditorGUI.ObjectField(rect, text, obj, type, allowSceneObjects);
    }

    public static UnityEngine.Object ObjectField(Rect rect, UnityEngine.Object obj, Type type, bool allowSceneObjects)
    {
        return EditorGUI.ObjectField(rect, obj, type, allowSceneObjects);
    }

    public static void TextField(Rect rect, string label, ref string text, ExtendedStyle style)
    {
        text = EditorGUI.TextField(rect, text, label, style.ConvertToGUIStyle(EditorStyles.textField));
    }

    public static void TextField(Rect rect, ref string text, ExtendedStyle style)
    {
        text = EditorGUI.TextField(rect, text, style.ConvertToGUIStyle(EditorStyles.textField));
    }

    public static void TextField(Rect rect, string label, ref string text)
    {
        text = EditorGUI.TextField(rect, label, text);
    }

    public static void TextField(Rect rect, ref string text)
    {
        text = EditorGUI.TextField(rect, text);
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