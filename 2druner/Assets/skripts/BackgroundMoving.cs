using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float BackgroundMoving = 2f; //��������� ��������, ������� �������� ������ ������� ��� �������

    //{SerializeField} - ��������� ������� �����, ����������� �������� �������� ���������� �� ����������, � �� �� ����
    //private - ���������� ����������� ����������
    // float - ��� ���������� � ��������� ������ (� ����� ����� ����������� ���������� �������� 'f', ����� ������� ���������� ���� float)
    //speed - �������� ���������� ��� �������� ������ �������


    //���������� ����� unity, ������� ���������� ������ ���� �� ����� ����
    private void Update()
    {
      transform.position -= new Vector3 (BackgroundMoving* Time.deltaTime, 0, 0); //���������� �������� �� �����
      //� ������ ������� �� �������� �� ������� ������� Vector3, ������� ��������� � ���� 3 ���������� ������� x, y, z
      Debug.Log(transform.position);

    }
}    