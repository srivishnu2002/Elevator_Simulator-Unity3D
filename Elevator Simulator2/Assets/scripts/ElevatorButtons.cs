using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButtons : MonoBehaviour
{
    public bool CanPress;
    public GameObject ButtonInstructionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        ButtonInstructionCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Player")
        {
            CanPress = true;
            gameObject.GetComponent<CanvasGroup>().alpha = 1;
            ButtonInstructionCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanPress = false;
        gameObject.GetComponent<CanvasGroup>().alpha = 0.6f;
        ButtonInstructionCanvas.SetActive(false);
    }
}
