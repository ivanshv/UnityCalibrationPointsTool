using UnityEngine;
using System.Collections;

public class MousePosition : MonoBehaviour
{
	
	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Debug.Log(Input.mousePosition.x.ToString("F4") + ", " +Input.mousePosition.y.ToString("F4"));
		}
	}
}