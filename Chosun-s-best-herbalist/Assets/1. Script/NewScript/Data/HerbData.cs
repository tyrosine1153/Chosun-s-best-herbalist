using System;
using UnityEngine;

namespace _1._Script.NewScript
{
    // Herb Object
    public class HerbData : MonoBehaviour
    {
        [SerializeField] private EntityInfo.ItemIndex _itemIndex = EntityInfo.ItemIndex.Herb_0;

        private void Start()
        {
            _itemIndex = EntityInfo.RandomHerb();
        }
    }
}