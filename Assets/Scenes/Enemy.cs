using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int speed;
    public int health;

    public abstract void Attack();
    public virtual void Die()
    {
        Debug.Log("I am dead");
    }
}

public class Robot :Enemy
{
    public override void Attack()
    {
        Debug.Log("This is attack Method");
    }

    public override void Die()
    {
        base.Die();
    }
}