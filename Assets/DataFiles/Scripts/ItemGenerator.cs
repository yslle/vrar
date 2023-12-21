using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bananaPrefab;
    public GameObject grapePrefab;
    public GameObject orangePrefab;
    public GameObject watermelonPrefab;
    public GameObject bombPrefab;
    float span = 0.8f;
    float delta = 0;
    int ratio = 2;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            
            GameObject item;

            int itemDice = Random.Range(1, 11); // 점수
            if (itemDice <= this.ratio) // 20% 확률로 폭탄 생성
            {
                item = Instantiate(bombPrefab);
            }
            else
            {
                int fruitDice = Random.Range(1, 11);
                if (fruitDice <= 2)
                {
                    item = Instantiate(applePrefab);
                }
                else if (fruitDice <= 4)
                {
                    item = Instantiate(bananaPrefab);
                }
                else if (fruitDice <= 6)
                {
                    item = Instantiate(grapePrefab);
                }
                else if (fruitDice <= 8)
                {
                    item = Instantiate(orangePrefab);
                }
                else
                {
                    item = Instantiate(watermelonPrefab);
                }
            }

            // 아이템이 떨어지는 위치를 범위 내 랜덤으로
            int x = Random.Range(-12, 23);
            int z = Random.Range(2, 38);
            item.transform.position = new Vector3(x, 12, z);
        }
    }
}
