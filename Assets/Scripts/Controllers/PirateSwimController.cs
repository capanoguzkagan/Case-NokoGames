using System.Collections;
using WaterSystem;
using UnityEngine;

public class PirateSwimController : MonoBehaviour
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
			Destroy(gameObject);
		}
	}
}
