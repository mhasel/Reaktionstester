/* ========================================
REAKTIONSTESTER
 * ========================================
*/
#include "project.h"
#include <stdio.h>

typedef void (*FuncPointer)(uint32 iData);

void AwaitKeypressToStart()
{
    for(;;)
    {
        char cUART = UART_PC_GetChar();        
        if (cUART == 0) continue;        
        else return;
    }
}

void PrintResult(int iData)
{
    char sResult[100];
    Pin_LED0_Write(0);
        
    switch(iData)
    {
        case -2:
            UART_PC_PutString("R:-2|");
            break;
        case -1:
            UART_PC_PutString("R:-1|");
            break;
        default:
            sprintf(sResult, "R:%i|", iData);
            UART_PC_PutString(sResult);
            break;
    }    
}   


int iTimeElapsed;
CY_ISR_PROTO (ISR_Timer_Interrupt);
CY_ISR (ISR_Timer_Interrupt)
{          
    int iStatus;   
    iStatus = Timer_Interrupt_ReadStatusRegister();
        
    if ((iStatus & Timer_Interrupt_STATUS_CAPTURE) != 0) iTimeElapsed = 2000 - Timer_Interrupt_ReadCapture();
        
    if ((iStatus & Timer_Interrupt_STATUS_TC) != 0) iTimeElapsed = -1;
}

void LEDCountdown(int iCount)
{
    switch(iCount)
    {
        // 3-2-1-0 Countdown
        case 0:
            Pin_LED1_Write(0);
            Pin_LED2_Write(0);
            Pin_LED3_Write(0);
            break;
            
        case 1:
            Pin_LED1_Write(1);
            Pin_LED2_Write(0);
            Pin_LED3_Write(0);
            break;
            
        case 2:
            Pin_LED1_Write(1);
            Pin_LED2_Write(1);
            Pin_LED3_Write(0);
            break;
            
        case 3:
            Pin_LED1_Write(1);
            Pin_LED2_Write(1);
            Pin_LED3_Write(1);
            break;
            
        // Go. On-Board LED ein
        case 4:
            Pin_LED0_Write(1);
            break;      
            
        default:
            break;
    }
}

int TestWithoutInterrupt(FuncPointer pDelayFunc)
{
    // Button bereits vorher gedrückt
    if ((Pin_Button_Read() == 0))
    {        
        return -2;
    }
    
    // Messung
    for ( int iTimeElapsed = 0; iTimeElapsed < 2000; iTimeElapsed++)
    {
        pDelayFunc(1);
        if (Pin_Button_Read() == 0) return iTimeElapsed;
    }
    
    // Maximale Zeit überschritten
    return -1;
}

int TestWithTimerInterrupt()
{  
    iTimeElapsed = -3; 
    // reset timer
    Control_Reg_Timer_Write(1);   
    while (iTimeElapsed == -3);   
    return iTimeElapsed;
}


void WaitingForCommands()
{  
    for (;;)
    {
        char cChar = UART_PC_GetChar();   
        if (cChar == 0) continue;
        else
        {
            switch(cChar)
            {               
                // LED Countdown
                case '3':
                    LEDCountdown(3);
                    break;
                    
                case '2':
                    LEDCountdown(2);
                    break;
                    
                case '1':
                    LEDCountdown(1);
                    break;
                    
                case '0':
                    LEDCountdown(0);
                    break;
                
                // Go!
                case 'g':                    
                    LEDCountdown(4);
                    //PrintResult(TestWithoutInterrupt(CyDelay));                     
                    PrintResult(TestWithTimerInterrupt());
                    break;
                default:
                    continue;
            }
        }
    }    
}

void Init()
{
    CyGlobalIntEnable;     
    UART_PC_Start();     
    UART_PC_ClearTxBuffer(); 
    AwaitKeypressToStart(); 
    
    // Timer interrupt        
    isr_Timer_StartEx(ISR_Timer_Interrupt);    
    Timer_Interrupt_Start();
}

int main(void)
{
    Init();     
    for(;;)
    {        
        WaitingForCommands();   
    }
}

