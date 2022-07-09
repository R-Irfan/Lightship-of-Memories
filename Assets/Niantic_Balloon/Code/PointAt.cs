using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAt : MonoBehaviour
{
	public bool alwaysLookAtCamera = true;
	public Transform target;
	void Update () {
		transform.LookAt(alwaysLookAtCamera ? Camera.main.transform : target);
	}
}
