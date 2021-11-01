using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : Boss
{
    public GameObject bulletPrefab;
    public float m_shotTimer; // 弾の発射タイミングを管理するタイマー
    public float m_shotInterval; // 弾の発射間隔（秒）


    public Vector2 targetpos;

    void Start()
    {
        targetpos = transform.position;
    }

    protected override void Update()
    {
        // 移動
        transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
        base.Update();

        // 弾の発射タイミングを管理するタイマーを更新する
        m_shotTimer += Time.deltaTime;

        // まだ弾の発射タイミングではない場合は、ここで処理を終える
        if (m_shotTimer < m_shotInterval) return;

        // 弾の発射タイミングを管理するタイマーをリセットする
        m_shotTimer = 0;

        //弾発射
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);

    }

	//    // Update is called once per frame
	//    void Update()
	//    {
	//        transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
	//    }


}
