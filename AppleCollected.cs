using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Frog")){
            GetComponent<SpriteRenderer>().enabled = false;     //desactiva la manzana cuando la agarramos
            gameObject.transform.GetChild(0).gameObject.SetActive(true);    //activa la animacion de la manzana agarrada
            FindObjectOfType<FruitManager>().AllFruitsCollected();
            Destroy(gameObject, 0.5f);  //elimina la manzana
        }
    }
}
