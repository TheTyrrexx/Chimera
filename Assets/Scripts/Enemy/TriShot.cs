using UnityEngine;
using System.Collections;

public class TriShot : MonoBehaviour
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
    timeLastBullet = 0.0f;

    Debug.Log(transform.rotation * Vector2.right);

    bulletDirection = transform.rotation * Vector2.right;
    bulletDirection = Quaternion.Euler(0, 0, 45) * bulletDirection;
    GameObject b1 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b1.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = transform.rotation * Vector2.right;
    GameObject b2 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b2.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);

    bulletDirection = transform.rotation * Vector2.right;
    bulletDirection = Quaternion.Euler(0, 0, -45) * bulletDirection;
    GameObject b3 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b3.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);
  }
}
