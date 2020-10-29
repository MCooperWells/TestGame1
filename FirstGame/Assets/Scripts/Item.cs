using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : InteractableArea
{
    public override void OnClick()
    {
        base.OnClick();

        Debug.Log(Name + " has been clicked!");

        Debug.Log("Item Collected opened");

        ItemClicked();

        Destroy(gameObject, 1.0f);
    }

    private void ItemClicked()
    {

    }
}
