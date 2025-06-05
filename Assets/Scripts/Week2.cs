using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class Week2 : MonoBehaviour
{
    int playerHealth = 200;
    int enemyAttack;

    // Start is called before the first frame update
    void Start()
    {

        enemyAttack = Random.Range(20, 300);

        bool isPlayerDead = enemyAttack > playerHealth;

        Debug.Log("the player's health is " + playerHealth + "the enemyt attack is " + enemyAttack);
        Debug.Log("the attack is " + isPlayerDead);


        if (isPlayerDead)
        {
            Debug.Log("the player is dead");
         
        }
    }

    // Update is called once per frame
    void Update()
    {
      



    }
}
