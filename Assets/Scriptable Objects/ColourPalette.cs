using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColourPalette", menuName = "ScriptableObjects/ColourPalette", order = 1)]
public class ColourPalette : ScriptableObject
{
    public static Color colourBG = new Color32(232, 224, 209, 255);
    public static Color colour1 = new Color32(47, 52, 59, 255);
    public static Color colour2 = new Color32(199, 123, 102, 255);
    public static Color colour3 = new Color32(126, 130, 122, 255);
    public static Color colour4 = new Color32(226, 206, 164, 255);
    public static Color colour5 = new Color32(112, 49, 48, 255);
    public static Color colour6 = new Color32(191, 72, 68, 255);

    public static Color[] colours = new Color[]{
        colourBG,
        colour1,
        colour2,
        colour3,
        colour4,
        colour5,
        colour6
        };

    public Color[] colours2 = new Color[] {
        new Color(232, 224, 209),
        new Color(47, 52, 59),
        new Color(199, 123, 102),
        new Color(126, 130, 122),
        new Color(226, 206, 164, 255),
        new Color(112, 49, 48, 255),
        new Color(191, 72, 68, 255)
    };
}
