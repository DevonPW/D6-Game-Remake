using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChainText : MonoBehaviour
{
    //[SerializeField] GameData data;

    [SerializeField] TextMeshProUGUI text;

    void Update()
    {
        text.text = GameData.currentChain.ToString();
    }
}
