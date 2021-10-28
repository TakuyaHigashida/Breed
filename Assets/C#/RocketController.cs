using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

	public GameObject bulletPrefab;
	public float m_shotTimer; // 弾の発射タイミングを管理するタイマー
	public float m_shotInterval; // 弾の発射間隔（秒）

	public float speed;

	void Update()
	{

	//if ((Input.GetKey(KeyCode.A))||(Input.GetKey(KeyCode.J)))
	//{
	//	transform.Translate(-0.05f, 0, 0);
	//}
	//if ((Input.GetKey(KeyCode.D))||(Input.GetKey(KeyCode.L)))
	//{
	//	transform.Translate(0.05f, 0, 0);
	//}
	//if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.I)))
	//{
	//	transform.Translate(0.0f, 0.05f, 0);
	//}
	//if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.K)))
	//{
	//	transform.Translate(0.0f, -0.05f, 0);
	//}

	float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
	float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.position = new Vector2(
	//エリア指定して移動する
	Mathf.Clamp(transform.position.x + moveX, -8.5f, 2.0f),
	Mathf.Clamp(transform.position.y + moveY, -4.5f, 4.5f)
	);


		// 弾の発射タイミングを管理するタイマーを更新する
		m_shotTimer += Time.deltaTime;

		// まだ弾の発射タイミングではない場合は、ここで処理を終える
		if (m_shotTimer < m_shotInterval) return;

		// 弾の発射タイミングを管理するタイマーをリセットする
		m_shotTimer = 0;

		//弾発射
		Instantiate(bulletPrefab, transform.position, Quaternion.identity);

	}
}

