using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChainText : MonoBehaviour
{
    //[SerializeField] GameData data;

    [SerializeField] TextMeshProUGUI numText;

    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        numText.color = ColourPalette.colours[2];
        text.color = ColourPalette.colours[2];
    }

    void Update()
    {
        numText.text = GameData.currentChain.ToString();
    }
}
