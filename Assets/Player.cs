using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
	public bool isDead = false;


	public static int Money;
	public int startMoney = 400;

	public static int waveNumber;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		Money = startMoney;
		waveNumber = 0;
	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth <= 0 && !isDead)
		{
			Die();
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{

			int damageAmount = 10;

			TakeDamage(damageAmount);
		}
	}

	public void TakeDamage(int damage)
	{
		FindObjectOfType<AudioManager>().Play("DamageTaken");
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