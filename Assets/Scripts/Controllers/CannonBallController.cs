using WaterSystem;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		EnemyShipController enemyShip = other.GetComponent<EnemyShipController>();
		PirateSwimController enemySwim = other.GetComponent<PirateSwimController>();
		PirateRunner enemyRunner = other.GetComponent<PirateRunner>();
		if (enemyShip!=null)
		{
			enemyShip.isMoving = true;
			enemyShip.gameObject.GetComponent<BuoyantObject>().enabled = false;
			enemyShip.gameObject.AddComponent<Rigidbody>();
			GameManager.Instance.enemyKilled++;
			GameManager.Instance.IsGameEnded();
			Destroy(enemyShip, 3f);
			Destroy(gameObject);
		}
		else if (enemySwim != null)
		{
			enemySwim.isMoving = true;
			enemySwim.gameObject.GetComponent<BuoyantObject>().enabled = false;
			enemySwim.gameObject.AddComponent<Rigidbody>();
			GameManager.Instance.enemyKilled++;
			GameManager.Instance.IsGameEnded();
			Destroy(enemySwim, 3f);
			Destroy(gameObject);
		}
		else if (enemyRunner)
		{
			enemyRunner.isMoving = true;
			enemyRunner.gameObject.AddComponent<Rigidbody>();
			GameManager.Instance.enemyKilled++;
			GameManager.Instance.IsGameEnded();
			Destroy(enemyRunner, 3f);
			Destroy(gameObject);
		}
	}
}
