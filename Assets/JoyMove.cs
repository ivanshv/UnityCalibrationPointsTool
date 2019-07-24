using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyMove : MonoBehaviour
{
  public float speed = 0.2f;
 private Vector3 movement_vector;

 public string MouseXJ;
 public string MouseYJ;

 private Vector2 viewPos;
 private Vector2 clampedWorldPos;

 void FixedUpdate () 
 {
  movement_vector = new Vector2 (Input.GetAxis(MouseXJ), Input.GetAxis(MouseYJ));

  if (Input.GetAxis(MouseXJ) != 0 || Input.GetAxis(MouseYJ) != 0)
  {
   transform.Translate(movement_vector*speed, Space.Self);
  }
   
  viewPos = Camera.main.WorldToViewportPoint(transform.position);
  clampedWorldPos = Camera.main.ViewportToWorldPoint( new Vector3 (Mathf.Clamp01(viewPos.x), Mathf.Clamp01(viewPos.y), 0));
  transform.position = clampedWorldPos;
 }
}