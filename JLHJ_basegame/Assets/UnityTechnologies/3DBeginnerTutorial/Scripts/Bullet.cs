using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public float bulletMove;

    void Start()
    {
        bulletMove = bulletSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        transform.Translate(0, 0, bulletMove);
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
        else
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 3f);
    }
}
