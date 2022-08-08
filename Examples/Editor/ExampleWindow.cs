using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    [MenuItem("Extended Editor/Example Window")]
    public static void Open()
    {
        EditorWindow window = GetWindow(typeof(ExampleWindow));
        window.titleContent = new("Example Window");
    }

    void OnGUI()
    {
        ExtendedEditor.Text("Extended Text", new ExtendedStyle() { FontColor = Color.cyan, FontHoverColor = Color.red, FontSize = 50 });
        ExtendedEditor.Text("Extended Text 2", new ExtendedStyle() { FontColor = Color.cyan, FontSize = 50 });
        ExtendedEditor.Text("Extended Text 3");
    }
}