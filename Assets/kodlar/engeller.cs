using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class engeller : MonoBehaviour
{

    private static int skor;
    public TextMeshProUGUI skorYazisi, bitisYazisi;
    private void Start()
    {
        skor = 0;


    }

    private void Update()
    {
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "OYUN BÝTTÝ! \n Skor : " + skor.ToString();
    }

    void OnCollisionEnter2D (Collision2D temas)
    {
        float xPozisyonu = Random.Range(-5f, 5f);
        float yPozisyonu = Random.Range(6.5f, 15f);

        if (temas.gameObject.tag == "kontrolCubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += 1;
        }
        else if(temas.gameObject.tag == "karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);

            hak.kalanHak--;
        }
    }

    
    
}
