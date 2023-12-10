using Unity.VisualScripting;
using UnityEngine;

public class HingeJointFinder : MonoBehaviour
{
   // � ����� ���� ��� ������� ��� ���� ������
   // ����� �� ������� SelectScrew ������� �������� ����� ������� �������� � �������� � ��� ����������

    public string connectedBodyName; // Name of the connected body

    //������� ��� ���������� ���� HingeJoint`a ������� ��� �����
    void FindHingeJointByConnectedBodyName(string connectedBodyName)
    {
        GameObject connectedObject = GameObject.Find(connectedBodyName);

        if (connectedObject != null)
        {
            HingeJoint[] hingeJoints = connectedObject.GetComponents<HingeJoint>();

            foreach (HingeJoint hingeJoint in hingeJoints)
            {
                if (hingeJoint.connectedBody.name == connectedBodyName)
                {

                    //���� �������� ������ ���������, ����� ��� ���� ����������
                    //������ ���� hingeJoint ������ � ���� ������ � connected body 
                    //� ����� ��������� ����� ��������� ������ �� ������ �����
                    Destroy(gameObject.GetComponent("HingeJoint"));

                }
            }
        }
        //�� ������ ���, �� ����� ��� ������� ���������� � ����������� ������
        //����� ���� ���� ���� ��� ��� ��������, �� �� ����������� ������ ���, � ����� ������� ���������

    }
}