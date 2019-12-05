using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text result;

    public Button calculateButton;
    public Button resetButton;

    float varA;
    float varB;

    public void SetResult()
    {
        result.text = CalculateNumbers();

        input1.gameObject.SetActive(false);
        input2.gameObject.SetActive(false);

        resetButton.gameObject.SetActive(true);
        calculateButton.gameObject.SetActive(false);
    }

    string CalculateNumbers()
    {
        if (string.IsNullOrEmpty(input1.text) || string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("ERROR 1: Number(s) missing.");

            string outputError = "ERROR";
            return outputError;
        }
        else
        {
            varA = Mathf.RoundToInt(float.Parse(input1.text));
            varB = Mathf.RoundToInt(float.Parse(input2.text));

            string outputSuccess = (varA + varB).ToString();
            return outputSuccess;
        }
    }

    public void ResetApp()
    {
        input1.gameObject.SetActive(true);
        input2.gameObject.SetActive(true);

        calculateButton.gameObject.SetActive(true);

        input1.text = "0";
        input2.text = "0";
        result.text = "";

        resetButton.gameObject.SetActive(false);
    }
}
