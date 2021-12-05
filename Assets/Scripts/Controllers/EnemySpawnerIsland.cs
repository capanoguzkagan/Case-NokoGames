using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerIsland : MonoBehaviour
{
	[SerializeField] Transform[] spawnPositions;
	[SerializeField] GameObject _pirate;

	void Start()
	{
		GameManager.Instance.SpawnIslandEvent += SpawnRunnerPirate;
	}
	private void OnDisable()
	{
		GameManager.Instance.SpawnIslandEvent -= SpawnRunnerPirate;
	}
	private void SpawnRunnerPirate()
	{
		int i = Random.Range(0, spawnPositions.Length);
		var enemy = Instantiate(_pirate, spawnPositions[i].position, Quaternion.identity);
		enemy.transform.parent = transform.GetChild(0);
	}
}
