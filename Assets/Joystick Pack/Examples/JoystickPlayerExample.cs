using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
       // Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        Vector2 direction = new Vector2(variableJoystick.Vertical * -1, variableJoystick.Horizontal);
		//rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
		transform.Rotate(direction * 50 * Time.deltaTime, Space.Self);
	}
}