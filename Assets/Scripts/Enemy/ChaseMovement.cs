using System.Collections;
using UnityEngine;

public class ChaseMovement : MonoBehaviour
{
  public float movementVelocity = 0.15f;

  // Use this for initialization
	void Start ()
  {

	}
	
	// Update is called once per frame
	void Update ()
  {
    Vector2 dir = GetComponent<TrackPlayer>().playerDirection;
    var enemyBody = GetComponent<Rigidbody2D>();
    Vector2 move = dir.normalized * movementVelocity;
    Debug.Log(dir);
    enemyBody.velocity = move;
  }
}
