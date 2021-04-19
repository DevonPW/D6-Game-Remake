using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColourPalette", menuName = "ScriptableObjects/ColourPalette", order = 1)]
public class ColourPalette : ScriptableObject
{
    public static Color colourBG = new Color(232,224,209);
    public static Color colour1 = new Color(47, 52, 59);
    public static Color colour2 = new Color(199, 123, 102);
    public static Color colour3 = new Color(126, 130, 122);
    public static Color colour4 = new Color(226, 206, 164);
    public static Color colour5 = new Color(112, 49, 48);
    public static Color colour6 = new Color(191, 72, 68);

    public static Color[] colours = new Color[]{
        colourBG,
        colour1,
        colour2,
        colour3,
        colour4,
        colour5,
        colour6
        };

    /*public static Dictionary<int, Color> colours = new Dictionary<int, Color> {
        {0, colourBG},
        {1, colour1},
        {2, colour2},
        {3, colour3},
        {4, colour4},
        {5, colour5},
        {6, colour6},
    };*/
}
