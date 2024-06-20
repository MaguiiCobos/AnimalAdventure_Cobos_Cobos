using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour{
    public static bool isGrounded;  //true si está tocando el piso / false si no lo toca
    //al ser static, podemos usar la variable en otro script

    private void OnTriggerEnter2D(Collider2D collision) {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        isGrounded = false;
    }

}
