using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject player_prefab;
    public GameObject enemy_prefab;


    // Start is called before the first frame update
    void Start()
    {
        player_prefab = GameObject.FindWithTag("Player");
        enemy_prefab = GameObject.FindWithTag("Enemy");

        StartCoroutine(PlayerRespawn());
        StartCoroutine(EnemyRespawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PlayerRespawn()  // �v���C���[�̃��X�|�[��
    {
        while (true)
        {
            if (player_prefab == null)
            {
                yield return new WaitForSeconds(1);
                Instantiate(player);
                player_prefab = GameObject.FindWithTag("Player");
            }
            else
            {
                yield return null;
            }
        }
    }

    private IEnumerator EnemyRespawn()   // �G�̃��X�|�[��
    {
        while (true)
        {
            if (enemy_prefab == null)
            {
                yield return new WaitForSeconds(1);
                Instantiate(enemy);
                enemy_prefab = GameObject.FindWithTag("Enemy");
            }
            {
                yield return null;
            }
        }
    }
}