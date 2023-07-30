using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int hp;
    public int atk;

    // 攻撃をする
    public void Attack(EnemyManager enemy)
    {
        enemy.Damage(atk);
    }

    // ダメージを受ける
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
        Debug.Log("playerの体力は" + hp);
    }

}
