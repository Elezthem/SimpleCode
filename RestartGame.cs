using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private Button restartButton = default;

    private void Start()
    {
        // ... (��� ������������ ���)

        // ��������� ��������� ������� ��� ������ ��������
        restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnRestartButtonClick()
    {
        // ����� �� ������ ��������� ����� ����������� �������� ����� ���������
        // (���� ����� ����), � ����� ������������� �����.
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
