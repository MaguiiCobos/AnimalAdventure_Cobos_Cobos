using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour{
    public void AllFruitsCollected(){
        if (transform.childCount==1){   //si agarran todas las frutas ganan (se pone 1 porq al "eliminar" la fruta q agarra nunca va a saber si es cero)
            Debug.Log("No quedan frutas");
        }
    }
}
