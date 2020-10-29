using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableArea
{
    public override void OnClick()
    {
        base.OnClick();

        Debug.Log(Name + " has been clicked!");

        Debug.Log("Door opened");

        DoorClicked();
    }

    private void DoorClicked()
    {

    }
}
