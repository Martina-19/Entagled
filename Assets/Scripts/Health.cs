using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] public int maxHealth = 3;
    public int currentHealth;

    [SerializeField] private AudioClip hurtClip;
    private AudioSource _audioSource;

    [SerializeField] private Image[] hearts;
    
    // Start is called before the first frame update
    void Start()
    {
        // Whenever game restarts the seal will be back to maximum health
        currentHealth = maxHealth;

        _audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        _audioSource.PlayOneShot(hurtClip);

        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < currentHealth;
        }


        if (currentHealth <= 0)
        {
            // Seal will be dead
            SceneManager.LoadScene("EndScreen"); //"    " is the name of the scene
        }
    }
}    