using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipController : MonoBehaviour
{
	[SerializeField] float speed;
	public bool isMoving;
	Vector3 origPos;
	Vector3 targetPos;

	private void Start()
	{
		//targetPos = transform.parent.gameObject.transform.GetChild(0).transform.position;
		StartCoroutine(Movement());

	}
	IEnumerator Movement()
	{
		origPos = transform.position;
		while (!isMoving)
		{
			//transform.position = Vector3.MoveTowards(origPos, targetPos, speed);
			transform.Translate(Vector3.back * speed * Time.deltaTime);
			yield return null;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("EndToRoad"))
		{
		isMoving = true;
			GameManager.Instance.SpawnIsland();
		}
	}

}
