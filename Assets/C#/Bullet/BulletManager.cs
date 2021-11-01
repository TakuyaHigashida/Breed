using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    // �ePrefab
    public Bullet bulletPrefab;
    // �ő�e��
    const int maxCount = 100;
    // �S�e�f�[�^
    List<Bullet> dataList = new List<Bullet>();

    void Start()
    {
        // �ő�e�����𐶐�����
        for (int i = 0; i < maxCount; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            // ���g�p��Ԃɂ���
            bullet.gameObject.SetActive(false);
            // �z��Ɋi�[����
            dataList.Insert(0, bullet);
        }
    }

    // ���g�p�̒e�f�[�^�擾
    public Bullet GetListData()
    {
        foreach (Bullet data in dataList)
        {
            // ���g�p�̒e��������
            if (!data.gameObject.activeSelf)
            {
                // �g�p��Ԃɂ���
                data.gameObject.SetActive(true);
                return data;
            }
        }
        return null;
    }
}
