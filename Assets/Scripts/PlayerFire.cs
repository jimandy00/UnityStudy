using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // �Ѿ� ����
    public int poolSize = 10; // źâ�� ���� �� �ִ� �Ѿ��� ����(�̸� ����� �� �Ѿ� ���ӿ�����Ʈ ����)
    GameObject[] bulletObjectPool; // źâ

    // Start is called before the first frame update
    void Start()
    {
        // źâ�� �Ѿ��� ��´�.
        bulletObjectPool = new GameObject[poolSize]; // 10ũ���� źâ�� ����

        for (int i = 0; i < poolSize; i++)
        {
            GameObject go = Instantiate(bulletFactory);
            bulletObjectPool[i] = go;

            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1)) 
        {
            for(int i = 0;i < poolSize;i++)
            {
                GameObject go = bulletObjectPool[i];
                if(go.activeSelf == false)
                {
                    go.SetActive (true);
                    go.transform.position = transform.position;

                    break;
                }
            }
        }
    }
}
