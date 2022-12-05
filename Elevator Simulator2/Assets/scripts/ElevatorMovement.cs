using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElevatorMovement : MonoBehaviour
{
    
    public List<GameObject> Floors = new List<GameObject>();
    public int targetFloor;
    public float t;
    public bool IsMoving;
    public GameObject ElevatorNumCanvas;
    
    //public bool collisioncheck;
    public ElevatorButtons eb;

    public Rigidbody rb;

    public TextMeshProUGUI goingToText;
    

    // Start is called before the first frame update
    void Start()
    {
        targetFloor = 0;
        IsMoving = false;
        
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(rb.IsSleeping())
        {
            IsMoving = false;
        }

        else
        {
            IsMoving = true;
        }
       
        
            if(eb.CanPress == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    if (IsMoving == false)
                    {
                        targetFloor = 1;
                        goingToText.SetText("1st Floor");
                    }
                }

                else if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    if (IsMoving == false)
                    {
                        targetFloor = 0;
                        goingToText.SetText("Ground Floor");

                    }
                }

            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (IsMoving == false)
                {
                    targetFloor = 2;
                    goingToText.SetText("2nd Floor");
                }
            }




        }
    }

    private void FixedUpdate()
    {
        MoveTo();
    }

    public void MoveTo()
    {
        //transform.position = Vector3.Lerp(transform.position, Floors[targetFloor].transform.position, t);
        transform.position = Vector3.MoveTowards(transform.position, Floors[targetFloor].transform.position, t);
    }




    /*private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            collisioncheck = true;
            //ElevatorNumCanvas.SetActive(true);
            ElevatorNumCanvas.GetComponent<CanvasGroup>().alpha = 1;
            

        }


        
    }*/

    /*private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Player")
        {
            collisioncheck = false;
            //ElevatorNumCanvas.SetActive(false);
            ElevatorNumCanvas.GetComponent<CanvasGroup>().alpha = 0;
            
        }
    }*/

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {
            collisioncheck = true;
            ElevatorNumCanvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (blocked == false)
                {
                    targetFloor = 1;
                }
            }
        }
    }*/

}
