using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Player Object
public class PlayerAct : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        // 약초 채집
        if (Input.GetKeyDown(KeyCode.Z) && other.CompareTag("Herb"))
        {
            Debug.Log("Gather Herb");
            var data = other.GetComponent<HerbData>();
            
            data.GatherHerb(out EntityInfo.ItemIndex herb);
            ItemManager.Instance.SetInventory(herb);
        }
        
        // 맵 이동
        if (other.CompareTag("Next"))
        {
            Debug.Log("Move to Next Map");
            NextData data = other.GetComponent<NextData>();
            if (PlayerInfo.Instance.AdmissionLevel >= data.AdmissionLevel)
            {
                SceneManager.LoadScene(data.NextSceneNumber);
            }
            else
            {
                // Do something
            }
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        // NPC 대화
        if (Input.GetKeyDown(KeyCode.Z) && other.collider.CompareTag("NPC"))
        {
            Debug.Log("Talk with NPC");
            UGUIManager.Instance.TalkToNpc(other.gameObject);
            // 추가 작성 : NPC와 대화
        }
        // 지형물 탐색
        else if (Input.GetKeyDown(KeyCode.Z) && other.collider.CompareTag("MapObject"))
        {
            Debug.Log("Search MapObject");
            MapObjectData data =  other.gameObject.GetComponent<MapObjectData>();
            
            data.GatherItem(out MapObjectData.MapObjIndex objIndex, out EntityInfo.ItemIndex item);
            ItemManager.Instance.SetInventory(item);
            // 추가 작성 : 아이템 탐색
        }
    }
}
