using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public float carTurningSpeed;

    Vector2 inputs;
    new Rigidbody rigidbody;

	// Use this for initialization
	void Awake () {
        //Récupère le rigibody
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ReadInputs();

        RotateCar();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        //On applique l'accèlération dans fixed update car les forces physiques continues doivent appliquées dans fixedUpdate pour se comporter correctement.
        ApplyAcceleration();
    }

    void ReadInputs()
    {

    }

    void RotateCar()
    {

    }

    void ApplyAcceleration()
    {

    }
}
