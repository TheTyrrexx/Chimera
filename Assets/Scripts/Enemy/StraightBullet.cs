using UnityEngine;
using System.Collections;

public class StraightBullet : MonoBehaviour
{
  BulletPhysics physics;

	// Use this for initialization
	void Start ()
  {
	  physics = GetComponent<BulletPhysics>();
	}
	
	// Update is called once per frame
	void Update ()
  {
    moveStraight();
	}

  void moveStraight()
  {
    //Moves in preset direction.
    GetComponent<Rigidbody2D>().velocity = physics.getDir().normalized * physics.getSpeed();
  }
}
