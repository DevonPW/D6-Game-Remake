using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Die : MonoBehaviour
{
    PoolManager poolManager;

    [SerializeField] SpriteRenderer sprite;

    [SerializeField] TextMeshPro numText;//number to display on die

    //[SerializeField] AudioSource soundEffect;//sound effect to play

    //[SerializeField] float moveSpeed;

    [System.NonSerialized] public int number;//number on die

    [System.NonSerialized] public int colour;//colour of die

    int poolIndex;//index of object in the object pool array

    bool isMoving = false;//flag set if Die is currently moving

    bool willBeRemoved = false;//flag set if die is being removed as currentDie

    bool isRemoving = false;

    bool isShaking = false;

    float prevShakeTime;

    Vector2 originalPos;

    [SerializeField] float shakeInterval = 0.1f;

    [SerializeField] float shakeDuration = 0.5f;//time it takes for die to finish moving

    //Vector2 moveVector = new Vector2();

    Vector2 targetPos = new Vector2();//position die is moving towards

    Vector2 startPos = new Vector2();//position die is moving from

    float startMoveTime = -1;

    [SerializeField] float moveDuration = 0.3f;//time it takes for die to finish moving

    [SerializeField] float removeDuration = 0.2f;//time it takes for die to finish moving

    void Update()
    {
        if (isShaking == true) {
            UpdateShake();
        }

        if (willBeRemoved == true && isMoving == false) {
            startRemove();
        }

        if (isMoving == true) {
            UpdateMove();
        }

        if (isRemoving == true) {
            UpdateRemove();
        }
    }

    void UpdateMove()
    {
        float timePercent = (Time.time - startMoveTime) / moveDuration;//percentage of move duration complete

        transform.position = Vector2.Lerp(startPos, targetPos, timePercent);

        if (timePercent > 1) {//stop moving
            isMoving = false;
            startMoveTime = -1;
            if (willBeRemoved == true) {
                startRemove();
            }
        }

        //transform.Translate(moveVector.x * Time.deltaTime, moveVector.y * Time.deltaTime, 0);
    }

    void startRemove()
    {
        if (isShaking == true) {
            isShaking = false;
            transform.position = originalPos;
        }

        willBeRemoved = false;
        
        isRemoving = true;

        startMoveTime = Time.time;

        targetPos = new Vector2(PositionData.currentDieX, PositionData.currentDieY - 3);

        startPos = transform.position;
    }
    void UpdateRemove()
    {
        float timePercent = (Time.time - startMoveTime) / removeDuration;//percentage of move duration complete

        transform.position = Vector2.Lerp(startPos, targetPos, timePercent);

        if (timePercent > 1) {//finished removing
            Despawn();
        }
    }

    public void UpdateShake()
    {
        if ((Time.time - startMoveTime) >= shakeDuration) {//shaking is finished
            isShaking = false;
            transform.position = originalPos;
        }
        else {//still shaking
            if (Time.time - prevShakeTime >= shakeInterval) {
                prevShakeTime = Time.time;

                float x = Random.Range(-0.1f, 0.1f);
                float y = Random.Range(-0.1f, 0.1f);

                transform.position = new Vector2(originalPos.x + x, originalPos.y + y);
            }
        }
    }


    public void Shake()
    {
        if (isMoving == false && isRemoving == false) {
            isShaking = true;
            startMoveTime = Time.time;
            prevShakeTime = -1;
            originalPos.Set(transform.position.x ,transform.position.y);//saving original position
        }
    }

    public void Move(float x, float y)//translates die along linear path to given coordinates
    {
        if (isShaking == true) {
            isShaking = false;
            transform.position = originalPos;
        }

        isMoving = true;

        //if (startMoveTime == -1) {
            startMoveTime = Time.time;
        //}

        targetPos.Set(x, y);

        startPos = transform.position;

        //transform.position = new Vector2(x, y);//will just set position for now...

        //moveVector = targetPos - startPos;
        //moveVector.Normalize();
    }
    public void Move(Vector2 pos)//translates die along linear path to given coordinates
    {
        if (isShaking == true) {
            isShaking = false;
            transform.position = originalPos;
        }

        isMoving = true;

        //if (startMoveTime == -1) {
            startMoveTime = Time.time;
        //}

        targetPos = pos;

        startPos = transform.position;

        //transform.position = new Vector2(pos.x, pos.y);//will just set position for now...

        //moveVector = targetPos - startPos;
        //moveVector.Normalize();
    }

    public void Remove()//translates die off bottom of screen, and then despawns it
    {
        willBeRemoved = true;
    }

    public void Despawn()
    {
        //reset data here:
        isMoving = false;//prevents die from continuing to move after it respawns
        willBeRemoved = false;
        isRemoving = false;

        startMoveTime = -1;

        poolManager.Despawn(poolIndex);
    }


    public void setText()
    {
        numText.text = number.ToString();
    }

    public void setColour()
    {
        sprite.color = ColourPalette.colours[colour];
    }

    public void setPoolManager(PoolManager manager)
    {
        poolManager = manager;
    }

    public void setPoolIndex(int n)
    {
        poolIndex = n;
    }
}
