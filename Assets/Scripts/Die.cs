using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Die : MonoBehaviour
{
    public PoolManager poolManager;

    [SerializeField] TextMeshPro numText;//number to display on die

    [SerializeField] AudioSource soundEffect;//aoudn effect to play

    [SerializeField] float defaultMoveSpeed;

    public int number;//number on die

    public int colour;//colour of die

    public int poolIndex;//index of object in the object pool array

    public void Despawn()
    {
        poolManager.Despawn(poolIndex);
    }

    public void Move(float speed)
    {
        
    }
    public void Move()
    {

    }

    public void setText(string t)
    {
        numText.text = t;
    }

    public void playSound()
    {

    }
}
