using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;  // �ړ����x
    public GameObject bulletPrefab; // �e�ۂ̃v���n�u���擾

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()   // �e���˃R���[�`��
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Vector3 offset = new Vector3(-1f, 0f, 0f);  // �e�ۂ�G�̑O����1���j�b�g���炷
            Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); //�e�ۂ̌����𔽓]
            Instantiate(bulletPrefab, transform.position + offset, rotation);
        }
    }
}
