using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    static int maxDice = 20;//bigger than necessary for buffer cuz idk i just want it to work without crashing

    [SerializeField] Die die;

    Die[] dicePool = new Die[maxDice];

    int[] unspawnedIndexes = new int[maxDice];

    int indexArraySize = 0;

    public void InitPool()
    {
        for (int i = 0; i < maxDice; i++) {//initializing die in dicePool and deactivating them
            dicePool[i] = Instantiate(die);
            dicePool[i].setPoolManager(this);
            dicePool[i].setPoolIndex(i);//giving object it's index
            dicePool[i].gameObject.SetActive(false);

            unspawnedIndexes[i] = i;//initializing UnspawnedObjects array to be full
        }
        indexArraySize = maxDice;
    }

    public Die Spawn()
    {
        int index = unspawnedIndexes[indexArraySize - 1];//get last index in unspawned index array

        indexArraySize--;//decrement unspawned index array tracker

        //generating number and colour
        dicePool[index].number = Random.Range(1, 7);//(inclusive, exclusive)
        dicePool[index].setText();
        dicePool[index].colour = Random.Range(1, 7);//(inclusive, exclusive)
        dicePool[index].setColour();

        dicePool[index].gameObject.SetActive(true);//activate object

        return dicePool[index];
    }

    public void Despawn(int index)
    {
        dicePool[index].gameObject.SetActive(false);//deactivate object
        

        unspawnedIndexes[indexArraySize] = index;//add index of despawned object to index array

        indexArraySize++;//increment unspawned index array tracker
    }

}
