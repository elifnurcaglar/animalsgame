using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairbutton : MonoBehaviour
{
    
    public GameObject correctForm;
    private bool moving; 

    private float startPosX;
    private float startPosY;

    void Start()
    {
        
    }


    public hairbutton(float startPosY)
    {
        this.startPosY = startPosY;
    }

   

    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY);
             
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;

            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosX = mousePos.x - this.transform.localPosition.y;

            moving = true;
         
        }
    }
    private void OnMouseUp() => moving = false;

}

