using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 敵を制御するコンポーネント
public class Boss : MonoBehaviour
{
    public float m_speed; // 移動する速さ
    public int m_hpMax; // HP の最大値
    public int m_exp; // この敵を倒した時に獲得できる経験値
    public int m_damage; // この敵がプレイヤーに与えるダメージ

    private int m_hp; // HP

	private void Awake()
	{
        //最大体力を設定
        m_hp = m_hpMax;
    }



    protected virtual void Update()
	{
        //体力が0以下になったら
        if (m_hp<=0)
		{
            Die();
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
         if(collision.transform.tag=="Bullet")
		{
            Bullet bullet = collision.gameObject.GetComponent<Bullet>();

            Debug.Log("damage");

            // ダメージを受ける
            m_hp--;

            // 弾の情報をリセットする
            bullet.Uninit();

            if (0 < m_hp) return;

            //敵を削除する
            Destroy(gameObject);
            
        }
	}

    // 死亡時に呼ばれる関数
    protected virtual void Die()
    {

    }

    //// 敵が生成された時に呼び出される関数
    //private void Start()
    //{
    //    // HP を初期化する
    //    m_hp = m_hpMax;
    //    //出現位置の初期化
    //    targetpos = transform.position;
    //}

    //// 毎フレーム呼び出される関数
    //private void Update()
    //{
    //    //ボスの移動方法
    //    transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
    //}

}
