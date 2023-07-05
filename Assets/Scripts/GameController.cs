using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player_prefab; //プレイヤーのプレハブ
    public GameObject enemy_prefab; //ザコ敵のプレハブ
    public GameObject player_instance; //ゲームシーン中のプレイヤーオブジェクト
    public GameObject enemy_instance; //ゲームシーン中のザコ敵オブジェクト


    // Start is called before the first frame update
    void Start()
    {
        player_instance = GameObject.FindWithTag("Player"); //プレイヤーのインスタンスを変数にアタッチ
        enemy_instance = GameObject.FindWithTag("Enemy"); //ザコ敵のインスタンスを変数にアタッチ

        StartCoroutine(PlayerSpawn()); //プレイヤーのスポーンコルーチンを開始
        StartCoroutine(EnemySpawn()); //敵のスポーンコルーチンを開始
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PlayerSpawn()  // プレイヤーのスポーン
    {
        yield return new WaitForSeconds(1); //1秒待って
        Instantiate(player_prefab); //最インスタンス化(スポーン)
        player_instance = GameObject.FindWithTag("Player"); //変数に再アタッチ
        yield return null;

    }

    private IEnumerator EnemySpawn()   // 敵のスポーン。機能はPlayerRespawn()のザコ敵版
    {
        yield return new WaitForSeconds(1);
        Instantiate(enemy_prefab);
        enemy_instance = GameObject.FindWithTag("Enemy");
        yield return null;

    }
}