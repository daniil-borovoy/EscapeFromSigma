﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private AddRoom room;
    public GameObject effect;

    private void Start()
    {
        room = GetComponentInParent<AddRoom>();
    }
    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            room.enemies.Remove(gameObject);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
