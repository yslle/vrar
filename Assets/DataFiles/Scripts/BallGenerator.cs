using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public float shootForce = 3000f;
    public float yOffset = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 playerPosition = GameObject.Find("Player").transform.position;

            GameObject ball = Instantiate(ballPrefab, playerPosition + Vector3.up * yOffset, Quaternion.identity);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            ball.GetComponent<BallController>().Shoot(worldDir.normalized * 3000);

        }
    }
  
}
