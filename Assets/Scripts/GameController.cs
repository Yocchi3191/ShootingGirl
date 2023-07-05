using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player_prefab; //�v���C���[�̃v���n�u
    public GameObject enemy_prefab; //�U�R�G�̃v���n�u
    public GameObject player_instance; //�Q�[���V�[�����̃v���C���[�I�u�W�F�N�g
    public GameObject enemy_instance; //�Q�[���V�[�����̃U�R�G�I�u�W�F�N�g


    // Start is called before the first frame update
    void Start()
    {
        player_instance = GameObject.FindWithTag("Player"); //�v���C���[�̃C���X�^���X��ϐ��ɃA�^�b�`
        enemy_instance = GameObject.FindWithTag("Enemy"); //�U�R�G�̃C���X�^���X��ϐ��ɃA�^�b�`

        StartCoroutine(PlayerSpawn()); //�v���C���[�̃X�|�[���R���[�`�����J�n
        StartCoroutine(EnemySpawn()); //�G�̃X�|�[���R���[�`�����J�n
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PlayerSpawn()  // �v���C���[�̃X�|�[��
    {
        yield return new WaitForSeconds(1); //1�b�҂���
        Instantiate(player_prefab); //�ŃC���X�^���X��(�X�|�[��)
        player_instance = GameObject.FindWithTag("Player"); //�ϐ��ɍăA�^�b�`
        yield return null;

    }

    private IEnumerator EnemySpawn()   // �G�̃X�|�[���B�@�\��PlayerRespawn()�̃U�R�G��
    {
        yield return new WaitForSeconds(1);
        Instantiate(enemy_prefab);
        enemy_instance = GameObject.FindWithTag("Enemy");
        yield return null;

    }
}