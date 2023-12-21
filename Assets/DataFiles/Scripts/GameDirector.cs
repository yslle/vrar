using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    // ���� UI
    GameObject pointText;
    int point = 0;

    // �����
    public AudioClip fruitSE;
    public AudioClip bombSE;
    AudioSource aud;

    public void GetApple()
    {
        this.point += 20;
        this.aud.PlayOneShot(this.fruitSE);
    }
    public void GetBanana()
    {
        this.point += 15;
        this.aud.PlayOneShot(this.fruitSE);
    }
    public void GetGrape()
    {
        this.point += 10;
        this.aud.PlayOneShot(this.fruitSE);
    }
    public void GetOrange()
    {
        this.point += 5;
        this.aud.PlayOneShot(this.fruitSE);
    }
    public void GetWatermelon()
    {
        this.point += 3;
        this.aud.PlayOneShot(this.fruitSE);
    }
    public void GetBomb()
    {
        this.point -= 5;
        this.aud.PlayOneShot(this.bombSE);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���� Ŭ����
        if (this.point >= 100)
        {
            SceneManager.LoadScene("ClearScene");
        }

        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString("F1") + " point";
    }

}
