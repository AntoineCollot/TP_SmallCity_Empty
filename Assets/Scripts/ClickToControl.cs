using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
       
	}

    //Contient la voiture séléctionnée actuelement. C'est un variable static, elle existe donc dans la classe et non dans instance d'objet de la classe.
    //Cela signifie que cette variable est partagée entre tous les carControllers.
    public static CarController currentlySelectedCar;

    public void SelectCar(CarController car)
    {
        //Si une voiture était séléctionnée, désactive son carController
        if (currentlySelectedCar != null)
            currentlySelectedCar.enabled = false;

        //Séléctionne la nouvelle voiture
        currentlySelectedCar = car;
        //Active le carController pour rendre la voiture mobile
        currentlySelectedCar.enabled = true;
        //Envoi un message pour appeler une eventuelle fonction Flash qui serait sur un composant de notre gameObject.
        currentlySelectedCar.SendMessage("Flash", SendMessageOptions.DontRequireReceiver);
    }
}
