using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;

    public int playerMoney = 0;

    public int moneyToWin = 1000;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMoney == moneyToWin)
        {
            VictoryByMoney();
        }
    }

    void VictoryByMoney()
    {

    }

    public void WinMoney(int money)
    {
        playerMoney += money;
    }

}
