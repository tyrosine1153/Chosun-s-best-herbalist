using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    public int nextSceneNumber;
    public int questStepToMove;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoveToScene();
        }
    }

    void MoveToScene()
    {
        if (GameManager.Instance.questStep >= questStepToMove) // 현재 퀘스트 진행도 >= 필요 진행도
        {
            GameManager.Instance.ChanegeScene(nextSceneNumber);
            Debug.Log("asdf");
        }
        else
        {
            //Do Something
        }

    }
}
