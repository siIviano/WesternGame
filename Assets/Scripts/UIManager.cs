using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtPlayerMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIRefreshplayerMoney(ResourceManager.instance.playerMoney);
    }

    void UIRefreshplayerMoney(int playerMoney)
    {
        txtPlayerMoney.text = playerMoney + "$";
    }
}
