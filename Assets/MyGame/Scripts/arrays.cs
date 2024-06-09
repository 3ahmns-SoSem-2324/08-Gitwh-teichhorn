using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    private int[] myArray;

    void Start()
    {
        // Arrays initialisieren
        int[] myArray1 = new int[4];
        int[] myArray2 = new int[] { 21, 22, 23, 24 };
        int[] myArray3 = new int[] { 31, 32, 33, 34, 35, 36, 37 };
        string[] myArray4 = new string[10];
        for (int i = 0; i < myArray4.Length; i++)
        {
            myArray4[i] = "array4";
        }

        // Direkter Zugriff auf einzelne Elemente in den Arrays myArray1-myArray4
        // 1) auf erstes Element
        Debug.Log("Erstes Element von myArray1: " + myArray1[0]);
        Debug.Log("Erstes Element von myArray2: " + myArray2[0]);
        Debug.Log("Erstes Element von myArray3: " + myArray3[0]);
        Debug.Log("Erstes Element von myArray4: " + myArray4[0]);

        // 2) auf letztes Element
        Debug.Log("Letztes Element von myArray1: " + myArray1[myArray1.Length - 1]);
        Debug.Log("Letztes Element von myArray2: " + myArray2[myArray2.Length - 1]);
        Debug.Log("Letztes Element von myArray3: " + myArray3[myArray3.Length - 1]);
        Debug.Log("Letztes Element von myArray4: " + myArray4[myArray4.Length - 1]);

        // Zugriff auf einen Array mittels For-Schleife
        // Eine For-Schleife führt eine Operation mehrmals aus.
        // Hier wird immer wieder der Wert der Elemente als string im Array in einem Debug.Log ausgegeben.
        for (int i = 0; i < myArray1.Length; i++)
        {
            Debug.Log("myArray1 Element " + i + ": " + myArray1[i]);
        }

        for (int i = 0; i < myArray2.Length; i++)
        {
            Debug.Log("myArray2 Element " + i + ": " + myArray2[i]);
        }

        for (int i = 0; i < myArray3.Length; i++)
        {
            Debug.Log("myArray3 Element " + i + ": " + myArray3[i]);
        }

        for (int i = 0; i < myArray4.Length; i++)
        {
            Debug.Log("myArray4 Element " + i + ": " + myArray4[i]);
        }

        // 1) Methode zur Ausgabe von Array-Elementen mit zugehörigen Index
        PrintArrayWithIndices(myArray1);
        PrintArrayWithIndices(myArray2);
        PrintArrayWithIndices(myArray3);
        

        // 2) Methode zur Ausgabe eines Arrays als langen String
        PrintArrayAsLongString(myArray1);
        PrintArrayAsLongString(myArray2);
        PrintArrayAsLongString(myArray3);
        

        // Array Zugriff einzelne Elemente:
        // 1. Greifen Sie auf das 4te Elemente in myArray1 zu und ändern sie den Wert auf 3. Geben Sie das Element mittels Debug.Log aus
        myArray1[3] = 3;
        Debug.Log("4. Element von myArray1 nach Änderung: " + myArray1[3]);

        // 2. Greifen Sie auf das 3te Element in myArray2 zu und ändern sie den Wert auf 203. Geben Sie das Element mittels Debug.Log aus
        myArray2[2] = 203;
        Debug.Log("3. Element von myArray2 nach Änderung: " + myArray2[2]);

        // 3. Greifen Sie auf das 6te Element in myArray3 zu und ändern sie den Wert auf 333.
        myArray3[5] = 333;

        // 4. Greifen Sie auf das 3te Element in myArray4 zu und ändern sie den Wert auf "heute". Geben Sie das Element mittels Debug.Log aus
        myArray4[2] = "heute";
        Debug.Log("3. Element von myArray4 nach Änderung: " + myArray4[2]);

        // Neuen Anforderungen hinzufügen

        // array11 mit 1000 Elementen, gefüllt mit zufälligen Zahlen
        int[] array11 = new int[1000];
        System.Random rand = new System.Random();
        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = rand.Next();
        }

        // Minimum und Maximum von array11 finden
        int min = array11[0];
        int max = array11[0];
        for (int i = 1; i < array11.Length; i++)
        {
            if (array11[i] < min)
                min = array11[i];
            if (array11[i] > max)
                max = array11[i];
        }
        Debug.Log("Minimum von array11: " + min);
        Debug.Log("Maximum von array11: " + max);

        // array12 mit 1000 Elementen, gefüllt mit zufälligen Zahlen
        int[] array12 = new int[1000];
        for (int i = 0; i < array12.Length; i++)
        {
            array12[i] = rand.Next();
        }

        // Einen zufälligen Wert suchen und den Index zurückgeben
        int searchValue = rand.Next();
        int foundIndex = Array.IndexOf(array12, searchValue);
        Debug.Log("Gefundener Index von Wert " + searchValue + " in array12: " + foundIndex);
    }

    // Methode zur Ausgabe von Array-Elementen mit zugehörigen Index
    void PrintArrayWithIndices(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element[" + i + "] = " + array[i]);
        }
    }

    // Methode zur Ausgabe eines Arrays als langen String
    void PrintArrayAsLongString(int[] array)
    {
        string[] stringArray = new string[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            stringArray[i] = array[i].ToString();
        }
        string arrayString = string.Join(", ", stringArray);
        Debug.Log(arrayString);
    }
}
