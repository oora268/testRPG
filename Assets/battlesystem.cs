using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battlesystem : MonoBehaviour
{
    enum BattleState
    {
        command,
        enemy,
        player,
        victory,
        lose
    }
    BattleState battlestate;
    public int playerHP;
    public int playerATK;
    public int enemyHP;
    public int enemyATK;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attack()
    {
        enemyHP -= playerATK;
        Debug.Log("PlayerATK" + playerATK);
        Debug.Log("プレイヤーの攻撃!" + "敵に" + playerATK + "のダメージ!");
        Debug.Log("EnemyHP" + enemyHP);
        if (enemyHP <= 0)
        {
            battlestate = BattleState.victory;
            return;
        }
        battlestate = BattleState.enemy;
        EnemyTurn();
    }
    public void EnemyTurn()
    {
        playerHP -= enemyATK;
        Debug.Log("PlayerHP" +playerHP);
        Debug.Log("敵の攻撃!" + "敵に" + enemyATK + "のダメージ!");
        Debug.Log("EnemyHP" +enemyATK);
        if (playerHP <= 0)
        {
            battlestate = BattleState.lose;
            return;
        }
        battlestate = BattleState.command;
    }
}
