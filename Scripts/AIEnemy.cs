using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{

	public float speed;
	private float next = 0.0f;
	private float timeRate;

	public Transform vTriTren;
	public Transform vTriDuoi;
	public LayerMask WhatIsTuong;
	public LayerMask WhatIsDich;

	void Update()
	{
		transform.Translate(Vector2.up * speed * Time.deltaTime);
		if (Time.time > next)
		{
			timeRate = Random.Range(0.5f, 6.5f);
			next = Time.time + timeRate;
			float rd = Random.Range(0f, 10f);
			if (rd <= 2.5f)
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
			}
			else if (rd <= 5)
			{
				transform.eulerAngles = new Vector3(0, 0, 90);
			}
			else if (rd <= 7.5f)
			{
				transform.eulerAngles = new Vector3(0, 0, 180);
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 270);
			}
		}
		if ((Physics2D.OverlapArea(vTriTren.position, vTriDuoi.position, WhatIsTuong)) || (Physics2D.OverlapArea(vTriTren.position, vTriDuoi.position, WhatIsDich)))
		{
			float a = Random.Range(0f, 15f);
			if (a <= 5f)
			{
				transform.Rotate(new Vector3(0, 0, 90));
			}
			else if (a <= 10f)
			{
				transform.Rotate(new Vector3(0, 0, -90));
			}
			else
				transform.Rotate(new Vector3(0, 0, 180));
		}
	}



}

