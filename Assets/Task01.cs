using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = { 10, 4, 5, 1, 7 };

        Debug.Log("順番に表示");
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        Debug.Log("逆順に表示");
        for(int j = 1; j <= array.Length; j++)
        {
            Debug.Log(array[array.Length - j]);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
