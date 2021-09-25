using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBG : MonoBehaviour
{
   [SerializeField] Sprite[] bgs;
   SpriteRenderer renderer;

   private void Awake() {
       renderer=GetComponent<SpriteRenderer>();
   }
    void Start()
    {
        int randomNum=Random.Range(0,4);
        renderer.sprite=bgs[randomNum];
    }
}
