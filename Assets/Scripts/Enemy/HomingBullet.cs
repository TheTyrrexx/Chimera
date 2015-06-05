using UnityEngine;
using System.Collections;

public class HomingBullet : MonoBehaviour
{
  BulletPhysics physics;
  TrackPlayer tracking;

  // Use this for initialization
	void Start ()
  {
	  physics = GetComponent<BulletPhysics>();
    tracking = GetComponent<TrackPlayer>();
	}
	
	// Update is called once per frame
	void Update ()
  {
	  moveHoming();
	}

  void moveHoming()
  {
    //Moves in preset direction.
    GetComponent<Rigidbody2D>().velocity = tracking.playerDirection.normalized * physics.getSpeed();
  }
}
