using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public Renderer rend;
    public BoxCollider2D colider;
    public GameObject endPanel;
    public GameObject winPanel;
    public GameObject cam;
    public GameObject star;
    [SerializeField]
    Transform starPosition;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: "+score;
    }

    void Update()
    {
        if (GetComponent<Transform>().position.y > cam.GetComponent<Transform>().position.y + 8.8)
        {
            GetComponent<PlayerMovementt>().enabled = false;
            endPanel.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Star") {

            score +=5;
            scoreText.text = "Score: "+score;
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
           rend = col.gameObject.GetComponent<SpriteRenderer>();
           rend.enabled = false;
            colider = col.gameObject.GetComponent<BoxCollider2D>();
            colider.enabled = false;
            Destroy(col.gameObject, 3f);
        }

        else if (col.gameObject.tag == "Enemy")
        {
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
            GetComponent<PlayerMovementt>().enabled = false;
//            camera = GameObject.Find(Camera);
//            GetComponent<Camera>().GetComponent<CameraMove>().enabled = false;
            endPanel.SetActive(true);
        }
        else if (col.gameObject.tag == "Chest")
        {
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
            GetComponent<PlayerMovementt>().enabled = false;
            winPanel.SetActive(true);
        }
        else if(col.gameObject.tag == "chest1")
        {
            Vector3 ez = starPosition.position;
            for (int i=1; i<=5; i++)
            {
                if (i == 1)
                {
                    ez.x += -2f;
                }
                if (i ==2)
                {
                    ez.x += 1f;
                    ez.y += 2f;
                }
                if (i== 3)
                {
                    ez.x += 1f;
                    ez.y += 1f;
                }
                if (i == 4)
                {
                    ez.x += 1f;
                    ez.y += -1f;
                }
                if (i==5)
                {
                    ez.x += 1f;
                    ez.y += -1f;
                }
                GameObject newStar = Instantiate(star, ez, new Quaternion());
            }
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
            rend = col.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = false;
            colider = col.gameObject.GetComponent<BoxCollider2D>();
            colider.enabled = false;
            Destroy(col.gameObject, 3f);
        }
    }
}
