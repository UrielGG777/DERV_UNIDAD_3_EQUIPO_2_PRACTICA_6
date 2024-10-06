using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Destruir_player : MonoBehaviour
{
    Transform camaraMuerte;
    TextMeshProUGUI textoMuerte;
    HandlerUI handlerUI;

    private void Awake()
    {
        camaraMuerte = GameObject.Find("CamaraMuerte").GetComponent<Transform>();
        textoMuerte = GameObject.Find("TextoMuerte").GetComponent<TextMeshProUGUI>();
        handlerUI = GameObject.Find("Canvas").GetComponent<HandlerUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            collision.gameObject.tag = "Untagged";
            collision.rigidbody.isKinematic = true;
            collision.transform.position = camaraMuerte.transform.position;
            collision.transform.rotation = camaraMuerte.transform.rotation;
            textoMuerte.text = "Game Over!";
            handlerUI.PararCorrutina();
        }
    }
   
}
