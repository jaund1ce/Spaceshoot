using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    [SerializeField] private Image fuelBarImage;  // ���� �� �̹���
    [SerializeField] private Rocket rocket;  // ���� ��ũ��Ʈ ����

    void Update()
    {
        // ���� ���� ��� (0~1)
        float fuelAmount = rocket.GetFuelAmount();  // Rocket ��ũ��Ʈ���� ���� ���� ���� ������
        fuelBarImage.fillAmount = fuelAmount;  // ���� �� ������Ʈ
    }
}
