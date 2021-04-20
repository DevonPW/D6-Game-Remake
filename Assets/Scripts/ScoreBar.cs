using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour
{
    [SerializeField] SpriteRenderer emptySprite;

    [SerializeField] SpriteRenderer fillSprite;

    [SerializeField] GameObject fillBar;

    //[SerializeField] GameData data;

    void Start()
    {
        emptySprite.color = ColourPalette.colours[1];

        fillSprite.color = ColourPalette.colours[2];

        fillBar.transform.localScale.Set(0, 1, 1);
    }
}
