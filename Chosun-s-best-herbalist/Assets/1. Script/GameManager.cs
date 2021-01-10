using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int characterHP;
    public int characterLevel;
    public int characterExperience;
    public int characterMoney;
    private readonly int[] _levelStep = new int[] { 10, 20, 30, 40};
    public Dictionary<int, int> inventory;
    public bool isAction;

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
        
        InitGame();
    }

    public static GameManager Instance => instance ? instance : null;

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
        isAction = false;
        
        questStep = 0;
    }


    public void ChanegeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void GetItem(GameObject Item)
    {
        if (Item.CompareTag("Herb"))
        {
            HerbData herbData = Item.GetComponent<HerbData>();
            inventory[herbData.herbId]++;
        }

        isAction = false;
    }

    void GetExp(int point)
    {
        // Do Something
    }
}
