/* ========================================
REAKTIONSTESTER
 * ========================================
*/
#include "project.h"
#include <stdio.h>

typedef void (*FuncPointer)(uint32 iData);

void AwaitKeypressStart()
{
    UART_PC_PutString("T:Zum starten beliebige Taste druecken...|");
    for(;;)
    {
        if (UART_PC_GetChar() != 0)
        { 
            return;
        }
    }
}

int AwaitKeypressQuit()
{
    char cQuit;    
    UART_PC_ClearRxBuffer();
    UART_PC_PutString("T:Reaktionstester beenden? Ja ('j') / Nein (andere Taste)|");    
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
            UART_PC_PutString("R:Taste gedrueckt halten gilt nicht :) Bitte versuch es erneut!|");
            break;
        case -1:
            UART_PC_PutString("R:Taste nicht gedrueckt. Testung abgebrochen.|");
            break;
        default:
            sprintf(sResult, "R:Die Reaktionszeit betraegt %i ms.|", iData);
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

void Countdown(FuncPointer pDelayFunc)
{  
    char sCountdown[100];
    UART_PC_PutString("T:Druecke eine beliebige Taste, sobald alle 3 Kaestchen gruen leuchten!|");
    pDelayFunc(100);
    UART_PC_PutString("C:Countdown |");        
    
    for (int iCountdown = 3; iCountdown > 0; iCountdown--)
    {
        sprintf(sCountdown, "C:%i .. |", iCountdown);
        UART_PC_PutString(sCountdown);
        LEDCountdown(iCountdown);
        pDelayFunc(1000);
    }
    
    LEDCountdown(0);
    UART_PC_PutString("C:los..|");    
    UART_PC_ClearRxBuffer();
    pDelayFunc(Random());
    UART_PC_PutString("C:^|");
    Pin_LED1_Write(1);
}

int TestWithoutInterrupt(FuncPointer pDelayFunc)
{    
    if (Pin_BiggerButton_Read() == 0)
    {        
        return -2;
    }
    
    for ( int iTimeElapsed = 0; iTimeElapsed < 2000; iTimeElapsed++)
    {
        pDelayFunc(1);
        if (Pin_BiggerButton_Read() == 0) return iTimeElapsed;
    }
    return -1;
}

int TestOnPCInterface(FuncPointer pDelayFunc)
{
    if (UART_PC_GetChar() != 0)
    {        
        return -2;
    }
    
    for ( int iTimeElapsed = 0; iTimeElapsed < 2000; iTimeElapsed++)
    {
        pDelayFunc(1);
        if (UART_PC_GetChar() != 0) return iTimeElapsed;
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
    UART_PC_PutString("T:Reaktionstester wurde gestartet...|");
    if (UART_PC_GetChar() == '~') CySoftwareReset();
}

// TODO
void InterruptDelay(FuncPointer pDelayFunc)
{
    // do stuff
}

int main(void)
{
    // init    
    int iQuit = 0;    
    // Software delay
    FuncPointer pDelayFunc = CyDelay;    
    // Hardware delay/Interrupt
    // FUNCTIONPOINTER pDelayFunc = InterruptDelay;
    
    Init();              
    for(;iQuit == 0;)
    {                
        Pin_LED1_Write(0); 
        AwaitKeypressStart(); 
        // Countdown(CyDelay); <- auch möglich
        Countdown(pDelayFunc);        
        //PrintResult(TestWithoutInterrupt()); 
        PrintResult(TestOnPCInterface(pDelayFunc)); 
        iQuit = AwaitKeypressQuit();
    }
    
    UART_PC_PutString("T:Programm beendet.|");
}

