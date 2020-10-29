using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableArea : MonoBehaviour
{
    public string Name = "";

    private GameObject player;

    // Update is called once per frame
    void Start()
    {
        if (Name.Equals(""))
        {
            Name = "NO NAME";
        }

        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.Log("Warning: Forgot to assign player to game object" + Name);
        }
    }

    private void OnMouseDown()
    {
        OnClick();
    }

    public virtual void OnClick()
    {
        
    }
}
