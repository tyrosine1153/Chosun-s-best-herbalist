using System;
using UnityEngine;

namespace _1._Script.NewScript
{
    public class HerbData : MonoBehaviour
    {
        [SerializeField] private EntityInfo.ItemIndex _itemIndex;

        private void Start()
        {
            _itemIndex = EntityInfo.randomHerb();
        }
    }
}