﻿
// 2015/10/05 05:54:55 PM


using UnityEngine;
using System.Collections;
using matnesis.TeaTime; // Add the namespace!


public class BasicTeaTimeExample : MonoBehaviour
{
	public Transform cube;
	public Renderer cubeRen;

	// Declare your queue
	TeaTime queue;


	void Start()
	{
		// Instantiate
		queue = new TeaTime(this);
		// or you can use this shortcut: 'queue = this.tt();' (a special MonoBehaviour extension)
	}


	void Update()
	{

	}


	public void RandomColor()
	{
		Color randomColor = new Color(Random.value, Random.value, Random.value, Random.value);


		// Adds a one second callback loop
		// that lerps to a random color.
		queue.Loop(1f, (ttHandler t) =>
		{
			cubeRen.material.color = Color.Lerp(cubeRen.material.color, randomColor, t.deltaTime);
			// t.deltaTime is a custom delta that represents the loop duration
		});
	}
}
