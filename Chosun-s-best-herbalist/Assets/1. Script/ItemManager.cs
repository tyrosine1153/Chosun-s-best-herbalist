using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// System Object
public class ItemManager : Singleton<ItemManager>
{
    private Dictionary<EntityInfo.ItemIndex, int> _inventory;

    public Dictionary<EntityInfo.ItemIndex, int> Inventory => _inventory;

    // 인벤토리에 아이템 추가
    public void SetInventory(EntityInfo.ItemIndex key, int value = 1)
    {
        if (key == EntityInfo.ItemIndex.Null)
        {
            return;
        }

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
