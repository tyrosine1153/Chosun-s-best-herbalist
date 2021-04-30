using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// System Object
public class ItemManager : MonoBehaviour
{
    private Dictionary<EntityInfo.ItemIndex, int> _inventory;

    public Dictionary<EntityInfo.ItemIndex, int> Inventory => _inventory;
    public void SetInventory(EntityInfo.ItemIndex key, int value)
    {
        if (_inventory.ContainsKey(key))
        {
            _inventory[key] += value;
        }
        else
        {
            _inventory.Add(key, value);
        }
    }

    void Start()
    {
        _inventory = new Dictionary<EntityInfo.ItemIndex, int>();
    }
}
