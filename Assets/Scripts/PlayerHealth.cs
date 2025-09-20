using UnityEngine;
using TMPro;        // Using this for TextMeshPro


public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public TMP_Text healthText;
    public Animator healthTextAnim;

    public void Start()
    {
        healthText.text = "HP : " + currentHealth + " / " + maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthText.text = "HP : " + currentHealth + " / " + maxHealth;
        healthTextAnim.Play("TextUpdate");

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);

            /*
            // Optionally, you can add more logic here for when the player dies
            transform.position = new Vector3(0, 10, 0);
            // Move player to a safe position
            currentHealth = maxHealth;
            healthText.text = "HP : " + currentHealth + " / " + maxHealth;
            gameObject.SetActive(true);
            */
        }
    }
}
