using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public TMP_Text resultText,cpuHandText;
    private string[] hands = { "�O�[", "�`���L", "�p�[" };

    public void PlayerChoice(int playerHand)
    {
        int cpuHand = Random.Range(0, 3);
        cpuHandText.text = "CPU: " + hands[cpuHand];

        string result = DetermineWinner(playerHand, cpuHand);
        resultText.text = result;
    }

    private string DetermineWinner(int playerHand, int cpuHand)
    {
        if (playerHand == cpuHand)
            return "��������";
        else if ((playerHand == 0 && cpuHand == 1) || (playerHand == 1 && cpuHand == 2) || (playerHand == 2 && cpuHand == 0))
            return "���Ȃ��̏���";
        else
            return "���Ȃ��̕���...";
    }
}
