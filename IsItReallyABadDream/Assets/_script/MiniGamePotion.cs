using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class MiniGamePotion : MonoBehaviour
{
    public Text hasilTxt;
    public float ketentuanHasil;
    // public Sprite rightPotion;
    // public Sprite emptyPotion;
    // public Sprite wrongPotion;

    private string expression;
    private float result;
    // private string[] elements;

    void Start()
    {
        expression = "0";
    }

    void Update()
    {
        
        if( result == ketentuanHasil && AllChecked(expression))
        {
            brankasController.isGotRightPotion = true;
            Debug.Log("Found");
        }
    }

    public void submitAnswer()
    {
        expression = hasilTxt.text;
        result = EvaluateExpression(expression);
    }

    public void AddOperation(string operation){
        hasilTxt.text += " " + operation + " ";
    }

    public void AddNumPotion(string num)
    {
        if(hasilTxt.text == Convert.ToString(num))
        {
            hasilTxt.text = num;
        } else 
        {
            hasilTxt.text = hasilTxt.text + num;
        }
    }

    public void delete(){
        hasilTxt.text = "";
    }

    static float EvaluateExpression(string expression)
    {
        // Split the input string into numbers and operators
        string[] elements = expression.Split(' ');

        // Separate numbers and operators
        List<float> numbers = new List<float>();
        List<char> operators = new List<char>();

        foreach (string element in elements)
        {
            if (float.TryParse(element, out float number))
            {
                numbers.Add(number);
            }
            else if (IsOperator(element))
            {
                operators.Add(element[0]);
            }
            else
            {
                Debug.Log("Invalid input: " + element);
            }
        }

        // Perform calculations based on mathematical rules
        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == '*' || operators[i] == '/')
            {
                float operand1 = numbers[i];
                float operand2 = numbers[i + 1];

                float result = operators[i] == '*' ? operand1 * operand2 : operand1 / operand2;

                // Replace the two operands and the operator with the result
                numbers[i] = result;
                numbers.RemoveAt(i + 1);
                operators.RemoveAt(i);
                i--; // Adjust the loop index after removing an operator
            }
        }

        // Perform addition and subtraction
        float finalResult = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == '+')
            {
                finalResult += numbers[i + 1];
            }
            else if (operators[i] == '-')
            {
                finalResult -= numbers[i + 1];
            }
        }

        return finalResult;
    }

    static bool IsOperator(string value)
    {
        return value.Length == 1 && "+-*/".Contains(value[0]);
    }

    private bool AllChecked(string perhitungan)
    {
        string[] elements = expression.Split(' ');

        // Separate numbers and operators
        List<float> numbers = new List<float>();
        List<char> operators = new List<char>();
        char[] requiredOperators = { '+', '-', '*', '/' };

        foreach (string element in elements)
        {
            if (float.TryParse(element, out float number))
            {
                numbers.Add(number);
            }
            else if (IsOperator(element))
            {
                operators.Add(element[0]);
            }
            else
            {
                Debug.Log("Invalid input: " + element);
            }
        }

        return requiredOperators.All(op => operators.Contains(op));
    }
}
