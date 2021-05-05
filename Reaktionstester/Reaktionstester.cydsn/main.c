/* ========================================
REAKTIONSTESTER
 * ========================================
*/
#include "project.h"
#include <stdio.h>

typedef void (*FUNCPOINTER)(uint32);

void AwaitKeypressStart()
{
    UART_PC_PutString("Zum starten beliebige Taste druecken...\r\n");
    for(;;)
    {
        if (UART_PC_GetChar() != 0) return;
    }
}

int AwaitKeypressQuit()
{
    char cQuit;    
    UART_PC_ClearRxBuffer();
    UART_PC_PutString("Reaktionstester beenden? Ja ('j') | Nein (andere Taste)\n\r");    
    for(;;)
    {
        cQuit = UART_PC_GetChar();
        if (cQuit != 0)
        {            
            return (cQuit == 'j') ? 1 : 0;
        }    
    }
}

void PrintResult(int iData)
{
    char sResult[100];
    Pin_LED1_Write(0);
        
    switch(iData)
    {
        case -2:
            UART_PC_PutString("Knopf gedrueckt halten gilt nicht :) Bitte versuch es erneut!\n\r");
            break;
        case -1:
            UART_PC_PutString("Taste nicht gedrueckt. Testung abgebrochen.\n\r");
            break;
        default:
            sprintf(sResult, "Die Reaktionszeit betraegt %i ms.\n\r", iData);
            UART_PC_PutString(sResult);
            break;
    }    
}   

int Random()
{
    PRS_WriteSeed(Counter_ReadCounter());       
    return (500 + PRS_Read()%1500);
}

void LEDCountdown(int iCount)
{
    switch(iCount)
    {
        case 0:
            Pin_LED2_Write(0);
            Pin_LED3_Write(0);
            Pin_LED4_Write(0);
            break;
        case 1:
            Pin_LED2_Write(1);
            Pin_LED3_Write(0);
            Pin_LED4_Write(0);
            break;
        case 2:
            Pin_LED2_Write(1);
            Pin_LED3_Write(1);
            Pin_LED4_Write(0);
            break;
        case 3:
            Pin_LED2_Write(1);
            Pin_LED3_Write(1);
            Pin_LED4_Write(1);
            break;
        default:
            break;
    }
}

void Countdown(FUNCPOINTER pDelayFunction)
{  
    char sCountdown[100];
    UART_PC_PutString("Countdown ");        
    
    for (int iCountdown = 3; iCountdown > 0; iCountdown--)
    {
        sprintf(sCountdown, "%i .. ", iCountdown);
        UART_PC_PutString(sCountdown);
        LEDCountdown(iCountdown);
        pDelayFunction(1000);
    }
    LEDCountdown(0);
    UART_PC_PutString("los..\n\r");
    pDelayFunction(Random());
    Pin_LED1_Write(1);
}

int TestWithoutInterrupt(FUNCPOINTER pDelayFunction)
{    
    if (Pin_BiggerButton_Read() == 0)
    {        
        return -2;
    }
    
    for ( int iTimeElapsed = 0; iTimeElapsed < 2000; iTimeElapsed++)
    {
        pDelayFunction(1);
        //if (Pin_BiggerButton_Read() == 0) return iTimeElapsed;
        if (Pin_Button_Read() == 0) return iTimeElapsed;        
    }
    return -1;
}

void Init()
{
    CyGlobalIntEnable;     
    UART_PC_Start();  
    Counter_Start();
    PRS_Start();    
    UART_PC_ClearTxBuffer();
    UART_PC_PutString("Reaktionstester wurde gestartet...\n\r");
}

int main(void)
{
    // init    
    int iQuit = 0;    
    Init();      
    AwaitKeypressStart();
    
    for(;iQuit == 0;)
    {
        Pin_LED1_Write(0);                        
        Countdown(CyDelay);        
        PrintResult(TestWithoutInterrupt(CyDelay)); 
        iQuit = AwaitKeypressQuit();
    }
    
    UART_PC_PutString("Programm beendet.");
}

