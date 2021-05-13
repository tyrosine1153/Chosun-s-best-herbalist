using UnityEngine;
// Herb Object
public class HerbData : MonoBehaviour
{
    [SerializeField] private EntityInfo.ItemIndex _itemIndex = EntityInfo.ItemIndex.Herb_0;

    private void Start()
    {
        _itemIndex = EntityInfo.RandomHerb();
    }

    // 허브 정보 넘기고 객체 삭제하기
    public void GatherHerb(out EntityInfo.ItemIndex herb)
    {
        herb = _itemIndex != EntityInfo.ItemIndex.Null ? _itemIndex : EntityInfo.ItemIndex.Null;

        _itemIndex = EntityInfo.ItemIndex.Null;
        Destroy(this);
    }
}
