﻿using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;

    public float healthBonus = 10f;

    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerHealth.cur_Health < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.cur_Health = playerHealth.cur_Health + healthBonus;
        }
    }
}
