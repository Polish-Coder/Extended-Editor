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
}