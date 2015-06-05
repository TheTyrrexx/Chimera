using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour
{
	// Use this for initialization
	void Start ()
  {

	}
	
	// Update is called once per frame
	void Update ()
  {

	}

  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);
    var objBody = c.gameObject.GetComponent<Rigidbody2D>();
    //playerBody.fixedAngle = true;

    Debug.Log("Colliding!");

    if (layerName == "Player")
    {
      Debug.Log("Hit Player");
      objBody.velocity = new Vector2(0.0f, 0.0f);
    }

    if(layerName == "PlayerBullet")
    {
      Debug.Log("Hit P. Bullet");
      c.gameObject.GetComponent<BulletPhysics>().isAlive = false;
    }

    if(layerName == "EnemyBullet")
    {
      Debug.Log("Hit E. Bullet");
      c.gameObject.GetComponent<BulletPhysics>().isAlive = false;
    }
  }
}
