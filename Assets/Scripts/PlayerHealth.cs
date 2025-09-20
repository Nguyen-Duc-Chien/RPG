using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        if (currentHealth <= 0)
        {
            Debug.Log("Player has died.");
            gameObject.SetActive(false);

            transform.position = new Vector3(0, 0, 0);
            currentHealth = maxHealth; // Reset health for next time
        }
    }
}
