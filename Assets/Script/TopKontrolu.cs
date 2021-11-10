using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopKontrolu : MonoBehaviour
{
    public float ziplamaKuvveti = 15f;
    public string mevcutRenk;
    public Color turkuaz;
    public Color sari;
    public Color kirmizi;
    public Color mor;

    private Color topunRengi;
    public Text skorYazisi;
    public static int skor = 0; //static=> sahneler arası geçişlerda korunma
    void Start()
    {
        RastgeleRenkBelirle();
        //topunRengi = GetComponent<SpriteRenderer>().color;
        skorYazisi.text = skor.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up*ziplamaKuvveti;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "SkorArttir")
        {
            skor += 50;
            skorYazisi.text = skor.ToString();
            Destroy(collision.gameObject);
        }
        if(collision.tag == "RenkTekeri")
        {
            RastgeleRenkBelirle();
            Destroy(collision.gameObject); //coolsion olan objeyi yok et
            return; //ilgili tag bulduktan sonra trigger çık
        }
        
        if(collision.tag != mevcutRenk && collision.tag != "SkoruArttir")
        {
          skor = 0;
          skorYazisi.text = skor.ToString();  

          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //SceneManager.LoadScene() da yazabilirdik.  
          Debug.Log("oldu");
          //  Destroy(gameObject);
        }
    
        
    }

    void RastgeleRenkBelirle()
    {
        int rastgeleSayi = Random.Range(0,4); //Turkuaz,Sarı,Kırmızı,Mor
        switch (rastgeleSayi)
        {
            case 0 : mevcutRenk = "Turkuaz";
                topunRengi = turkuaz;//Color.cyan;  //new Color(34,231,218,255);
                break;
            case 1 : mevcutRenk = "Sarı";
                topunRengi = sari;//Color.yellow;//new Color(255,255,0,255);
                break;
            case 2 : mevcutRenk = "Kırmızı";
                topunRengi = kirmizi;//Color.red; //new Color(255,0,196,255);
                break;
            case 3 : mevcutRenk = "Mor";
                topunRengi = mor;//Color.magenta;//new Color(151,0,255,255);
                break;

        }
        GetComponent<SpriteRenderer>().color = topunRengi;
    }
}
