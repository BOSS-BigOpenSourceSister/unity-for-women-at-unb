﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    public int coins = 0;
    

    public Text CoinText;

    
    void Start()
    {
        CoinText.text = "Coins: " + coins;     
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {        
         
            if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "Coins: " + coins; 
                Destroy(other.gameObject);
            }       

        }      
}

