using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �G�𐧌䂷��R���|�[�l���g
public class Boss : MonoBehaviour
{
    public float m_speed; // �ړ����鑬��
    public int m_hpMax; // HP �̍ő�l
    public int m_exp; // ���̓G��|�������Ɋl���ł���o���l
    public int m_damage; // ���̓G���v���C���[�ɗ^����_���[�W

    private int m_hp; // HP

	private void Awake()
	{
        //�ő�̗͂�ݒ�
        m_hp = m_hpMax;
    }



    protected virtual void Update()
	{
        //�̗͂�0�ȉ��ɂȂ�����
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

            // �_���[�W���󂯂�
            m_hp--;

            // �e�̏������Z�b�g����
            bullet.Uninit();

            if (0 < m_hp) return;

            //�G���폜����
            Destroy(gameObject);
            
        }
	}

    // ���S���ɌĂ΂��֐�
    protected virtual void Die()
    {

    }

    //// �G���������ꂽ���ɌĂяo�����֐�
    //private void Start()
    //{
    //    // HP ������������
    //    m_hp = m_hpMax;
    //    //�o���ʒu�̏�����
    //    targetpos = transform.position;
    //}

    //// ���t���[���Ăяo�����֐�
    //private void Update()
    //{
    //    //�{�X�̈ړ����@
    //    transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
    //}

}
