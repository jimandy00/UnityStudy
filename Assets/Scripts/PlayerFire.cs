using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // 총알 공장
    public int poolSize = 10; // 탄창에 담을 수 있는 총알의 개수(미리 만들어 둘 총알 게임오브젝트 개수)
    GameObject[] bulletObjectPool; // 탄창

    // Start is called before the first frame update
    void Start()
    {
        // 탄창에 총알을 담는다.
        bulletObjectPool = new GameObject[poolSize]; // 10크기의 탄창을 만듦

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
