using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasinoScr : MonoBehaviour
{
    [SerializeField] int money = 1000000;
    [SerializeField] Text MoneyText;
    [SerializeField] Text SlotText1;
    [SerializeField] Text SlotText2;
    [SerializeField] Text SlotText3;
    [SerializeField] GameObject someMoney;
    [SerializeField] GameObject manyMoney;
    [SerializeField] Transform trans;
    [SerializeField] Sprite[] spritemassive;
    [SerializeField] Image image1;
    [SerializeField] Image image2;
    [SerializeField] Image image3;
    [SerializeField] GameObject[] surprises;
    [SerializeField] Transform droppoint;





    int number1;
    int number2;
    int number3;
    bool isDo = true;
    public void rotat()
    {
        if (money > 1 && isDo)
        {
          
            isDo = false;
            money--;
            rotatetete();
        }

    }

    
    
    public void rotatetete()
    {




        
        int i = 0;
        bool u = true;
        //while (u)
        //{
            i++;
            number1 = Random.Range(0, 5);
        //SlotText1.text = "" + number1;
        image1.sprite = spritemassive[number1];



        number2 = Random.Range(0, 4);
        //SlotText2.text = "" + number2;
        image2.sprite = spritemassive[number2];

        if (number2 == 1)
            {
                
                number2 = number1;
                number3 = Random.Range(0, 3);
            //SlotText3.text = "" + number3;
            image3.sprite = spritemassive[number3];
            if (number3 == 1)
                {
                    
                    number3 = number2;
                   
                }
            }
            else
            {
                number2 = Random.Range(0, 5);
                number3 = Random.Range(0, 5);


            }
      
        

        if (number1 == number2 && number1 == number3)
            {
                u = false;
            Instantiate(surprises[1], droppoint);

            Debug.Log(i+ ", rtyhreyutryutyutyutu");

            }
            else if(number1 == number2 || number1 == number3 || number2  == number3 )
            {
            Instantiate(surprises[0], droppoint);
                Debug.Log("2 из 3");
            }
            


            if (i > 1000)
            {
                u = false;
                Debug.Log("Oblomov");
            }

       //}







        /*if (number1 == number2 && number3 == number2)
        {
            Instantiate(manyMoney, trans.position, Quaternion.identity);
            
        }
            
        else if (number1 == number2 || number2 == number3 || number1 == number3)
            Instantiate(someMoney, trans.position, Quaternion.identity);

        if(number1== 7 && number3 == 7 && number2 == 7)
        {
            Instantiate(someMoney, trans.position, Quaternion.identity);
            Instantiate(manyMoney, trans.position, Quaternion.identity);
            


        }*/


        /* while (i < 5)
         {
             number2 = Random.Range(0, 10);
             if(number1==number2)
             {
                 break;
             }
         }
         while (i < 4)
         {
             number2 = Random.Range(0, 10);
             if (number2 == number3)
             {
                 break;
             }
         }*/

        isDo = true;
    }
}
