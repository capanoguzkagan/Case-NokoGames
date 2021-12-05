using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }

	//public InputController _inputActions;
	public int _ammo;
	public int _enemyCount;
	public int totalEnemy;
	public int enemyKilled;
	public int enemies;

	public event Action ShootEvent;
	public event Action isGameEndEvent;
	public event Action SpawnIslandEvent;
	public event Action LevelFailedEvent;

	#region Enable-Disable
	private void OnEnable()
	{
	//	_inputActions.Enable();
	}
	private void OnDisable()
	{
	//	_inputActions.Disable();
	}
	#endregion

	#region Singleton
	private void SingletonThisObject()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			Destroy(this.gameObject);
		}
	}
	#endregion

	private void Awake()
	{
		SingletonThisObject();
	//	_inputActions = new InputController();
		enemies = _enemyCount;
	}
	public void SpawnIsland()
	{
		SpawnIslandEvent?.Invoke();
	}
	public void Shoot()
	{
		ShootEvent?.Invoke();
	}
	public void IsGameEnded()
	{
		isGameEndEvent?.Invoke();
	}
	public void LevelFailed()
	{
		LevelFailedEvent?.Invoke();
	}

	public void ResetValues()
	{
		_enemyCount = enemies;
		totalEnemy = 0;
		enemyKilled = 0;
		_ammo = _enemyCount * 2;
	}

}
