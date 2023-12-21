using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    public float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        zOffset = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position; 

        transform.position = new Vector3( playerPos.x, transform.position.y, playerPos.z - 13);
    }
}
