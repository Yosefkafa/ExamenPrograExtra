using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour,IEnemy
{
    public event Action<Enemy> OnDeath;

    void Start()
    {
        ObserverScore.RegisterEnemy(this);
    }

    public virtual void Move()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            WhenDestroyed();
           Destroy(this.gameObject);
        }
    }
    void WhenDestroyed()
    {
        OnDeath(this);
    }
}