using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Product Object", menuName = "Inventory System/Items/Product")]
public class ProductObject : ItemObject
{
    public int gain;
    public void Awake()
    {
        type = ItemType.Product;
    }
}
