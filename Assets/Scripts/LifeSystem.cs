using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour {

    public int life;
    public int mana;
    public Text lifeTextValue;
    public Text manaTextValue;

    
    void Update(){
        lifeTextValue.text = life.ToString();
        manaTextValue.text = mana.ToString();
    }

    private void OnCollisionEnter2D(Collision2D obj){
        if (obj.gameObject.tag == "SuperMagicObject") {
            life = life + 15;
            Destroy(obj.gameObject);
        }
    }
}
