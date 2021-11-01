using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : Boss
{
    public GameObject bulletPrefab;
    public float m_shotTimer; // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[
    public float m_shotInterval; // �e�̔��ˊԊu�i�b�j


    public Vector2 targetpos;

    void Start()
    {
        targetpos = transform.position;
    }

    protected override void Update()
    {
        // �ړ�
        transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
        base.Update();

        // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[���X�V����
        m_shotTimer += Time.deltaTime;

        // �܂��e�̔��˃^�C�~���O�ł͂Ȃ��ꍇ�́A�����ŏ������I����
        if (m_shotTimer < m_shotInterval) return;

        // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[�����Z�b�g����
        m_shotTimer = 0;

        //�e����
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);

    }

	//    // Update is called once per frame
	//    void Update()
	//    {
	//        transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
	//    }


}
