using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageUI : MonoBehaviour
{

    TextMeshProUGUI contador;
    float cont_segundos;
    float tiempo_transcurrido;

    private void Awake()
    {
        contador = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cont_segundos = 0;
        tiempo_transcurrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_transcurrido += Time.deltaTime;
        if (tiempo_transcurrido > 1.0f)
        {
            cont_segundos++;
            tiempo_transcurrido = 0;
            

        }
    }
}
