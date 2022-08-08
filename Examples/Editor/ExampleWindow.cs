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
        ExtendedEditor.Text("Extended Text",
            new ExtendedStyle()
            {
                FontColor = Color.cyan,
                FontHoverColor = Color.red,
                FontSize = 50
            }
        );

        ExtendedEditor.Space();

        ExtendedEditor.Text("Extended Text 2",
            new ExtendedStyle()
            {
                FontColor = Color.cyan,
                FontSize = 50
            }
        );

        ExtendedEditor.Space(100);

        ExtendedEditor.Text("Extended Text 3");

        if (ExtendedEditor.Button("Example Button"))
        {
            Debug.Log("Button");
        }

        if (ExtendedEditor.Button("Example Button 2", new ExtendedStyle()
        {
            FontColor = Color.green
        }
        ))
        {
            Debug.Log("Button 2");
        }

        if (ExtendedEditor.Button(Resources.Load<Texture>("Textures/Example Image 1")))
        {
            Debug.Log("Button 3");
        }

        if (ExtendedEditor.Button(Resources.Load<Texture>("Textures/Example Image 2")))
        {
            Debug.Log("Button 4");
        }

        ExtendedEditor.Divider();

        ExtendedEditor.Image(Resources.Load<Texture>("Textures/Example Image 1"));
    }
}