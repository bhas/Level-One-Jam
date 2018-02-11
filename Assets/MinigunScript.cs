using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunScript : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Animator animator;
	private bool shooting;
	public float cooldown;

	public bool Shooting
	{
		get { return shooting; }

		set
		{
			shooting = value;
			animator.SetBool("Shooting", value);
			if (value)
				InvokeRepeating("SpawnBullet", 0, cooldown);
			else
				CancelInvoke();
		}
	}

	private void SpawnBullet()
	{
		print("Pew");
	}
}
