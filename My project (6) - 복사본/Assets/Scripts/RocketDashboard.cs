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
        // Rocket ��ü�� �� ���� ã��
        rocket = FindObjectOfType<Rocket>();
        if (rocket == null)
        {
            Debug.LogError("Rocket ��ü�� ã�� �� �����ϴ�.");
        }

        // �ְ� ���� �ε� �� �ؽ�Ʈ ������Ʈ
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }

    void Update()
    {
        if (rocket != null)
        {
            // Ŭ���� ��� ���� score�� ������Ʈ
            score = rocket.Pscore;
            currentScoreTxt.text = $"{score} M";

            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        // �ְ� ���� ����
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);  // �ְ� ���� ����
            UpdateHighScoreText();
        }
    }

    private void UpdateHighScoreText()
    {
        highScoreTxt.text = $"best: {highScore} M";
    }
   }
