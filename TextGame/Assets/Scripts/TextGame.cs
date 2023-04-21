using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Program zgaduje liczbê, wymyœlon¹ z konkretnego przedzia³u liczbowego.
    // Przedzia³ od 1 do 1000, program pyta czy wymyœlona liczba jest wiêksza, mniejsza lub równa z liczb¹ ... 
    // U¿ytkownik odpowiada czy jest mniejsza, wiêksza lub równa.

    // Algorytm - wyszukiwanie binarnie - losowo
    // 1+1000/2 = 500
    // liczba wybrana przez gracza = 328
    // 1 (min) 500 (max)
    // 1+500/2 = 250
    // 250 (min) - 500 (max)

    //typ, nazwa, podaæ pocz¹tkow¹ wartoœæ

    int min = 1;
    int max = 1000;
    int shoot = 500;


    void Start()
    {
       

        Debug.Log("Witam w grze - Wymyœl liczbê od 1 do 1000");
        Debug.Log("Czy Twoja liczba jest wiêksza, mniejsza b¹dŸ równa 500?");
        //print string
        //Naciœnij górn¹ strza³kê aby odpowiedzieæ, ¿e wiêksza
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy Twoja liczba jest mniejsza, wiêksza b¹dŸ równa " + shoot + " ?");
        };

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy Twoja liczba jest mniejsza, wiêksza b¹dŸ równa " + shoot + " ?");
        };

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgad³ Twoj¹ liczbê");
        };
    }
}
