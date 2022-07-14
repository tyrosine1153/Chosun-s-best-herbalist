using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// System Object
public class MapManager : Singleton<MapManager>
{
    // 약초 동적 생성하는 코드
    // _mapDataObj > _mapData > _habitat 이지만 나중에 다른 자식의 값을 받아오기 때문에 각각 변수로 나눴음
    private GameObject _mapDataObj;
    private MapData _mapData;
    private EntityInfo.ItemIndex[] _habitat;

    private void Start()
    {
        _mapDataObj = GameObject.Find("@MapData");
        _mapData = _mapDataObj.GetComponent<MapData>();
        _habitat = _mapData.habitat;
    }

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }
    
    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
