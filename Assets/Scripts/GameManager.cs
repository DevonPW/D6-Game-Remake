using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    Die[][] dice = { new Die[5], new Die[5], new Die[5] }; //array of dice

    Die currentDie;//die in the player's box

    //[SerializeField] ColourPalette palette;

    [SerializeField] PoolManager poolManager;

    [SerializeField] ScoreBar scoreBar;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] TextMeshProUGUI chainText;

    int score;

    int currentChain;

    int maxChain;

    int lives;

    int spawnX, spawnY;//position in grid to spawn die at

    float currentDieX = 0.0f;
    float currentDieY = 3.1f;

    float originX = -6.0f;
    float originY = 3.47f;

    float spaceX = 3.0f;
    float spaceY = 2.8f;


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

    bool checkClick(Die die)//checks if die clicked on is a valid match for current die
    {
        int numCheck = currentDie.number + 1;
        if (die.colour == currentDie.colour || die.number == numCheck) {
            return true;
        }
        else {
            return false;
        }
    }

    public void DieClicked(int i)//called upon die being clicked
    {


        /*if (i == 0) {

        }
        else if (i == 1) {

        }
        else if (i == 2) {

        }
        else if (i == 3) {

        }
        else if (i == 4) {

        }
        else if (i == 5) {

        }*/
    }

    void SuccessClick()
    {

    }

    void SetCurrentDie(Die die)
    {
        currentDie = die;
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
