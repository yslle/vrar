using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        // �ٴڿ� ������ �� �����
        if (other.gameObject.tag == "Object")
        {
            Destroy(gameObject);
        }

        // ����, ��ź �浹 ����
        if (other.gameObject.tag == "Bomb")
        {
            this.director.GetComponent<GameDirector>().GetBomb();
            // �浹 ���� �� ��� ���������
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Apple")
        {
            this.director.GetComponent<GameDirector>().GetApple();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Banana")
        {
            this.director.GetComponent<GameDirector>().GetBanana();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Grape")
        {
            this.director.GetComponent<GameDirector>().GetGrape();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Orange")
        {
            this.director.GetComponent<GameDirector>().GetOrange();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Watermelon")
        {
            this.director.GetComponent<GameDirector>().GetWatermelon();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
