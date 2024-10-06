using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandlerUI : MonoBehaviour
{
    private int contadorSegundos;
    private TextMeshProUGUI textoTiempo;

    private void Awake()
    {
        textoTiempo = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 0;
        StartCoroutine("CorrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PararCorrutina()
    {
        StopCoroutine("CorrutinaTiempo");
    }

    IEnumerator CorrutinaTiempo()
    {
        while (true)
        {
            textoTiempo.text = contadorSegundos++.ToString();
            yield return new WaitForSeconds(1.0f);
        }
    }
}
