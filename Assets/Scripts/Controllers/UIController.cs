using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
	GameManager gameManager;
	[SerializeField] TextMeshProUGUI ammoText;
	[SerializeField] GameObject levelFailed;
	[SerializeField] GameObject levelSuccess;
	[SerializeField] GameObject background;
	private void Start()
	{
		gameManager = GameManager.Instance;
		gameManager.ShootEvent += Shooted;
		gameManager.isGameEndEvent += GameEndCheck;
		gameManager.LevelFailedEvent += LevelFailed;
		ammoText.text = gameManager._ammo.ToString();
	}
	private void OnDisable()
	{
		gameManager.ShootEvent -= Shooted;
		gameManager.isGameEndEvent -= GameEndCheck;
		gameManager.LevelFailedEvent-= LevelFailed;

	}

	private void Shooted()
	{
		gameManager._ammo--;
		ammoText.text = gameManager._ammo.ToString();
	}
	private void GameEndCheck()
	{
		if (gameManager.enemyKilled>=gameManager.enemies && gameManager.enemyKilled==gameManager.totalEnemy)
		{
			levelSuccess.SetActive(true);
			background.SetActive(true);
		}
	}
	private void LevelFailed()
	{
		levelFailed.SetActive(true);
		background.SetActive(true);
	}
	public void GameScene()
	{
		gameManager.ResetValues();
		SceneManager.LoadScene("WorkShop");
	}

	public void Menu()
	{
		gameManager.ResetValues();
		SceneManager.LoadScene("Menu");
	}

	public void RestartLevel()
	{
		gameManager.ResetValues();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
