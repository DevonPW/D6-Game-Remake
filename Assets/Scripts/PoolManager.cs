using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    static int maxDice = 15;

    Die[] dicePool = new Die[maxDice];

    int[] unspawnedObjects = new int[maxDice];

    int unspawnedArraySize = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxDice; i++) {//initializing die in dicePool and deactivating them
            dicePool[i] = new Die();
            dicePool[i].gameObject.SetActive(false);

            unspawnedObjects[i] = i;//initializing UnspawnedObjects array to be full
        }
        unspawnedArraySize = maxDice;
    }

    void Spawn()
    {
        int index = unspawnedObjects[unspawnedArraySize - 1];//index to spawn object into

        int num = Random.Range(1, 7);//(inclusive, exclusive)


        dicePool[index].gameObject.SetActive(true);//activate object
    }

    void Despawn()
    {

    }

}
