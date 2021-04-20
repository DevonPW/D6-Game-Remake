using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour
{
    [SerializeField] SpriteRenderer emptySprite;

    [SerializeField] SpriteRenderer fillSprite;

    [SerializeField] GameObject fillBar;

    [SerializeField] float animLength;

    [SerializeField] AnimationCurve curve;

    float startTime = -1;

    float timePercent = 1;

    void Start()
    {
        emptySprite.color = ColourPalette.colours[1];

        fillSprite.color = ColourPalette.colours[2];

        fillBar.transform.localScale.Set(0, 1, 1);
    }

    void Update()
    {
        if (GameData.score < GameData.targetScore) {
            float scaleX = GameData.score / GameData.targetScore;
            fillBar.transform.localScale.Set(scaleX, 1, 1);
        }
        else {//Target Score has been reached
            fillBar.transform.localScale.Set(1, 1, 1);
            pluseAnim();
        }
    }

    void pluseAnim()
    {
        if (startTime == -1) {
            startTime = Time.time;
        }

        timePercent = (Time.time - startTime) / animLength;

        float alpha;
        alpha = Vector3.Lerp(Vector3.zero, Vector3.one, curve.Evaluate(timePercent)).x;

        //setting alpha
        fillSprite.color = new Color(fillSprite.color.r, fillSprite.color.g, fillSprite.color.b, alpha);
    }
}
