using UnityEngine;

namespace _1._Script.NewScript
{
    // Create Map obj data
    // Map Data
    public class MapData
    {
        enum AreaIndex
        {
            Green,  // 지역별로 서식 식물을 정하는 것도 좋을 듯
            Blue
        }
        
        // private int _mapID;  // 맵 번호
        [SerializeField] private AreaIndex _areaIndex;  //지역
        [SerializeField] private EntityInfo.ItemIndex[] _habitat =
        {
            EntityInfo.ItemIndex.Herb_0, 
            EntityInfo.ItemIndex.Herb_1, 
            EntityInfo.ItemIndex.Herb_2
        };  // 서식 약초
    }
}