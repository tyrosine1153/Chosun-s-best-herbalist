using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// System Object
public class MapManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    // 약초 생성하는 코드

    // Next와 닿았을때 Next에 입력된 정보대로 이동하는 함수
    void NextScene(Collider2D col)
    {
        // 밑에 코드는 Act로 옮겨야 할 듯
        if (!col.CompareTag("Next"))
            return;

        NextData coll = col.GetComponent<NextData>();
        if (PlayerInfo.Instance.admissionLevel >= coll.AdmissionLevel)
        {
            SceneManager.LoadScene(coll.NextSceneNumber);
        }
        else
        {
            // Do something
        }
    }
}
