using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform PlayerTransform;

    public float Life = 5f;
    

    //Movement
    public float SpeedMove = 5f;
    private float MoveX, MoveY;

    //Leveling
    private float ExperienceRequired = 5f;
    public float Experience = 0;

    private void Start()
    {
        PlayerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        MoveX = Input.GetAxis("Horizontal") * SpeedMove * Time.deltaTime;
        MoveY = Input.GetAxis("Vertical") * SpeedMove * Time.deltaTime;

        //Move the transform
        Vector2 newPosition = PlayerTransform.position + new Vector3(MoveX,MoveY,0);
        PlayerTransform.position = newPosition;

        //
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }

    }
}
