/*******************************************************************************
* File Name: Timer_1ms_PM.c
* Version 2.80
*
*  Description:
*     This file provides the power management source code to API for the
*     Timer.
*
*   Note:
*     None
*
*******************************************************************************
* Copyright 2008-2017, Cypress Semiconductor Corporation.  All rights reserved.
* You may use this file only in accordance with the license, terms, conditions,
* disclaimers, and limitations in the end user license agreement accompanying
* the software package with which this file was provided.
********************************************************************************/

#include "Timer_1ms.h"

static Timer_1ms_backupStruct Timer_1ms_backup;


/*******************************************************************************
* Function Name: Timer_1ms_SaveConfig
********************************************************************************
*
* Summary:
*     Save the current user configuration
*
* Parameters:
*  void
*
* Return:
*  void
*
* Global variables:
*  Timer_1ms_backup:  Variables of this global structure are modified to
*  store the values of non retention configuration registers when Sleep() API is
*  called.
*
*******************************************************************************/
void Timer_1ms_SaveConfig(void) 
{
    #if (!Timer_1ms_UsingFixedFunction)
        Timer_1ms_backup.TimerUdb = Timer_1ms_ReadCounter();
        Timer_1ms_backup.InterruptMaskValue = Timer_1ms_STATUS_MASK;
        #if (Timer_1ms_UsingHWCaptureCounter)
            Timer_1ms_backup.TimerCaptureCounter = Timer_1ms_ReadCaptureCount();
        #endif /* Back Up capture counter register  */

        #if(!Timer_1ms_UDB_CONTROL_REG_REMOVED)
            Timer_1ms_backup.TimerControlRegister = Timer_1ms_ReadControlRegister();
        #endif /* Backup the enable state of the Timer component */
    #endif /* Backup non retention registers in UDB implementation. All fixed function registers are retention */
}


/*******************************************************************************
* Function Name: Timer_1ms_RestoreConfig
********************************************************************************
*
* Summary:
*  Restores the current user configuration.
*
* Parameters:
*  void
*
* Return:
*  void
*
* Global variables:
*  Timer_1ms_backup:  Variables of this global structure are used to
*  restore the values of non retention registers on wakeup from sleep mode.
*
*******************************************************************************/
void Timer_1ms_RestoreConfig(void) 
{   
    #if (!Timer_1ms_UsingFixedFunction)

        Timer_1ms_WriteCounter(Timer_1ms_backup.TimerUdb);
        Timer_1ms_STATUS_MASK =Timer_1ms_backup.InterruptMaskValue;
        #if (Timer_1ms_UsingHWCaptureCounter)
            Timer_1ms_SetCaptureCount(Timer_1ms_backup.TimerCaptureCounter);
        #endif /* Restore Capture counter register*/

        #if(!Timer_1ms_UDB_CONTROL_REG_REMOVED)
            Timer_1ms_WriteControlRegister(Timer_1ms_backup.TimerControlRegister);
        #endif /* Restore the enable state of the Timer component */
    #endif /* Restore non retention registers in the UDB implementation only */
}


/*******************************************************************************
* Function Name: Timer_1ms_Sleep
********************************************************************************
*
* Summary:
*     Stop and Save the user configuration
*
* Parameters:
*  void
*
* Return:
*  void
*
* Global variables:
*  Timer_1ms_backup.TimerEnableState:  Is modified depending on the
*  enable state of the block before entering sleep mode.
*
*******************************************************************************/
void Timer_1ms_Sleep(void) 
{
    #if(!Timer_1ms_UDB_CONTROL_REG_REMOVED)
        /* Save Counter's enable state */
        if(Timer_1ms_CTRL_ENABLE == (Timer_1ms_CONTROL & Timer_1ms_CTRL_ENABLE))
        {
            /* Timer is enabled */
            Timer_1ms_backup.TimerEnableState = 1u;
        }
        else
        {
            /* Timer is disabled */
            Timer_1ms_backup.TimerEnableState = 0u;
        }
    #endif /* Back up enable state from the Timer control register */
    Timer_1ms_Stop();
    Timer_1ms_SaveConfig();
}


/*******************************************************************************
* Function Name: Timer_1ms_Wakeup
********************************************************************************
*
* Summary:
*  Restores and enables the user configuration
*
* Parameters:
*  void
*
* Return:
*  void
*
* Global variables:
*  Timer_1ms_backup.enableState:  Is used to restore the enable state of
*  block on wakeup from sleep mode.
*
*******************************************************************************/
void Timer_1ms_Wakeup(void) 
{
    Timer_1ms_RestoreConfig();
    #if(!Timer_1ms_UDB_CONTROL_REG_REMOVED)
        if(Timer_1ms_backup.TimerEnableState == 1u)
        {     /* Enable Timer's operation */
                Timer_1ms_Enable();
        } /* Do nothing if Timer was disabled before */
    #endif /* Remove this code section if Control register is removed */
}


/* [] END OF FILE */
