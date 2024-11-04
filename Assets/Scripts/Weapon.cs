using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage { get { return damage; } set { damage = value; } }

    protected IShootable shooter;

    //abstract methods
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int newDamage, IShootable newShooter)
    {
        Damage = newDamage;
        shooter = newShooter;
    }

    public int GetShootDirection() //to be modify
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0) { return 1; } // right direction
        else return -1;  // left direction
    }

    private void OnTriggerEnter2D(Collider2D other) //add later
    {
        OnHitWith(other.GetComponent<Character>() );
       // Destroy( this.gameObject );  //destroy bullet
    }
}
