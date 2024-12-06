using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerHealth : MonoBehaviour
{

    public static PlayerHealth Instance;

    public int maxHealth, currentHealth;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UI.instance.healthSlider.maxValue = maxHealth;
        UI.instance.healthSlider.value = currentHealth;
        UI.instance.healthText.text = "HEALTH: " + currentHealth + "/" + maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamagePlayer(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);

            currentHealth = 0;

            GameManager.instance.PlayerDeath();
        }

        UI.instance.healthSlider.value = currentHealth;
        UI.instance.healthText.text = "HEALTH: " + currentHealth + "/" + maxHealth;
    }

}
