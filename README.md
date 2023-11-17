<!-------------------------------------------------------------------  
 - MARKDOWN - Cheatsheets:  
    Getting started:
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/quickstart-for-writing-on-github
    Basic github formatting syntax:  
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
 ------------------------------------------------------------------->
# 1. ProbeTest  
## **Angabe**:  
![1](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/c14e7da6-7001-4776-bc1c-1b96da7be4f9)  

-------------------------------
<details>
  <summary>[klick] für LÖSUNG: </summary> 

## Vollständige Antworten:

### Nummer 1:

```c#  
//  declare variables:
double x, y, z;
/* CHECK VARIABLES: */
//  test the three inputs against each other, if all three 
//    are different from another, the IF branch is executed:  
if ((x != z) && (x != y) && (y != z)) {
//  output the "TOLL" message
Console.Write("\n 3 verschiedene Werte!"); }
//  if two of the input numbers are identical, the ELSE branch is executed:
 else
  Console.Write("\n mind. 2 gleiche Werte!");
```

### Nummer 2:

```c#
      double a, b, c, swap;       
      /* CHECK VRIABLES: */
      if (a < b) {     //  test a - b , if a is smaller -> swap 
        swap = a;
        a = b;
        b = swap; }
      if (a < c) {     //  test a - c , if a is smaller -> swap
        swap = a;
        a = c;
        c = swap; }    //  a now guaranteed to be the biggest number
      if (b < c) {     //  test b - c , if b is smaller -> swap
        swap = b;
        b = c;
        c = swap; }    //  c now guaranteed to be the smallest value
      /* OUTPUT: */
      Console.Write($"\n größter Wert: {a} " +
                    $"\n mittlerer Wert: {b}" +             
                    $"\n kleinster Wert: {c}");
``` 

### Nummer 3:

```c#
      int days, month;

      switch (month)                       
      {
        case 1:    //  Jänner
        case 3:    //  März
        case 5:    //  Mai
        case 7:    //  Juli
        case 8:    //  August
        case 10:   //  Oktober
        case 12:   //  Dezember
          days = 31;
          break;
        case 4:    //  April  
        case 6:    //  Juni
        case 9:    //  September
        case 11:   //  November
          days = 30;
          break;
        case 2:    //  Februar
          days = 28;
          break;
        default:   // invalid input
          days = -1;
          break;
      }
      if (days == -1)
      {
        Console.Write("\n ungültige Eingabe! ");
      }
      else
        Console.WriteLine($"\n Der {month}. Monat hat {days}Tage. ");
    }
```

### Nummer 4:

```c#
   a = (b == 0) ? 2 * c : (c != 0) ? a * b + 2 * c : a * b;
```

### Nummer 5:

```c#
      int i, j;
      /* LOOP A: */
      i = 1; j = 1;   ///  start values
      do
      {
        i = i + j;
        j++;
        Console.Write($"\n i={i}  &  j={j} ");
      } while (i < 200);
      Console.Write("\n A terminierte");
      /* LOOP B: */
      i = 1; j = 20;   ///  start values
      while (i + j < 100)
      {
        i = i + 2;
        j--;
        Console.Write($"\n i:{i}  &  j:{j}  --> i+j:{i+j}");
      }
      Console.Write("\n B terminierte");
```

### Nummer 6:

```c#
      int n, i = 1;
      /* CALCULATION: */
      while (n / 10 != 0)
      {
        i++;
        n = n / 10;
      }
      /* OUTPUT: */
      Console.Write($"\n Die Zahl hatte: {i}Stellen. ");    
```

## handwritten:
<details>
  <summary>[klick] für LÖSUNGSVORSCHLAG: </summary>  

    Das Einlesen und Ausgeben mit "Console.Write ... " von Variablen,
     kann beim Test ausgesparrt werden!  

### *Nummer 1 & 2*:  
<details>  

![2](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/4b53a284-61d5-432c-98d4-2f34d6a6094d)  
</details>

### *Nummer 3*:  
<details>  

![3](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/b28741a0-0ed0-4a5d-9f41-914588b7b5bf)  
</details>

### *Nummer 5 & 6*: 
<details>  

![4](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/4fc4c084-ee78-450d-a00b-2a4579198289)  
</details>
</details>

---




<!--


## visual studio:  
<details>
  <summary>[klick] für Nummer 1: </summary>  
  

<details>
<summary> Unnötig vollständiges (lauffähiges) Programm: </summary>

![1](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/66384dc8-2efc-4f6a-a6bd-7993f23e3395)
</details>
</details>

<details>
  <summary>[klick] für Nummer 2: </summary>  
  
  ## Vollständige Antwort:

  ```c#  
    hier wird der c# code eingefügt
  ```  
</details>  

<details>
<summary> Unnötig vollständiges (lauffähiges) Programm: </summary>

![2](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/1761ef96-5081-47fa-bf8a-9250c60af78c)
</details>
</details>



![3](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/77c40307-0f8a-484c-899a-747a23f52ea7)



### Nummer 4 ... FINALE LÖSUNG:
```c#
a = (b == 0) ? 2 * c : (c != 0) ? a * b + 2 * c : a * b;
```

![4](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/ef586dae-cf76-4d76-9f80-7d0a6dc368d6)




![5](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/048782d8-c00e-455b-8248-7de9a9884beb)




![6](https://github.com/IxI-Enki/Probetest-pose-001/assets/138018029/368c7bb6-fbc5-434d-9b65-a3876c4bb3d4)




</details>
-->
