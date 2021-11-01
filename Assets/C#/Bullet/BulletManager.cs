using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    // 弾Prefab
    public Bullet bulletPrefab;
    // 最大弾数
    const int maxCount = 100;
    // 全弾データ
    List<Bullet> dataList = new List<Bullet>();

    void Start()
    {
        // 最大弾数分を生成する
        for (int i = 0; i < maxCount; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            // 未使用状態にする
            bullet.gameObject.SetActive(false);
            // 配列に格納する
            dataList.Insert(0, bullet);
        }
    }

    // 未使用の弾データ取得
    public Bullet GetListData()
    {
        foreach (Bullet data in dataList)
        {
            // 未使用の弾だったら
            if (!data.gameObject.activeSelf)
            {
                // 使用状態にする
                data.gameObject.SetActive(true);
                return data;
            }
        }
        return null;
    }
}
