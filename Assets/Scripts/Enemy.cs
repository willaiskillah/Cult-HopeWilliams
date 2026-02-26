using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public EnemyPointsSystem enemyhealthBar;
    public int maxhealth = 100; 
    public int currentHealth; 
    public float timeStart;
    public float timeOut;
    public GameObject YouWinYay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxhealth;
        enemyhealthBar.SetMaxHealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        float startTime = Time.time;
        float currentTime = Time.time;

        Debug.Log("Current Health: " + currentHealth);
        if (currentTime >= timeOut)
        {
            YouWin();
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            TakeDamage(2);
        }

    void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        currentHealth -= damage;
        enemyhealthBar.SetHealth(currentHealth);
    }
    }

    public void YouWin()
    {
       if (currentHealth <= 0)
       {
           // Trigger you win logic
           YouWinYay.SetActive(true);
       }

        if (YouWinYay.activeSelf)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
}
}
