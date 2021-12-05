using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] Transform[] spawnPositions;
	[SerializeField] GameObject _enemyShip;
	[SerializeField] GameObject _pirate;

	private void Start()
	{
		StartCoroutine(ShipSpawnTimer());

	}
	private void SpawnShip()
	{
		int i = Random.Range(0, spawnPositions.Length);
		int a = Random.Range(0, 3);
		Debug.Log(a);
		if (a%2==1)
		{
			var enemy = Instantiate(_pirate, spawnPositions[i].position, Quaternion.identity);
			enemy.transform.parent = transform.GetChild(0);
		}
		else
		{
			var enemy = Instantiate(_enemyShip, spawnPositions[i].position, Quaternion.identity);
			enemy.transform.parent = transform.GetChild(0);
		}

	}
	IEnumerator ShipSpawnTimer()
	{
		while(GameManager.Instance._enemyCount>0)
		{
			SpawnShip();
			GameManager.Instance.totalEnemy++;
			GameManager.Instance._enemyCount--;
			yield return new WaitForSecondsRealtime(2f);
		}
	}
}
