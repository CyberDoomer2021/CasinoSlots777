using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScr : MonoBehaviour
{
    [SerializeField] Text MoneyCount;
    [SerializeField] Text PrizesCount;
    public static CountScr S;
    int money = 0;
    int prizes = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        if (S == null) S = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        
    }


    public void Count(string p)
    {
        if(p =="Podarok")
        {
            prizes++;
            PrizesCount.text = prizes.ToString();
        }
        else
        {
            money++;
            MoneyCount.text = money.ToString();
        }
    }
    
}
