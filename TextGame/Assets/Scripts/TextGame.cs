using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Program zgaduje liczb�, wymy�lon� z konkretnego przedzia�u liczbowego.
    // Przedzia� od 1 do 1000, program pyta czy wymy�lona liczba jest wi�ksza, mniejsza lub r�wna z liczb� ... 
    // U�ytkownik odpowiada czy jest mniejsza, wi�ksza lub r�wna.

    // Algorytm - wyszukiwanie binarnie - losowo
    // 1+1000/2 = 500
    // liczba wybrana przez gracza = 328
    // 1 (min) 500 (max)
    // 1+500/2 = 250
    // 250 (min) - 500 (max)

    //typ, nazwa, poda� pocz�tkow� warto��

    int min = 1;
    int max = 1000;
    int shoot = 500;


    void Start()
    {
       

        Debug.Log("Witam w grze - Wymy�l liczb� od 1 do 1000");
        Debug.Log("Czy Twoja liczba jest wi�ksza, mniejsza b�d� r�wna 500?");
        //print string
        //Naci�nij g�rn� strza�k� aby odpowiedzie�, �e wi�ksza
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy Twoja liczba jest mniejsza, wi�ksza b�d� r�wna " + shoot + " ?");
        };

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy Twoja liczba jest mniejsza, wi�ksza b�d� r�wna " + shoot + " ?");
        };

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgad� Twoj� liczb�");
        };
    }
}
