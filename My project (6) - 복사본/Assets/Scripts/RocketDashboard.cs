using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RocketDashboard : MonoBehaviour
{
    private int score = 0;
    private int highScore = 0;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    private Rocket rocket;

    void Start()
    {
        // Rocket 객체를 한 번만 찾음
        rocket = FindObjectOfType<Rocket>();
        if (rocket == null)
        {
            Debug.LogError("Rocket 객체를 찾을 수 없습니다.");
        }

        // 최고 점수 로드 및 텍스트 업데이트
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }

    void Update()
    {
        if (rocket != null)
        {
            // 클래스 멤버 변수 score를 업데이트
            score = rocket.Pscore;
            currentScoreTxt.text = $"{score} M";

            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        // 최고 점수 갱신
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);  // 최고 점수 저장
            UpdateHighScoreText();
        }
    }

    private void UpdateHighScoreText()
    {
        highScoreTxt.text = $"best: {highScore} M";
    }
   }
