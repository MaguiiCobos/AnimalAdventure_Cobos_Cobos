using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour{

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.CompareTag("Frog")){    //al tocar los pinches muere
            Destroy(collision.gameObject);
        } else if (collision.transform.CompareTag("Duck")){    //al tocar los pinches muere
            Debug.Log("Frog Demaged");
            Destroy(collision.gameObject);
        }
    }
}
