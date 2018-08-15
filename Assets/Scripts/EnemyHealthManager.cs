using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHelath;
    public int CurrentHealth;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHelath;

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }

    public void HurtEnemy(int damageToGive)
    {
       
        CurrentHealth -= damageToGive;

    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHelath;
    }


}
