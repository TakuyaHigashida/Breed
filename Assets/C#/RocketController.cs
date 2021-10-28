using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

	public GameObject bulletPrefab;
	public float m_shotTimer; // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[
	public float m_shotInterval; // �e�̔��ˊԊu�i�b�j

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
	//�G���A�w�肵�Ĉړ�����
	Mathf.Clamp(transform.position.x + moveX, -8.5f, 2.0f),
	Mathf.Clamp(transform.position.y + moveY, -4.5f, 4.5f)
	);


		// �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[���X�V����
		m_shotTimer += Time.deltaTime;

		// �܂��e�̔��˃^�C�~���O�ł͂Ȃ��ꍇ�́A�����ŏ������I����
		if (m_shotTimer < m_shotInterval) return;

		// �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[�����Z�b�g����
		m_shotTimer = 0;

		//�e����
		Instantiate(bulletPrefab, transform.position, Quaternion.identity);

	}
}

