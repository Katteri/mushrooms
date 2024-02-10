using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Seeds Object", menuName = "Inventory System/Items/Seeds")]
public class SeedsObject : ItemObject
{
    public int timeToGrow;
    public void Awake()
    {
        type = ItemType.Seeds;
    }
}
