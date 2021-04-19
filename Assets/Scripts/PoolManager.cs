using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    static int maxDice = 15;

    Die[] dicePool = new Die[maxDice];

    int[] unspawnedIndexes = new int[maxDice];

    int indexArraySize = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxDice; i++) {//initializing die in dicePool and deactivating them
            dicePool[i] = new Die();
            dicePool[i].setPoolManager(this);
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
        dicePool[index].colour = Random.Range(1, 7);//(inclusive, exclusive)
        dicePool[index].setColour();

        //giving object it's index
        dicePool[index].poolIndex = index;

        dicePool[index].gameObject.SetActive(true);//activate object

        return dicePool[index];
    }

    public void Despawn(int index)
    {
        dicePool[index].gameObject.SetActive(false);//deactivate object

        indexArraySize++;// increment unspawned index array tracker

        unspawnedIndexes[indexArraySize - 1] = index;//add index of despawned object to index array
    }

}
