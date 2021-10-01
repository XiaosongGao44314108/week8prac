using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 1;
    
    
    void Update()
    {
        if (Input.GetButton (InputAxes.MoveUp))
        {
            PlayerMoveUp();
        }
        if (Input.GetButton (InputAxes.MoveDown))
        {
            PlayerMoveDown();
        }
        if(Input.GetButton (InputAxes.MoveLeft))
        {
            PlayerMoveLeft();
        }
        if(Input.GetButton (InputAxes.MoveRight))
        {
            PlayerMoveRight();
        }
    }

    public void PlayerMoveUp()
    {
        this.transform.Translate(new Vector3(0,1,0) * movementSpeed * Time.deltaTime);
    }

    public void PlayerMoveDown()
    {
        this.transform.Translate(new Vector3(0,-1,0) * movementSpeed * Time.deltaTime);
    }

    public void PlayerMoveLeft()
    {
        this.transform.Translate(new Vector3(-1,0,0) * movementSpeed * Time.deltaTime);
    }

    public void PlayerMoveRight()
    {
        this.transform.Translate(new Vector3(1,0,0) * movementSpeed * Time.deltaTime);
    }
}
