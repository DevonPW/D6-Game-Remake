using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDot : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite.color = ColourPalette.colours[2];
    }

    public void changeColour()
    {
        sprite.color = ColourPalette.colours[1];
    }
}
