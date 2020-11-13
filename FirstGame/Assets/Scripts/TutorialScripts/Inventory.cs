using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Set number of the inventory slots to ensure inventory is always the same size
    public const int numItemSlots = 5;

    //Images for the inventory
    public Image[] itemImages = new Image[numItemSlots];

    //Items themselves
    public ItemUI[] items = new ItemUI[numItemSlots];

    //Add images to inventory
    public void AddItem(ItemUI itemToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
                return;
            }
        }
    }

    //Remove image from inventory
    public void ReturnItem(ItemUI itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }

}
