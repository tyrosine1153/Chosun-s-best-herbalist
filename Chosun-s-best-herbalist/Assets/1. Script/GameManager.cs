using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int characterHP;
    public int characterMoney;
    public int characterLevel;
    public int characterExperience;
    private readonly int[] _levelStep = new int[] { };
    public Dictionary<int, int> inventory;

    public int questStep;

    private void Awake()
    {
        if (instance)
            Destroy(this.gameObject);

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        Debug.Log("GameManager 생성");
    }

    public static GameManager Instance => instance ? instance : null;

    private void Start()
    {
        InitGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("asdf");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("asdf");
        }
    }

    private void InitGame()
    {
        characterHP = 10;
        characterMoney = 0;
        characterLevel = 1;
        characterExperience = 0;
        inventory = new Dictionary<int, int>();  // 아이템 아이디, 수
        inventory.Add(1, 0);
        inventory.Add(2, 0);
        inventory.Add(3, 0);
        
        questStep = 0;
    }


    public void ChanegeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
