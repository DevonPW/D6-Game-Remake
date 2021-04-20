using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //[SerializeField] GameData data;

    [SerializeField] TextMeshProUGUI text;
    void Update()
    {
        text.text = GameData.score.ToString();
    }
}
