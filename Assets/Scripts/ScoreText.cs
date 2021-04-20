using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //[SerializeField] GameData data;

    [SerializeField] TextMeshProUGUI numText;

    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        numText.color = ColourPalette.colours[2];
        text.color = ColourPalette.colours[1];
    }

    void Update()
    {
        numText.text = GameData.score.ToString();
    }
}
