using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;


    // Update is called once per frame
    void Update()
    {
        //Getting coords of the mouse position from the game every frame
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log(mousePos);

        //Check for left mouse click, if they do, get the coords and save
        if(Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, transform.position.y);
        }
        
    }
}
