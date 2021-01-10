using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
    public static UIManager instance = null;
    public bool onMenu;
    public bool isTalk;
    public bool onInven;
    public bool onQuest;

    private void Awake()
    {
        if (instance)
            Destroy(this.gameObject);

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        Debug.Log("UIManager 생성");
        Init();
    }

    public static UIManager Instance => instance ? instance : null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC");
            Menu();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C");
            Inventory();
        }
    }

    void Init()
    {
        onMenu = false;
        isTalk = false;
        onInven = false;
        onQuest = false;
    }

    public void TalkToNPC(GameObject NPC)
    {
        if(isTalk)  // Exit Action
        {
            isTalk = false;
        }
        else
        {  
            isTalk = true;
        }
        transform.GetChild(1).gameObject.SetActive(isTalk);
    }

    public void Menu()
    {
        if (onMenu)
        {
            onMenu = false;
        }
        else
        {
            onMenu = true;
        }
        transform.GetChild(2).gameObject.SetActive(onMenu);
    }

    public void Inventory()
    {
        if(onInven)  // Exit Action
        {
            onInven = false;
        }
        else
        {  
            onInven = true;
        }
        transform.GetChild(4).gameObject.SetActive(onInven);
    }
    
    public void Quest()
    {
        if(onQuest)  // Exit Action
        {
            onQuest = false;
        }
        else
        {  
            onQuest = true;
        }
        transform.GetChild(5).gameObject.SetActive(onQuest);
    }
}
