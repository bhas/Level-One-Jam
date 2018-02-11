using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunScript : MonoBehaviour
{
	public GameObject AngryEyes;
	public GameObject ChillEyes;
	public GameObject DeadEyes;
	public GameObject bulletPrefab;
	public Animator animator;
	private bool shooting;
	private bool isDead;
	

	[Header("Fire stats")]
	public float cooldown;
	[Range(0f, 1f)]
	public float accuracy;

	protected void Update()
	{
		if (!isDead && Input.GetKeyDown(KeyCode.Space))
		{
			Shooting = true;
			SetEyes(AngryEyes);

		}
		if (!isDead && Input.GetKeyUp(KeyCode.Space))
		{
			Shooting = false;
			SetEyes(ChillEyes);

		}

		if (Input.GetKeyUp(KeyCode.Delete))
		{
			isDead = true;
			SetEyes(DeadEyes);
		}
		if (Input.GetKeyUp(KeyCode.R))
		{
			isDead = false;
			SetEyes(ChillEyes);
		}
	}

	private void SetEyes(GameObject eyes)
	{
		AngryEyes.SetActive(false);
		ChillEyes.SetActive(false);
		DeadEyes.SetActive(false);
		eyes.SetActive(true);
	}

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
		var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		var rb = bullet.GetComponent<Rigidbody2D>();

		var randomOffset = Random.insideUnitCircle * (1f - accuracy);
		rb.velocity = ((Vector2)transform.up + randomOffset).normalized * 20;
		print("Pew");
	}
}
