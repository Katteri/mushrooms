using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Extra Object", menuName = "Inventory System/Items/Extra")]
public class ExtraObject : ItemObject
{
    public int helpTime;
    public void Awake()
    {
        type = ItemType.Extra;
    }
}
