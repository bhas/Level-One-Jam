using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class KamikazeController : MonoBehaviour
{
	public Transform Target;
	public GameObject TurtlePrefab;
	public GameObject explosionPrefab;
	private GameObject instance;

	// Use this for initialization
	void Start()
	{
		instance = Instantiate(TurtlePrefab, Target.position, Quaternion.identity);
	}

	// Update is called once per frame
	void Update()
	{
		if (instance != null && Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(DestroyTurtle());
		}
		if (instance == null && Input.GetKeyDown(KeyCode.R))
		{
			instance = Instantiate(TurtlePrefab, Target.position, Quaternion.identity);
		}
	}

	IEnumerator DestroyTurtle()
	{
		var expl = Instantiate(explosionPrefab, Target.position + Vector3.up * 3, Quaternion.identity);
		//yield return new WaitForSeconds(0.5f);
		Destroy(instance);
		yield return new WaitForSeconds(1f);
		Destroy(expl);
	}
}
