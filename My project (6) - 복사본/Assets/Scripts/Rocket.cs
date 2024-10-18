using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class Rocket : MonoBehaviour
{


    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    private readonly float maxFuel = 100f;

    private readonly float SPEED = 1000f;
    private readonly float FUELPERSHOOT = 100f;

    public int Pscore = 0;  
    private int highScore = 0; 

    void Update()
    {
        fuel += 0.1f;
    }

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        if (fuel >= FUELPERSHOOT)
        {
            _rb2d.AddForce(Vector2.up * SPEED);
            fuel -= FUELPERSHOOT;
            fuel = Mathf.Max(fuel, 0);
            Debug.Log($"발사! 남은 연료: {fuel}");
            Pscore += 10;  // 발사 시마다 점수 10 증가
        }

        else
        {
            Debug.Log("연료가 부족합니다.");
        }
    }



    public float GetFuelAmount()
    {
        return fuel / maxFuel;  // 연료 비율 반환
    }
}
