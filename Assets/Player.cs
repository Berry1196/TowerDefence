using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public static int currentHealth = 20;

	public HealthBar healthBar;
	public bool isDead = false;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		//healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth <= 0 && !isDead)
		{
			Die();
		}

	}

	void TakeDamage(int damage)
	{
		FindObjectOfType<AudioManager>().Play("PlayerHit");
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void Die()
	{
		isDead = true;
		FindObjectOfType<AudioManager>().Play("DeathEffect");
		Debug.Log("Player died.");

	}
}