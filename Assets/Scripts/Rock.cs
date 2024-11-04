using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    Rigidbody2D rb2d;
    Vector2 force;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2( GetShootDirection() * 100, 400);
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        Debug.Log($"{this.name} move with Rigidbody:force ");
    }

    public override void OnHitWith(Character character)
    {
        Console.WriteLine($"{this.name}: Overriding OnHitWith(Character) ");
    }
}
