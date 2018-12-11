﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
	//variables de pantalla de carga
	public Slider slider;
	public GameObject pantallaDeCarga;


    void Start()
    {

    }


    void Update()
    {

    }

	IEnumerator LoadYourAsyncScene ()
	{
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync ("pruebaMovimiento");
		sonido ();
		while (!asyncLoad.isDone) {
			slider.value = asyncLoad.progress;
			yield return null;
		}
	}

  

    //Funcion para salir del juego
    public void Salir()
    {
        Application.Quit();
    }
}
