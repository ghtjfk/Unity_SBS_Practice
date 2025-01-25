using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon
{
    public string name;
    public int damage;

    public Weapon()
    {
        name = "Unknown";
        damage = 10;
    }

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}
public class Player : MonoBehaviour
{
    public Weapon weapon;

    public Player()
    {
        weapon = new Weapon();
    }
   
    
    public Player(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage);
    }

    private void Start()
    {
        Debug.Log("Player's weapon: " + weapon.name + " with damage: " + weapon.damage);   
    }
}
