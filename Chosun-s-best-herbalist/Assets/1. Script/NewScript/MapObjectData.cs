using System.Collections.Generic;
using UnityEngine;

// map obj
public class MapObjectData
{
    enum MapObjIndex
    {
        Tree,
        Box
    }
    
    [SerializeField] private MapObjIndex _objIndex;  // 배치물 종류
    [SerializeField] private List<EntityInfo.ItemIndex> _itemList;  // 획득할 수 있는 아이템 (1개)
    
    // Act 스크립트에서 읽을 때 종류 값에 따라 설명을 읽고 아이템 리스트에 있는 것을 가져감
}
