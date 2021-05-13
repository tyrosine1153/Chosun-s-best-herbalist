using UnityEngine;

// System Object
public class UGUIManager : Singleton<UGUIManager>
{
    [SerializeField] private bool onMenu;
    [SerializeField] private bool onChatBox;
    [SerializeField] private bool onInven;
    [SerializeField] private bool onQuest;
    [SerializeField] private GameObject canvas;

    private GameObject _chatBox;
    private GameObject _menu;
    private GameObject _inventory;
    private GameObject _quest;
    
    private void Start()
    {
        Init();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC");
            Menu();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I");
            Inventory();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q");
            Quest();
        }
    }
    
    void Init()
    {
        _chatBox = canvas.transform.GetChild(2).gameObject;
        _menu = canvas.transform.GetChild(3).gameObject;
        _inventory = canvas.transform.GetChild(4).gameObject;
        _quest = canvas.transform.GetChild(5).gameObject;

        _chatBox.SetActive(onChatBox = false);
        _menu.SetActive(onMenu = false);
        _inventory.SetActive(onInven = false);
        _quest.SetActive(onQuest = false);
    }

    public void TalkToNpc(GameObject npc)
    {
        onChatBox = !onChatBox;
        _chatBox.SetActive(onChatBox);
    }

    private void Menu()
    {
        onMenu = !onMenu;
        _menu.SetActive(onMenu);
    }

    private void Inventory()
    {
        onInven = !onInven;
        _inventory.SetActive(onInven);
    }

    private void Quest()
    {
        onQuest = !onQuest;
        _quest.SetActive(onQuest);
    }
}

