using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSetter : MonoBehaviour
{
    [SerializeField] ColourPalette palette;

    [SerializeField] SpriteRenderer boxSprite;
    [SerializeField] SpriteRenderer logoSprite;
    [SerializeField] SpriteRenderer backgroundSprite;
    
    // sets colour of objects
    void Start()
    {
        boxSprite.color = ColourPalette.colours[1];
        logoSprite.color = ColourPalette.colours[1];
        backgroundSprite.color = ColourPalette.colours[0];
    }
}
