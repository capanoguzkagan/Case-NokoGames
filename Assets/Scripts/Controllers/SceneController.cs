using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
	public void GameScene()
	{
		SceneManager.LoadScene("WorkShop");
	}
}