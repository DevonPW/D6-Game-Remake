using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Die : MonoBehaviour
{
    PoolManager poolManager;

    //[SerializeField] ColourPalette palette;

    [SerializeField] SpriteRenderer sprite;

    [SerializeField] TextMeshPro numText;//number to display on die

    [SerializeField] AudioSource soundEffect;//aoudn effect to play

    [SerializeField] float defaultMoveSpeed;

    public int number;//number on die

    public int colour;//colour of die

    [System.NonSerialized] public int poolIndex;//index of object in the object pool array

    public void Despawn()
    {
        poolManager.Despawn(poolIndex);
    }

    public void Move(float x, float y, float speed)
    {
        
    }
    public void Move(float x, float y)//translates die along linear path to given coordinates
    {
        transform.position = new Vector2(x, y);//will just set position for now...
    }
    public void Move(Vector2 pos)//translates die along linear path to given coordinates
    {
        transform.position = new Vector2(pos.x, pos.y);//will just set position for now...
    }

    public void setText(string t)
    {
        numText.text = t;
    }

    public void playSound()
    {

    }

    public void setPoolManager(PoolManager manager)
    {
        poolManager = manager;
    }

    public void setColour()
    {
        sprite.color = ColourPalette.colours[colour];
    }

    public void Shake()
    {

    }
}
