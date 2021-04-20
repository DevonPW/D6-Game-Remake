using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Die[][] dice = { new Die[5], new Die[5], new Die[5] }; //array of dice

    Die currentDie;//die in the player's box

    [SerializeField] PoolManager poolManager;

    [SerializeField] AudioSource soundEffect;

    //int spawnX;//position in grid to spawn die at

    // Start is called before the first frame update
    void Start()
    {
        poolManager.InitPool();
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /*void SpawnDie()//spawns die at (spawnX, spawnY)
    {
        dice[0][spawnX] = poolManager.Spawn();
        dice[0][spawnX].transform.position = CalcPosition(spawnX, 0);
    }*/

    void SpawnDie(int x, int y)
    {
        dice[y][x] = poolManager.Spawn();
        dice[y][x].transform.position = CalcPosition(x, y);
    }

    Vector2 CalcPosition(int x, int y)//calculates the screen coordinates given an die's x and y index
    {
        Vector2 pos = new Vector2();

        pos.x = PositionData.originX + (x * PositionData.spaceX);
        pos.y = PositionData.originY + (y * PositionData.spaceY);

        return pos;
    }

    public void CurrentDieClicked()
    {
        currentDie = null;
    }

    public void DieClicked(int x)//called upon die being clicked
    {
        Die die = dice[2][x];//die that was clicked on

        if (currentDie != null) {
            //checking if die clicked on is a valid match for current die
            int numCheck = currentDie.number + 1 < 6 ? currentDie.number + 1 : 1;//if currentDie.number + 1 = 7, set numCheck to 1
            if (die.colour == currentDie.colour || die.number == numCheck) {
                SuccessClick(x);
            }
            else {
                die.Shake();
            }
        }
        else {
            SuccessClick(x);
        }

    }

    void SuccessClick(int x)
    {
        //move current die offscreen and then despawn

        currentDie.Despawn();//just despawning instantly for now...

        //set die that was clicked to current and move it
        SetCurrentDie(dice[2][x]);


        //move dice in column down:

        //moving die from 1st row to 2nd row
        dice[2][x] = dice[1][x];
        dice[2][x].Move(CalcPosition(x, 2));

        //moving die from 0th row to 1st row
        dice[1][x] = dice[0][x];
        dice[1][x].Move(CalcPosition(x, 1));
        

        //spawn new die in column, in 0th row
        SpawnDie(x, 0);

        //play sound effect
        playSound();

        //increase score
        GameData.score++;
        GameData.currentChain++;
    }

    void SetCurrentDie(Die die)
    {
        currentDie = die;

        currentDie.Move(PositionData.currentDieX, PositionData.currentDieY);//moving die to correct position
    }

    void playSound()
    {

    }

    void StartGame()
    {
        //initializing game data
        GameData.score = 0;
        GameData.currentChain = 0;
        GameData.maxChain = 0;
        GameData.lives = 6;

        //initializing arrays of dice
        for (int y = 0; y < 3; y++) {
            for (int x = 0; x < 5; x++) {
                SpawnDie(x, y);
            }
        }

        currentDie = null;
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
