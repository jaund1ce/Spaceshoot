using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    [SerializeField] private Image fuelBarImage;  // 연료 바 이미지
    [SerializeField] private Rocket rocket;  // 로켓 스크립트 참조

    void Update()
    {
        // 연료 비율 계산 (0~1)
        float fuelAmount = rocket.GetFuelAmount();  // Rocket 스크립트에서 현재 연료 값을 가져옴
        fuelBarImage.fillAmount = fuelAmount;  // 연료 바 업데이트
    }
}
