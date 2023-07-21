using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{
    public float health = 100f;
    public Text healthText;
    public GameManager gameManager;
    public void Hit(float damage)
    {
        health -= damage;
        healthText.text =health.ToString()+" Health";

        if (health <= 0f)
        {
            gameManager.EndGame();
        }
        
    }
    
    
}
