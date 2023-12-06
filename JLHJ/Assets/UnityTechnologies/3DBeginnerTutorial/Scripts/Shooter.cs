using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float fireSpeed = 3f;
    public float bulletSpeed;

    private void Start()
    {
        bulletSpeed = fireSpeed * Time.deltaTime;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
