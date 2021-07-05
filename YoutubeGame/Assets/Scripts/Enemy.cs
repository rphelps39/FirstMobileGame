using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {
        //rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Debug.Log(gameObject.transform.position.x);
        if(gameObject.transform.position.x < -5)
        {
            //rb.velocity = transform.right * speed;
        }
        //Debug.Log(gameObject.transform.position);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
