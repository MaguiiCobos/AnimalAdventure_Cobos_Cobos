using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaCollected : MonoBehaviour{
   private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Duck")){
            GetComponent<SpriteRenderer>().enabled = false;     //desactiva la banana cuando la agarramos
            gameObject.transform.GetChild(0).gameObject.SetActive(true);    //activa la animacion de la banana agarrada
            FindObjectOfType<FruitManager>().AllFruitsCollected();
            Destroy(gameObject, 0.5f);  //elimina la banana
        }
    }
}
