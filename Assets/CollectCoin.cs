using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    //Keep track of total picked coins (Since the value is static, it can be accessed at "CollectCoin.totalCoins" from any script)
    public static int totalCoins = 0; 

    void Awake()
    {
        //Make Collider as trigger 
        GetComponent<Collider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        //Add coin to counter
        totalCoins++;
        //Test: Print total number of coins
        Debug.Log("You currently have " + CollectCoin.totalCoins + " Coins.");
        //Destroy coin
        Destroy(gameObject);
    }
}
