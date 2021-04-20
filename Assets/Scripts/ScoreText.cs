using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //[SerializeField] GameData data;

    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        text.color = ColourPalette.colours[2];
    }

    void Update()
    {
        text.text = GameData.score.ToString() + " / 50";
    }
}
