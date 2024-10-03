//using System.Collections;
//using System.Collections.Generic;
//using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string names = "New Item";
    public Sprite icon = null;
    public GameObject Prefab;
    //int namber = 8;
}
