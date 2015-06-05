using UnityEngine;
using System.Collections;

public class MineBullet : MonoBehaviour
{
  public GameObject bullet;
  public float bulletSpeed = 15.0f;

  // Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
    //Doesn't move
	}

  void OnDestroy()
  {
    explode();
  }

  void explode()
  {
    Vector2 bulletDirection;

    bulletDirection = new Vector2(1, 0);
    GameObject b1 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b1.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(1, 1);
    GameObject b2 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b2.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(0, 1);
    GameObject b3 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b3.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(-1, 1);
    GameObject b4 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b4.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(-1, 0);
    GameObject b5 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b5.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(-1, -1);
    GameObject b6 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b6.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(0, -1);
    GameObject b7 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b7.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = new Vector2(1, -1);
    GameObject b8 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b8.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);
  }
}
