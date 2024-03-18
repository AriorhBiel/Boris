using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachter : MonoBehaviour
{
    public int maxHP = 1000;
    public int currentHP = 1000;
    [SerializeField] StatusBar HpBar;

    public void TakeDamage(int damage) {
        currentHP -= damage;
        if (currentHP <= 0 ) {
            Debug.Log("Charachter is dead");
        }
        HpBar.SetState(currentHP, maxHP);
    }
    public void Heal(int amount) {
        if (currentHP <= 0) {return;}
        currentHP += amount;
        if (currentHP > maxHP) {
            currentHP = maxHP;
        }
    }
}
