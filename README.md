# Extended-Editor
A plugin for Unity that helps you write your own custom editors.

## Installation
To install this plugin follow the instructions below. Make sure you have installed all required packages.

### Requirements
- Unity v. 2020 or newer

### Installing the plugin
Import all repository files to your `Assets` folder. Only folder called `Examples` is unnecessary.

## Usage
This plugin contains **2 classes**:
- `ExtendedEditor.cs` - All editor functions
- `ExtendedStyle.cs` - Style class for editor elements

### Extended Editor
<details>
<summary>Text</summary>
Example of using Text:

```csharp
ExtendedEditor.Text("Example Text");
```
</details>

<details>
<summary>Button</summary>
Example of using Button:

```csharp
if(ExtendedEditor.Button("Example Button"))
{
    // What happens when the button is clicked
}
```
</details>

<details>
<summary>Image</summary>
Example of using Image:

```csharp
ExtendedEditor.Image(Resources.Load<Texture>("Textures/Example Image"));
```
</details>

<details>
<summary>Space</summary>
Example of using Space:

```csharp
ExtendedEditor.Space(10);
```
</details>

<details>
<summary>Divider</summary>
Example of using Divider:

```csharp
ExtendedEditor.Divider(5);
```
</details>

<details>
<summary>Menu</summary>
Example of using Menu:

```csharp
int selectedMenu = 0;

void OnGUI()
{
    ExtendedEditor.Menu(ref selectedMenu, new string[] { "Tab 1", "Tab 2", "Tab 3" } );

    switch (selectedMenu)
    {
        case 0:
            // Page 1
            break;
        case 1:
            // Page 2
            break;
        case 2:
            // Page 3
            break;
    }
}
```
</details>

<details>
<summary>Layouts</summary>
Example of using HorizontalLayout:

```csharp
ExtendedEditor.HorizontalLayout(() =>
{
    // code
});
```

Example of using VerticalLayout:

```csharp
ExtendedEditor.VerticalLayout(() =>
{
    // code
});
```

Example of using AreaLayout:

```csharp
ExtendedEditor.AreaLayout(new Rect(0, 0, 350, 250), () =>
{
    // code
});
```
</details>

<details>
<summary>Fields</summary>
Example of using ObjectField:

```csharp
GameObject obj;

void OnGUI()
{
    obj = (GameObject)ExtendedEditor.ObjectField(new Rect(0, 0, 100, 35), obj, typeof(GameObject), false);
}
```

Example of using TextField:

```csharp
string text;

void OnGUI()
{
    ExtendedEditor.TextField(new Rect(0, 0, 100, 35), ref text);
}
```
</details>

## Author
This plugin is made by [Polish Coder](https://github.com/Polish-Coder)