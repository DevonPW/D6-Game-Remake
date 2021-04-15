using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColourPalettes", menuName = "ScriptableObjects/ColourPalettes", order = 1)]
public class ColourPalettes : ScriptableObject
{
    public Color colourBG = new Color(232,224,209);
    public Color colour1 = new Color(47, 52, 59);
    public Color colour2 = new Color(199, 123, 102);
    public Color colour3 = new Color(126, 130, 122);
    public Color colour4 = new Color(226, 206, 164);
    public Color colour5 = new Color(112, 49, 48);
    public Color colour6 = new Color(191, 72, 68);
}
