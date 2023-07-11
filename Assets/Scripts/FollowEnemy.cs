using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : Enemy
{
    [SerializeField] private Transform player;
    [SerializeField]  private float velocidad;

    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        Vector3 direccion = (player.position - transform.position).normalized;
        rb.velocity = direccion * velocidad;
    }
}
