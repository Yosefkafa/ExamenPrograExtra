using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnemy : Enemy
{
    void Awake()
    {
        Move();
    }

    public override void Move()
    {
        GetComponent<Rigidbody>().velocity = Vector3.left*60;
    }
}
