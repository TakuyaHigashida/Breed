using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour	//敵の弾関係
{
	int damage = 100;	//ダメージ値
	float speed;        //スピード
	Vector2 dir;        //方向

	//発射フラグ
	public bool isFormEnemy;

	// 初期処理
	public void Init(Vector3 position, Vector2 dir, float speed, Color color, float scale)
	{
		this.transform.position = position;
		this.dir = dir;
		this.speed = speed;
		GetComponent<SpriteRenderer>().color = color;
		transform.localScale *= scale;
	}

	// 終了処理
	public void Uninit()
	{
		// 未使用状態に戻す
		Destroy(gameObject);
	}

	void Update()
	{
		transform.Translate(0, 0.1f, 0);

		if (transform.position.y > 5 || transform.position.y < -5 || transform.position.x > 9 || transform.position.x < -9)
		{
			Uninit();
		}
	}

	// ダメージ値取得関数
	public int GetDamage()
	{
		return damage;
	}
}