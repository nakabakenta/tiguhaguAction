using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_pic_Generate : MonoBehaviour
{
    //�e�X�e�[�W���p�[�t�F�N�g�ł��邩�𔻒肷��ϐ����Ăяo�����߂̐錾
    //public GameManager gameManager;
    public PlayerController playerController;
    public PlayerCollision playerCollision;

    //���_���̃v���n�u�I�u�W�F�N�g�����邽�߂̕ϐ�
    public GameObject Perfect;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    //�Q�[�~���O�_�ߌ��t�̃v���n�u�I�u�W�F�N�g�����邽�߂̕ϐ�
    public GameObject Congratulations;
    public GameObject Excellent;
    public GameObject Great;
    public GameObject Good;

    //�I�u�W�F�N�g�̏ꏊ�����p
    public Transform OBJ_T;

    //�ԉ΂�����ϐ�
    public GameObject Hanabi_Yellow;
    public GameObject Hanabi_Green;
    public GameObject Hanabi_Blue;
    public GameObject Hanabi_Red;

    //�ԉ΂̊Ԋu
    int interval = -25;
    int random_collar = 0;

    //�e���w��
    public Transform Parent;

    //�Ăяo�����X�R�A���i�[����ϐ�
    private int MyScore;

    //�e�X�e�[�W��MAXScore�ݒ�
    private int Stage1_MAX = 11500;
    private int Stage2_MAX = 10000;
    private int Stage3_MAX = 10000;

    //��񂾂����������邽�߂̕ϐ�
    private bool once_clear;

    // Start is called before the first frame update
    void Start()
    {
        once_clear = true;
        Stage1_MAX = playerCollision.stage1MAXscore;
        Stage2_MAX = playerCollision.stage2MAXscore;
        Stage3_MAX = playerCollision.stage3MAXscore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClearDisplay()//�Q�[�����N���A������Ăяo��
    {
        //�Q�[���N���A������
        if (playerController.isClear == true && once_clear == true)
        {
            //�X�e�[�W�P
            //�}�C�X�R�A�ɃX�R�A���i�[
            if (GameManager.stage_num == 1)//�X�e�[�W�P��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE1SCORE", -1);

                if (GameManager.stage1_P)//�X�e�[�W�P���p�[�t�F�N�g
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//���_��
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX && MyScore >= Stage1_MAX - 3000)//��
                {
                    Instantiate(Gold, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar){
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX - 3000 && MyScore >= Stage1_MAX - 8000)//��
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage1_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
            //�X�e�[�W�Q
            //�}�C�X�R�A�ɃX�R�A���i�[
            else if (GameManager.stage_num == 2)//�X�e�[�W�Q��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE2SCORE", -1);

                if (GameManager.stage2_P)//�X�e�[�W�Q���p�[�t�F�N�g
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//���_��
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX && MyScore >= Stage2_MAX - 3000)//��
                {
                    Instantiate(Gold, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX - 3000 && MyScore >= Stage2_MAX - 8000)//��
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage2_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
            //�X�e�[�W�R
            //�}�C�X�R�A�ɃX�R�A���i�[
            else if (GameManager.stage_num == 3)//�X�e�[�W�R��������
            {
                MyScore = PlayerPrefs.GetInt("STAGE3SCORE", -1);

                if (GameManager.stage3_P)//�X�e�[�W�R���p�[�t�F�N�g
                {
                    Instantiate(Perfect, OBJ_T.transform.position, Quaternion.identity, Parent);//���_��
                    Instantiate(Congratulations, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 10 5
                    for (int i = 0; i < 10; i++, interval += 5)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX && MyScore >= Stage3_MAX - 3000)//��
                {
                    Instantiate(Gold,OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Excellent, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 6 8
                    for (int i = 0; i < 6; i++, interval += 8)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX - 3000 && MyScore >= Stage3_MAX - 8000)//��
                {
                    Instantiate(Silver, OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Great, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 4 14
                    for (int i = 0; i < 4; i++, interval += 14)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
                else if (MyScore <= Stage3_MAX - 8000 && MyScore >= 0)//��
                {
                    Instantiate(Bronze,OBJ_T.transform.position, Quaternion.identity, Parent);
                    Instantiate(Good, new Vector3(OBJ_T.transform.position.x, OBJ_T.transform.position.y + 100.0f, OBJ_T.transform.position.z), Quaternion.identity, Parent);//�Q�[�~���O�_�ߌ��t

                    //�ԉ� 3 20
                    for (int i = 0; i < 3; i++, interval += 20)
                    {
                        random_collar = Random.Range(1, 5);//1�`4�Ń����_��
                        switch (random_collar)
                        {
                            case 1:
                                Instantiate(Hanabi_Yellow, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Hanabi_Blue, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Hanabi_Red, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Hanabi_Green, new Vector3(playerController.transform.position.x + interval, playerController.transform.position.y, playerController.transform.position.z + 30f), Quaternion.identity);
                                break;
                        }
                    }
                }
            }

            //��񂾂��Ăяo���ϐ���false�ɂ���
            once_clear = false;
        }

    }
}
