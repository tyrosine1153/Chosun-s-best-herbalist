using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    public int nextSceneNumber;
    public int questStepToMove;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MoveToScene();
        }
    }

    void MoveToScene()
    {
        if (GameManager.instance.questStep >= questStepToMove)  // 현재 퀘스트 진행도 > 필요 진행도
            GameManager.instance.ChanegeScene(nextSceneNumber);
        else
        {
            //Do Something
        }

    }
}
