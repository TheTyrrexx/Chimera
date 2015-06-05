using UnityEngine;
using System.Collections;

public class EightWayShot : MonoBehaviour
{
  public GameObject bullet;

  public float bulletSpeed;
  public Vector2 bulletDirection;

  private float timeLastBullet;
  public float bulletDelay;

	// Use this for initialization
	void Start ()
  {

	}
	
	// Update is called once per frame
	void Update ()
  {
    if (timeLastBullet >= bulletDelay)
    {
      shoot(transform);
    }
    timeLastBullet += Time.deltaTime;
	}

  public void shoot(Transform origin)
  {
    //Vector2 playerPos = GetComponent<TrackPlayer>().playerPosition;
    //bulletDirection = playerPos - (Vector2)transform.position;

    timeLastBullet = 0.0f;

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
