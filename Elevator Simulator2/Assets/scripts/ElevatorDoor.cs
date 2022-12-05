using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door1Close;
    public GameObject Door2Close;
    public GameObject Door1Open;
    public GameObject Door2Open;

    public bool OpeningDoors;
    public bool ClosingDoors;

    public float t;

    public ElevatorMovement em;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(em.rb.IsSleeping())
        {
            if (OpeningDoors == true)
            {
                OpenDoors();
            }

            else if (ClosingDoors == true)
            {
                CloseDoors();
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Player")
        {
            if(em.IsMoving == false)
            {
                ClosingDoors = false;
                OpeningDoors = true;
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Player")
        {
            OpeningDoors = false;
            ClosingDoors = true; ;
        }
    }

    public void OpenDoors()
    {
        Door1.transform.position = Vector3.MoveTowards(Door1.transform.position, Door1Open.transform.position, t);
        Door2.transform.position = Vector3.MoveTowards(Door2.transform.position, Door2Open.transform.position, t);
    }

    public void CloseDoors()
    {
        Door1.transform.position = Vector3.MoveTowards(Door1.transform.position, Door1Close.transform.position, t);
        Door2.transform.position = Vector3.MoveTowards(Door2.transform.position, Door2Close.transform.position, t);
    }
}
