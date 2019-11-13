﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 3f;    

    private Rigidbody enemyRB;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {        
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDir = ((player.transform.position - transform.position).normalized);
        enemyRB.AddForce(lookDir * speed);
    }
}
