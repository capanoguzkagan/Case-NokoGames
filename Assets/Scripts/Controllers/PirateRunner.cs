using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateRunner : MonoBehaviour
{
	[SerializeField] float speed;
	public bool isMoving;

	private void Start()
	{
		StartCoroutine(Movement());
	}

	IEnumerator Movement()
	{
		while (!isMoving)
		{
			transform.position = Vector3.MoveTowards(transform.position, transform.parent.transform.parent.transform.GetChild(2).transform.position, speed*Time.deltaTime);
			yield return null;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("EndToRoad"))
		{
			isMoving = true;
			GameManager.Instance.LevelFailed();
		}
	}
}
