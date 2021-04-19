using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Die : MonoBehaviour
{
    [SerializeField] TextMeshPro numText;//number to display on die

    [SerializeField] AudioSource soundEffect;//aoudn effect to play

    int number;//number on die

    int colour;//colour of die

    [SerializeField] float defaultMoveSpeed;

    int poolIndex;//index of object in the object pool array

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
