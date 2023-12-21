using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    Vector3 moveVec;
    Animator anim;
    GameObject director;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;

        anim.SetBool("isWalk", moveVec != Vector3.zero);

        transform.LookAt(transform.position + moveVec);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            this.director.GetComponent<GameDirector>().GetBomb();
            Destroy(other.gameObject);
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Fruit"))
        {
            Destroy(other.gameObject);
        }
    }
}