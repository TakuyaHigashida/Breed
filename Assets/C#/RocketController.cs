using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
	void Update()
	{
		if ((Input.GetKey(KeyCode.A))||(Input.GetKey(KeyCode.J)))
		{
			transform.Translate(-0.005f, 0, 0);
		}
		if ((Input.GetKey(KeyCode.D))||(Input.GetKey(KeyCode.L)))
		{
			transform.Translate(0.005f, 0, 0);
		}
		if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.I)))
		{
			transform.Translate(0.0f, 0.005f, 0);
		}
		if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.K)))
		{
			transform.Translate(0.0f, -0.005f, 0);
		}

	}
}
