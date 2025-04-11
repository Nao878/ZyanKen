using UnityEngine;
using TMPro;
using System.Collections;

public class JankenGame : MonoBehaviour
{
    public TMP_Text resultText;
    public TMP_Text cpuHandText;
    public TMP_Text playerHandText;

    private string[] hands = { "グー", "チョキ", "パー" };

    public void PlayerChoice(int playerHand)
    {
        playerHandText.text = "あなた: " + hands[playerHand];
        StartCoroutine(ShowCpuChoice(playerHand));
    }

    private IEnumerator ShowCpuChoice(int playerHand)
    {
        for (int i = 0; i < 10; i++) // CPUの手をランダムに表示
        {
            cpuHandText.text = "CPU: " + hands[Random.Range(0, 3)];
            yield return new WaitForSeconds(0.1f);
        }

        int cpuHand = Random.Range(0, 3);
        cpuHandText.text = "CPU: " + hands[cpuHand];

        string result = DetermineWinner(playerHand, cpuHand);
        resultText.text = result;
    }

    private string DetermineWinner(int playerHand, int cpuHand)
    {
        if (playerHand == cpuHand)
            return "引き分け!";
        else if ((playerHand == 0 && cpuHand == 1) || (playerHand == 1 && cpuHand == 2) || (playerHand == 2 && cpuHand == 0))
            return "あなたの勝ち!";
        else
            return "あなたの負け...";
    }
}
