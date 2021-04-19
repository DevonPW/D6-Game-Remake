using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    Die[][] dice = { new Die[5], new Die[5], new Die[5]}; //array of dice

    Die currentDie;//die in the player's box

    [SerializeField] PoolManager poolManager;

    [SerializeField] ScoreBar scoreBar;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] TextMeshProUGUI chainText;

    int score;

    int currentChain;

    int maxChain;

    int lives;

    int spawnX, spawnY;//position in grid to spawn die at

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreBar.MainUpdate();
    }

    void SpawnDie()//spawns die at (spawnX, spawnY)
    {
        dice[spawnY][spawnX] = poolManager.Spawn();
    }

    bool DieClicked()//called upon die being clicked
    {
        return true;
    }

    void SuccessClick()
    {

    }

    void SetCurrentDie()
    {

    }

    void TargetScoreReached()
    {

    }

    void GameOver()
    {

    }

    void GameWin()
    {

    }
}
