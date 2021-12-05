using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
	[SerializeField] float cannonBallForce = 50;
	[SerializeField] GameObject cannonBall;
	[SerializeField] Transform firePoint;
	[SerializeField] Transform fireDirectionPoint;
	[SerializeField] Vector2 cannonPosBorderX;
	[SerializeField] Vector2 cannonPosBorderY;
	GameManager _gameManager;
	InputController _inputActions;

	private bool isPressed;


	Vector2 joystickPos;
	void Awake()
	{
		_gameManager = GameManager.Instance;
	}
	private void Start()
	{
		_inputActions = new InputController();
		_inputActions.Enable();
		_inputActions.Movement.Press.performed += (context) => StartCoroutine(CanonRotation());
		_inputActions.Movement.Release.performed += (context) => ReleaseTriggered();
	}
	private void OnDisable()
	{
		_inputActions.Disable();
		_inputActions.Movement.Press.performed -= (context) => StartCoroutine(CanonRotation());
		_inputActions.Movement.Release.performed -= (context) => ReleaseTriggered();
	}
	void Shooting()
	{
		if (_gameManager._ammo>0)
		{
			GameObject bullet = Instantiate(cannonBall, firePoint.position, firePoint.rotation);
			Vector3 dir = new Vector3(fireDirectionPoint.position.x, fireDirectionPoint.position.y, fireDirectionPoint.position.z);
			Rigidbody rbBullet = bullet.GetComponent<Rigidbody>();
			rbBullet.AddForce(dir * cannonBallForce, ForceMode.Impulse);
			Destroy(bullet, 5f);
			_gameManager.Shoot();
		}
		else
		{
			Debug.Log("No Ammo");
		}
	}

	#region CannonRotation
	private void ReleaseTriggered()
	{
		isPressed = false;
		if (joystickPos == new Vector2(0, 0))
		{
			Shooting();	
		}
	}

	IEnumerator CanonRotation()
	{
		isPressed = true;
		while (isPressed)
		{
			joystickPos = _inputActions.Movement.Joystick.ReadValue<Vector2>();

			var xAxis = transform.eulerAngles.x + (joystickPos.y / 2);
			var yAxis = transform.eulerAngles.y + (joystickPos.x / 2);

			if (yAxis < cannonPosBorderX.x && yAxis>0)
			{
				yAxis = cannonPosBorderX.x;
			}
			else if (yAxis > cannonPosBorderX.y && yAxis < 360)
			{
				yAxis = cannonPosBorderX.y;
			}
			if (xAxis > cannonPosBorderY.x && xAxis < 180)
			{
				xAxis = cannonPosBorderY.x;
			}
			else if (xAxis < cannonPosBorderY.y && xAxis > 180)
			{
				xAxis = cannonPosBorderY.y;
			}

			transform.rotation = Quaternion.Euler(xAxis, yAxis, 0);
	
			
			yield return null;
		}
	}
	#endregion
}
