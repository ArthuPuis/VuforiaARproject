using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour
{
    public float speed; //vitesse a definir dans l'interface unity
    public float rotateSpeed; //vitesse de rotation a definir dans l'interface unity
    private bool forward;
    private bool back;
    private bool right;
    private bool left;
    public GameObject BaseCard = null;
    private Distance BaseCardPos;
    // Start is called before the first frame update
    void Start()
    {
        forward = false;
    }
    //functions called by the move's buttons

    public void moveToward()
    { 
        forward = true;
    }

    public void stopMoveToward()
    {
        forward = false;
    }
    //________________________________

    public void moveBack()
    {
        back = true;
    }

    public void stopMoveBack()
    {
        back = false;
    }
    //________________________________

    public void turnRight()
    {
        right = true;
    }

    public void stopTurnRight()
    {
        right = false;
    }
    //________________________________

    public void turnLeft()
    {
        left = true;
    }

    public void stopTurnLeft()
    {
        left = false;
    }


    // Update is called once per frame
    void Update()
    {
        BaseCardPos = BaseCard.GetComponent<Distance>();
        if (BaseCardPos.goIn == true)
        {
            if (forward == true)
            {
                print("move toward");
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            else if (forward == false)
            {
                print("stop toward");
            }
            //______________________

            if (back == true)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            //______________________

            if (right == true)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
            }
            //______________________

            if (left == true)
            {
                transform.Rotate(Vector3.down, Time.deltaTime * rotateSpeed);
            }

        }
    }
}
