using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPalette : MonoBehaviour
{
    //[SerializeField] static Color colour;//you can't serialize static variables

    static public Color colourBG = new Color(232, 224, 209);
    static public Color colour1 = new Color(47, 52, 59);
    static public Color colour2 = new Color(199, 123, 102);
    static public Color colour3 = new Color(126, 130, 122);
    static public Color colour4 = new Color(226, 206, 164);
    static public Color colour5 = new Color(112, 49, 48);
    static public Color colour6 = new Color(191, 72, 68);

    static Dictionary<int, Color> colours = new Dictionary<int, Color> {
        {0, colourBG},
        {1, colour1},
        {2, colour2},
        {3, colour3},
        {4, colour4},
        {5, colour5},
        {6, colour6},
    };

    /*private void Start()
    {
        colours.Add(0,colourBG);
    }*/
}
