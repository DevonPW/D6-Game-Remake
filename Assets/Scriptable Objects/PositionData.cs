using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PositionData", menuName = "ScriptableObjects/PositionData", order = 1)]
public class PositionData : ScriptableObject
{
    public static float currentDieX = 0.0f;
    public static float currentDieY = -3.1f;

    public static float originX = -6.0f;
    public static float originY = 6.27f;

    public static float spaceX = 3.0f;
    public static float spaceY = -2.8f;
}
