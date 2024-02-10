using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Product,
    Seeds,
    Extra
}
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public GameObject prefab;
    public ItemType type;
    [TextArea(15,20)]
    public string description;
}