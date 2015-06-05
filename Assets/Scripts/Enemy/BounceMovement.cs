using UnityEngine;
using System.Collections;
using System;

public class BounceMovement : MonoBehaviour
{
  public float movementVelocity = 10f;
  public Vector2 moveDirection;
  public Vector2 faceDirection;
  System.Random rand;

	// Use this for initialization
	void Start ()
  {
    rand = new System.Random(Guid.NewGuid().GetHashCode());
    moveDirection = new Vector2(rand.Next(-100, 100), rand.Next(-100, 100));
    faceDirection = gameObject.transform.forward;
	}
	
	// Update is called once per frame
	void Update ()
  {
    lookForward();
    var enemyBody = GetComponent<Rigidbody2D>();
    Vector2 move = moveDirection.normalized * movementVelocity;
    enemyBody.velocity = move;
	}

  public void lookForward()
  {
    faceDirection = (moveDirection * 100) - (Vector2)transform.position;
    float angle = Mathf.Atan2(faceDirection.y, faceDirection.x) * Mathf.Rad2Deg;
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
  }

  //Fix to use actual angle of reflection.
  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);

    if(layerName == "ArenaWall")
    {
      if(c.gameObject.name == "LVerticleArenaWall" || c.gameObject.name == "RVerticleArenaWall")
      {
        Debug.Log("Hit L or R");
        moveDirection = new Vector2(-moveDirection.x, moveDirection.y);
      }
      if(c.gameObject.name == "THorizontalArenaWall" || c.gameObject.name == "BHorizontalArenaWall")
      {
        moveDirection = new Vector2(moveDirection.x, -moveDirection.y);
      }
    }
  }
}
