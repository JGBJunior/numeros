using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numeros : MonoBehaviour {

	public int numeroUno;
	public int numeroDos;
	public int numeroTres;
	public float numeroCuatro;
	public float numeroCinco;

	// Use this for initialization
	void Start () {
		Debug.Log ("El resultado de multiplicar " + numeroUno + " por " + numeroDos + ", dividido por " + numeroTres + ", es igual a " + (numeroUno * numeroDos) / numeroTres );
		Debug.Log ("El resultado de sumar " + numeroUno + ",mas" + numeroTres + ",mas" + numeroCuatro + ", es igual a" + numeroUno + numeroTres + numeroDos);
		Debug.Log ("El resultado de restar " + numeroUno + ",menos" + numeroDos + ",menos" + numeroCinco + ", es igual a" + (numeroUno - numeroDos - numeroCinco));
		Debug.Log ("El resultado de multiplicar " + numeroUno + ",mas" + numeroDos + ",por" + numeroCinco + ", es igual a" + (numeroUno + numeroDos) * numeroCinco);
		Debug.Log ("El resultado de calcular " + numeroUno + ",mas" + numeroDos + ",dividido por " + numeroCinco + ",mas" + numeroCuatro + ", es igual a" + (numeroUno - numeroTres) / (numeroCinco + numeroCuatro));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
