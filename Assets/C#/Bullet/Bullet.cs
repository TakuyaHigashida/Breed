using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour	//�G�̒e�֌W
{
	int damage = 100;	//�_���[�W�l
	float speed;        //�X�s�[�h
	Vector2 dir;        //����

	//���˃t���O
	public bool isFormEnemy;

	// ��������
	public void Init(Vector3 position, Vector2 dir, float speed, Color color, float scale)
	{
		this.transform.position = position;
		this.dir = dir;
		this.speed = speed;
		GetComponent<SpriteRenderer>().color = color;
		transform.localScale *= scale;
	}

	// �I������
	public void Uninit()
	{
		// ���g�p��Ԃɖ߂�
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

	// �_���[�W�l�擾�֐�
	public int GetDamage()
	{
		return damage;
	}
}