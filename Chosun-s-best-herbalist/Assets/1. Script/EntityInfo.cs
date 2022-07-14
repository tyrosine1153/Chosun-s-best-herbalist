using UnityEngine;

// Item list
public class EntityInfo
{
    public enum ItemIndex
    {
        Null = -1,
        Sys_0 = 00,
        
        Herb_0 = 10,
        Herb_1 = 11,
        Herb_2 = 12,
        
        Food_0 = 20
    }
    
    public static ItemIndex RandomHerb()
    {
        int result = Random.Range(0, 3);

        return (ItemIndex) (10 + result);
    }

}
