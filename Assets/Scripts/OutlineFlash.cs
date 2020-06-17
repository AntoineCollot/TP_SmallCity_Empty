using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineFlash : MonoBehaviour {

    public AnimationCurve outlineWidthCurve;
    public float flashEffectDuration= 0.3f;
    public Color flashEffectColor;
    Color originalColor;
    Material material;

	void Start () {
        //Récupère le material de notre objet
        material = GetComponentInChildren<Renderer>().material;
        //Récupère la couleur originale
        originalColor = material.GetColor("_OutlineColor");
        //On pourrait récupérer l'epaisseur de l'outline ainsi
        float outlineWidth = material.GetFloat("_Outline");
    }

    public void Flash()
    {
        
    }
}
