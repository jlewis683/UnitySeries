using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour
{
	public int health;

	void Start()
	{
		DamagePlayer (5);
	}

	void DamagePlayer(int damage)
	{
		health -= damage;
	}

	void Update()
	{
		if (health <= 0) 
		{
			health = 0;
			Destroy (gameObject, 2f);
			Debug.Log ("The player has died. Health: " + health);
		} else if(health >= 15)
		{
			print ("You have a lot of health: " + health);
		}
	}
}