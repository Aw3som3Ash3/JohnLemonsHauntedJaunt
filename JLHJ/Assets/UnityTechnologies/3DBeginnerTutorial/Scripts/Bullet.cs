using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    float bulletMove;
    public float bulletLife = 5f;

    void Start()
    {
        bulletMove = bulletSpeed * Time.deltaTime;
    }

    void Update()
    {
        transform.Translate(0, 0, bulletMove);

        Destroy(gameObject, bulletLife);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ghost")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.tag == "Player")
        {
            return;
        }
        else if (other.tag == "bullet")
        {
            return;
        }
        else if (other.tag == "pov")
        {
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
