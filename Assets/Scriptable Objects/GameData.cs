using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject {
    public static int targetScore = 50;

    public static int score;

    public static int currentChain;

    public static int maxChain;

    public static int lives;

    public static bool scoreReached;
}
