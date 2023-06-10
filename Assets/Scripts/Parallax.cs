using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Vector2 velocity;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D playerRB;


    
    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = playerRB.velocity.x * 0.1f *velocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
