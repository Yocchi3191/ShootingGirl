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
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_prefab.IsDestroyed())
        {
            StartCoroutine(DelayMethod(1.0f, () =>
            {
                Debug.Log("Delay call");
                Instantiate(enemy);
                enemy_prefab = GameObject.FindWithTag("Enemy");
            }));

        }
    }

    /// <summary>
    /// 渡された処理を指定時間後に実行する
    /// </summary>
    /// <param name="waitTime">遅延時間[ミリ秒]</param>
    /// <param name="action">実行したい処理</param>
    /// <returns></returns>
    private IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action?.Invoke();
    }
}
