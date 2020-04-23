using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    private Rigidbody bullet;

    public float speed = 5.0f;

    void Start()
    {
        bullet = GetComponent<Rigidbody>();
        Fire();
    }

    private void Fire()
    {
        Vector3 direction = new Vector3(0, 0, 1);
        bullet.velocity =  direction * speed;
    }




}
