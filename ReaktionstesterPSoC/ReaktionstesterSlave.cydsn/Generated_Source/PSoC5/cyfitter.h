/*******************************************************************************
* File Name: cyfitter.h
* 
* PSoC Creator  4.4
*
* Description:
* 
* This file is automatically generated by PSoC Creator.
*
********************************************************************************
* Copyright (c) 2007-2020 Cypress Semiconductor.  All rights reserved.
* You may use this file only in accordance with the license, terms, conditions, 
* disclaimers, and limitations in the end user license agreement accompanying 
* the software package with which this file was provided.
********************************************************************************/

#ifndef INCLUDED_CYFITTER_H
#define INCLUDED_CYFITTER_H
#include "cydevice.h"
#include "cydevice_trm.h"

/* PRS */
#define PRS_ClkSp_CtrlReg__0__MASK 0x01u
#define PRS_ClkSp_CtrlReg__0__POS 0
#define PRS_ClkSp_CtrlReg__16BIT_CONTROL_AUX_CTL_REG CYREG_B1_UDB04_05_ACTL
#define PRS_ClkSp_CtrlReg__16BIT_CONTROL_CONTROL_REG CYREG_B1_UDB04_05_CTL
#define PRS_ClkSp_CtrlReg__16BIT_CONTROL_COUNT_REG CYREG_B1_UDB04_05_CTL
#define PRS_ClkSp_CtrlReg__16BIT_COUNT_CONTROL_REG CYREG_B1_UDB04_05_CTL
#define PRS_ClkSp_CtrlReg__16BIT_COUNT_COUNT_REG CYREG_B1_UDB04_05_CTL
#define PRS_ClkSp_CtrlReg__16BIT_MASK_MASK_REG CYREG_B1_UDB04_05_MSK
#define PRS_ClkSp_CtrlReg__16BIT_MASK_PERIOD_REG CYREG_B1_UDB04_05_MSK
#define PRS_ClkSp_CtrlReg__16BIT_PERIOD_MASK_REG CYREG_B1_UDB04_05_MSK
#define PRS_ClkSp_CtrlReg__16BIT_PERIOD_PERIOD_REG CYREG_B1_UDB04_05_MSK
#define PRS_ClkSp_CtrlReg__CONTROL_AUX_CTL_REG CYREG_B1_UDB04_ACTL
#define PRS_ClkSp_CtrlReg__CONTROL_REG CYREG_B1_UDB04_CTL
#define PRS_ClkSp_CtrlReg__CONTROL_ST_REG CYREG_B1_UDB04_ST_CTL
#define PRS_ClkSp_CtrlReg__COUNT_REG CYREG_B1_UDB04_CTL
#define PRS_ClkSp_CtrlReg__COUNT_ST_REG CYREG_B1_UDB04_ST_CTL
#define PRS_ClkSp_CtrlReg__MASK 0x01u
#define PRS_ClkSp_CtrlReg__MASK_CTL_AUX_CTL_REG CYREG_B1_UDB04_MSK_ACTL
#define PRS_ClkSp_CtrlReg__PER_CTL_AUX_CTL_REG CYREG_B1_UDB04_MSK_ACTL
#define PRS_ClkSp_CtrlReg__PERIOD_REG CYREG_B1_UDB04_MSK
#define PRS_sC24_PRSdp_u0__16BIT_A0_REG CYREG_B1_UDB04_05_A0
#define PRS_sC24_PRSdp_u0__16BIT_A1_REG CYREG_B1_UDB04_05_A1
#define PRS_sC24_PRSdp_u0__16BIT_D0_REG CYREG_B1_UDB04_05_D0
#define PRS_sC24_PRSdp_u0__16BIT_D1_REG CYREG_B1_UDB04_05_D1
#define PRS_sC24_PRSdp_u0__16BIT_DP_AUX_CTL_REG CYREG_B1_UDB04_05_ACTL
#define PRS_sC24_PRSdp_u0__16BIT_F0_REG CYREG_B1_UDB04_05_F0
#define PRS_sC24_PRSdp_u0__16BIT_F1_REG CYREG_B1_UDB04_05_F1
#define PRS_sC24_PRSdp_u0__A0_A1_REG CYREG_B1_UDB04_A0_A1
#define PRS_sC24_PRSdp_u0__A0_REG CYREG_B1_UDB04_A0
#define PRS_sC24_PRSdp_u0__A1_REG CYREG_B1_UDB04_A1
#define PRS_sC24_PRSdp_u0__D0_D1_REG CYREG_B1_UDB04_D0_D1
#define PRS_sC24_PRSdp_u0__D0_REG CYREG_B1_UDB04_D0
#define PRS_sC24_PRSdp_u0__D1_REG CYREG_B1_UDB04_D1
#define PRS_sC24_PRSdp_u0__DP_AUX_CTL_REG CYREG_B1_UDB04_ACTL
#define PRS_sC24_PRSdp_u0__F0_F1_REG CYREG_B1_UDB04_F0_F1
#define PRS_sC24_PRSdp_u0__F0_REG CYREG_B1_UDB04_F0
#define PRS_sC24_PRSdp_u0__F1_REG CYREG_B1_UDB04_F1
#define PRS_sC24_PRSdp_u0__MSK_DP_AUX_CTL_REG CYREG_B1_UDB04_MSK_ACTL
#define PRS_sC24_PRSdp_u0__PER_DP_AUX_CTL_REG CYREG_B1_UDB04_MSK_ACTL
#define PRS_sC24_PRSdp_u1__16BIT_A0_REG CYREG_B1_UDB05_06_A0
#define PRS_sC24_PRSdp_u1__16BIT_A1_REG CYREG_B1_UDB05_06_A1
#define PRS_sC24_PRSdp_u1__16BIT_D0_REG CYREG_B1_UDB05_06_D0
#define PRS_sC24_PRSdp_u1__16BIT_D1_REG CYREG_B1_UDB05_06_D1
#define PRS_sC24_PRSdp_u1__16BIT_DP_AUX_CTL_REG CYREG_B1_UDB05_06_ACTL
#define PRS_sC24_PRSdp_u1__16BIT_F0_REG CYREG_B1_UDB05_06_F0
#define PRS_sC24_PRSdp_u1__16BIT_F1_REG CYREG_B1_UDB05_06_F1
#define PRS_sC24_PRSdp_u1__A0_A1_REG CYREG_B1_UDB05_A0_A1
#define PRS_sC24_PRSdp_u1__A0_REG CYREG_B1_UDB05_A0
#define PRS_sC24_PRSdp_u1__A1_REG CYREG_B1_UDB05_A1
#define PRS_sC24_PRSdp_u1__D0_D1_REG CYREG_B1_UDB05_D0_D1
#define PRS_sC24_PRSdp_u1__D0_REG CYREG_B1_UDB05_D0
#define PRS_sC24_PRSdp_u1__D1_REG CYREG_B1_UDB05_D1
#define PRS_sC24_PRSdp_u1__DP_AUX_CTL_REG CYREG_B1_UDB05_ACTL
#define PRS_sC24_PRSdp_u1__F0_F1_REG CYREG_B1_UDB05_F0_F1
#define PRS_sC24_PRSdp_u1__F0_REG CYREG_B1_UDB05_F0
#define PRS_sC24_PRSdp_u1__F1_REG CYREG_B1_UDB05_F1
#define PRS_sC24_PRSdp_u2__16BIT_A0_REG CYREG_B1_UDB06_07_A0
#define PRS_sC24_PRSdp_u2__16BIT_A1_REG CYREG_B1_UDB06_07_A1
#define PRS_sC24_PRSdp_u2__16BIT_D0_REG CYREG_B1_UDB06_07_D0
#define PRS_sC24_PRSdp_u2__16BIT_D1_REG CYREG_B1_UDB06_07_D1
#define PRS_sC24_PRSdp_u2__16BIT_DP_AUX_CTL_REG CYREG_B1_UDB06_07_ACTL
#define PRS_sC24_PRSdp_u2__16BIT_F0_REG CYREG_B1_UDB06_07_F0
#define PRS_sC24_PRSdp_u2__16BIT_F1_REG CYREG_B1_UDB06_07_F1
#define PRS_sC24_PRSdp_u2__A0_A1_REG CYREG_B1_UDB06_A0_A1
#define PRS_sC24_PRSdp_u2__A0_REG CYREG_B1_UDB06_A0
#define PRS_sC24_PRSdp_u2__A1_REG CYREG_B1_UDB06_A1
#define PRS_sC24_PRSdp_u2__D0_D1_REG CYREG_B1_UDB06_D0_D1
#define PRS_sC24_PRSdp_u2__D0_REG CYREG_B1_UDB06_D0
#define PRS_sC24_PRSdp_u2__D1_REG CYREG_B1_UDB06_D1
#define PRS_sC24_PRSdp_u2__DP_AUX_CTL_REG CYREG_B1_UDB06_ACTL
#define PRS_sC24_PRSdp_u2__F0_F1_REG CYREG_B1_UDB06_F0_F1
#define PRS_sC24_PRSdp_u2__F0_REG CYREG_B1_UDB06_F0
#define PRS_sC24_PRSdp_u2__F1_REG CYREG_B1_UDB06_F1

/* RxD_PC */
#define RxD_PC__0__INTTYPE CYREG_PICU12_INTTYPE6
#define RxD_PC__0__MASK 0x40u
#define RxD_PC__0__PC CYREG_PRT12_PC6
#define RxD_PC__0__PORT 12u
#define RxD_PC__0__SHIFT 6u
#define RxD_PC__AG CYREG_PRT12_AG
#define RxD_PC__BIE CYREG_PRT12_BIE
#define RxD_PC__BIT_MASK CYREG_PRT12_BIT_MASK
#define RxD_PC__BYP CYREG_PRT12_BYP
#define RxD_PC__DM0 CYREG_PRT12_DM0
#define RxD_PC__DM1 CYREG_PRT12_DM1
#define RxD_PC__DM2 CYREG_PRT12_DM2
#define RxD_PC__DR CYREG_PRT12_DR
#define RxD_PC__INP_DIS CYREG_PRT12_INP_DIS
#define RxD_PC__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU12_BASE
#define RxD_PC__MASK 0x40u
#define RxD_PC__PORT 12u
#define RxD_PC__PRT CYREG_PRT12_PRT
#define RxD_PC__PRTDSI__DBL_SYNC_IN CYREG_PRT12_DBL_SYNC_IN
#define RxD_PC__PRTDSI__OE_SEL0 CYREG_PRT12_OE_SEL0
#define RxD_PC__PRTDSI__OE_SEL1 CYREG_PRT12_OE_SEL1
#define RxD_PC__PRTDSI__OUT_SEL0 CYREG_PRT12_OUT_SEL0
#define RxD_PC__PRTDSI__OUT_SEL1 CYREG_PRT12_OUT_SEL1
#define RxD_PC__PRTDSI__SYNC_OUT CYREG_PRT12_SYNC_OUT
#define RxD_PC__PS CYREG_PRT12_PS
#define RxD_PC__SHIFT 6u
#define RxD_PC__SIO_CFG CYREG_PRT12_SIO_CFG
#define RxD_PC__SIO_DIFF CYREG_PRT12_SIO_DIFF
#define RxD_PC__SIO_HYST_EN CYREG_PRT12_SIO_HYST_EN
#define RxD_PC__SIO_REG_HIFREQ CYREG_PRT12_SIO_REG_HIFREQ
#define RxD_PC__SLW CYREG_PRT12_SLW

/* TxD_PC */
#define TxD_PC__0__INTTYPE CYREG_PICU12_INTTYPE7
#define TxD_PC__0__MASK 0x80u
#define TxD_PC__0__PC CYREG_PRT12_PC7
#define TxD_PC__0__PORT 12u
#define TxD_PC__0__SHIFT 7u
#define TxD_PC__AG CYREG_PRT12_AG
#define TxD_PC__BIE CYREG_PRT12_BIE
#define TxD_PC__BIT_MASK CYREG_PRT12_BIT_MASK
#define TxD_PC__BYP CYREG_PRT12_BYP
#define TxD_PC__DM0 CYREG_PRT12_DM0
#define TxD_PC__DM1 CYREG_PRT12_DM1
#define TxD_PC__DM2 CYREG_PRT12_DM2
#define TxD_PC__DR CYREG_PRT12_DR
#define TxD_PC__INP_DIS CYREG_PRT12_INP_DIS
#define TxD_PC__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU12_BASE
#define TxD_PC__MASK 0x80u
#define TxD_PC__PORT 12u
#define TxD_PC__PRT CYREG_PRT12_PRT
#define TxD_PC__PRTDSI__DBL_SYNC_IN CYREG_PRT12_DBL_SYNC_IN
#define TxD_PC__PRTDSI__OE_SEL0 CYREG_PRT12_OE_SEL0
#define TxD_PC__PRTDSI__OE_SEL1 CYREG_PRT12_OE_SEL1
#define TxD_PC__PRTDSI__OUT_SEL0 CYREG_PRT12_OUT_SEL0
#define TxD_PC__PRTDSI__OUT_SEL1 CYREG_PRT12_OUT_SEL1
#define TxD_PC__PRTDSI__SYNC_OUT CYREG_PRT12_SYNC_OUT
#define TxD_PC__PS CYREG_PRT12_PS
#define TxD_PC__SHIFT 7u
#define TxD_PC__SIO_CFG CYREG_PRT12_SIO_CFG
#define TxD_PC__SIO_DIFF CYREG_PRT12_SIO_DIFF
#define TxD_PC__SIO_HYST_EN CYREG_PRT12_SIO_HYST_EN
#define TxD_PC__SIO_REG_HIFREQ CYREG_PRT12_SIO_REG_HIFREQ
#define TxD_PC__SLW CYREG_PRT12_SLW

/* UART_PC */
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_CONTROL_AUX_CTL_REG CYREG_B1_UDB08_09_ACTL
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_CONTROL_CONTROL_REG CYREG_B1_UDB08_09_CTL
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_CONTROL_COUNT_REG CYREG_B1_UDB08_09_CTL
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_COUNT_CONTROL_REG CYREG_B1_UDB08_09_CTL
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_COUNT_COUNT_REG CYREG_B1_UDB08_09_CTL
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_MASK_MASK_REG CYREG_B1_UDB08_09_MSK
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_MASK_PERIOD_REG CYREG_B1_UDB08_09_MSK
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_PERIOD_MASK_REG CYREG_B1_UDB08_09_MSK
#define UART_PC_BUART_sRX_RxBitCounter__16BIT_PERIOD_PERIOD_REG CYREG_B1_UDB08_09_MSK
#define UART_PC_BUART_sRX_RxBitCounter__CONTROL_AUX_CTL_REG CYREG_B1_UDB08_ACTL
#define UART_PC_BUART_sRX_RxBitCounter__CONTROL_REG CYREG_B1_UDB08_CTL
#define UART_PC_BUART_sRX_RxBitCounter__CONTROL_ST_REG CYREG_B1_UDB08_ST_CTL
#define UART_PC_BUART_sRX_RxBitCounter__COUNT_REG CYREG_B1_UDB08_CTL
#define UART_PC_BUART_sRX_RxBitCounter__COUNT_ST_REG CYREG_B1_UDB08_ST_CTL
#define UART_PC_BUART_sRX_RxBitCounter__MASK_CTL_AUX_CTL_REG CYREG_B1_UDB08_MSK_ACTL
#define UART_PC_BUART_sRX_RxBitCounter__PER_CTL_AUX_CTL_REG CYREG_B1_UDB08_MSK_ACTL
#define UART_PC_BUART_sRX_RxBitCounter__PERIOD_REG CYREG_B1_UDB08_MSK
#define UART_PC_BUART_sRX_RxBitCounter_ST__16BIT_STATUS_AUX_CTL_REG CYREG_B1_UDB08_09_ACTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__16BIT_STATUS_REG CYREG_B1_UDB08_09_ST
#define UART_PC_BUART_sRX_RxBitCounter_ST__MASK_REG CYREG_B1_UDB08_MSK
#define UART_PC_BUART_sRX_RxBitCounter_ST__MASK_ST_AUX_CTL_REG CYREG_B1_UDB08_MSK_ACTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__PER_ST_AUX_CTL_REG CYREG_B1_UDB08_MSK_ACTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__STATUS_AUX_CTL_REG CYREG_B1_UDB08_ACTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__STATUS_CNT_REG CYREG_B1_UDB08_ST_CTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__STATUS_CONTROL_REG CYREG_B1_UDB08_ST_CTL
#define UART_PC_BUART_sRX_RxBitCounter_ST__STATUS_REG CYREG_B1_UDB08_ST
#define UART_PC_BUART_sRX_RxShifter_u0__A0_A1_REG CYREG_B1_UDB11_A0_A1
#define UART_PC_BUART_sRX_RxShifter_u0__A0_REG CYREG_B1_UDB11_A0
#define UART_PC_BUART_sRX_RxShifter_u0__A1_REG CYREG_B1_UDB11_A1
#define UART_PC_BUART_sRX_RxShifter_u0__D0_D1_REG CYREG_B1_UDB11_D0_D1
#define UART_PC_BUART_sRX_RxShifter_u0__D0_REG CYREG_B1_UDB11_D0
#define UART_PC_BUART_sRX_RxShifter_u0__D1_REG CYREG_B1_UDB11_D1
#define UART_PC_BUART_sRX_RxShifter_u0__DP_AUX_CTL_REG CYREG_B1_UDB11_ACTL
#define UART_PC_BUART_sRX_RxShifter_u0__F0_F1_REG CYREG_B1_UDB11_F0_F1
#define UART_PC_BUART_sRX_RxShifter_u0__F0_REG CYREG_B1_UDB11_F0
#define UART_PC_BUART_sRX_RxShifter_u0__F1_REG CYREG_B1_UDB11_F1
#define UART_PC_BUART_sRX_RxSts__16BIT_STATUS_AUX_CTL_REG CYREG_B0_UDB08_09_ACTL
#define UART_PC_BUART_sRX_RxSts__16BIT_STATUS_REG CYREG_B0_UDB08_09_ST
#define UART_PC_BUART_sRX_RxSts__3__MASK 0x08u
#define UART_PC_BUART_sRX_RxSts__3__POS 3
#define UART_PC_BUART_sRX_RxSts__4__MASK 0x10u
#define UART_PC_BUART_sRX_RxSts__4__POS 4
#define UART_PC_BUART_sRX_RxSts__5__MASK 0x20u
#define UART_PC_BUART_sRX_RxSts__5__POS 5
#define UART_PC_BUART_sRX_RxSts__MASK 0x38u
#define UART_PC_BUART_sRX_RxSts__MASK_REG CYREG_B0_UDB08_MSK
#define UART_PC_BUART_sRX_RxSts__STATUS_AUX_CTL_REG CYREG_B0_UDB08_ACTL
#define UART_PC_BUART_sRX_RxSts__STATUS_REG CYREG_B0_UDB08_ST
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_A0_REG CYREG_B0_UDB08_09_A0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_A1_REG CYREG_B0_UDB08_09_A1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_D0_REG CYREG_B0_UDB08_09_D0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_D1_REG CYREG_B0_UDB08_09_D1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_DP_AUX_CTL_REG CYREG_B0_UDB08_09_ACTL
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_F0_REG CYREG_B0_UDB08_09_F0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__16BIT_F1_REG CYREG_B0_UDB08_09_F1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__A0_A1_REG CYREG_B0_UDB08_A0_A1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__A0_REG CYREG_B0_UDB08_A0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__A1_REG CYREG_B0_UDB08_A1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__D0_D1_REG CYREG_B0_UDB08_D0_D1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__D0_REG CYREG_B0_UDB08_D0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__D1_REG CYREG_B0_UDB08_D1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__DP_AUX_CTL_REG CYREG_B0_UDB08_ACTL
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__F0_F1_REG CYREG_B0_UDB08_F0_F1
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__F0_REG CYREG_B0_UDB08_F0
#define UART_PC_BUART_sTX_sCLOCK_TxBitClkGen__F1_REG CYREG_B0_UDB08_F1
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_A0_REG CYREG_B0_UDB09_10_A0
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_A1_REG CYREG_B0_UDB09_10_A1
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_D0_REG CYREG_B0_UDB09_10_D0
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_D1_REG CYREG_B0_UDB09_10_D1
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_DP_AUX_CTL_REG CYREG_B0_UDB09_10_ACTL
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_F0_REG CYREG_B0_UDB09_10_F0
#define UART_PC_BUART_sTX_TxShifter_u0__16BIT_F1_REG CYREG_B0_UDB09_10_F1
#define UART_PC_BUART_sTX_TxShifter_u0__A0_A1_REG CYREG_B0_UDB09_A0_A1
#define UART_PC_BUART_sTX_TxShifter_u0__A0_REG CYREG_B0_UDB09_A0
#define UART_PC_BUART_sTX_TxShifter_u0__A1_REG CYREG_B0_UDB09_A1
#define UART_PC_BUART_sTX_TxShifter_u0__D0_D1_REG CYREG_B0_UDB09_D0_D1
#define UART_PC_BUART_sTX_TxShifter_u0__D0_REG CYREG_B0_UDB09_D0
#define UART_PC_BUART_sTX_TxShifter_u0__D1_REG CYREG_B0_UDB09_D1
#define UART_PC_BUART_sTX_TxShifter_u0__DP_AUX_CTL_REG CYREG_B0_UDB09_ACTL
#define UART_PC_BUART_sTX_TxShifter_u0__F0_F1_REG CYREG_B0_UDB09_F0_F1
#define UART_PC_BUART_sTX_TxShifter_u0__F0_REG CYREG_B0_UDB09_F0
#define UART_PC_BUART_sTX_TxShifter_u0__F1_REG CYREG_B0_UDB09_F1
#define UART_PC_BUART_sTX_TxSts__0__MASK 0x01u
#define UART_PC_BUART_sTX_TxSts__0__POS 0
#define UART_PC_BUART_sTX_TxSts__1__MASK 0x02u
#define UART_PC_BUART_sTX_TxSts__1__POS 1
#define UART_PC_BUART_sTX_TxSts__16BIT_STATUS_AUX_CTL_REG CYREG_B1_UDB09_10_ACTL
#define UART_PC_BUART_sTX_TxSts__16BIT_STATUS_REG CYREG_B1_UDB09_10_ST
#define UART_PC_BUART_sTX_TxSts__2__MASK 0x04u
#define UART_PC_BUART_sTX_TxSts__2__POS 2
#define UART_PC_BUART_sTX_TxSts__3__MASK 0x08u
#define UART_PC_BUART_sTX_TxSts__3__POS 3
#define UART_PC_BUART_sTX_TxSts__MASK 0x0Fu
#define UART_PC_BUART_sTX_TxSts__MASK_REG CYREG_B1_UDB09_MSK
#define UART_PC_BUART_sTX_TxSts__STATUS_AUX_CTL_REG CYREG_B1_UDB09_ACTL
#define UART_PC_BUART_sTX_TxSts__STATUS_REG CYREG_B1_UDB09_ST
#define UART_PC_IntClock__CFG0 CYREG_CLKDIST_DCFG0_CFG0
#define UART_PC_IntClock__CFG1 CYREG_CLKDIST_DCFG0_CFG1
#define UART_PC_IntClock__CFG2 CYREG_CLKDIST_DCFG0_CFG2
#define UART_PC_IntClock__CFG2_SRC_SEL_MASK 0x07u
#define UART_PC_IntClock__INDEX 0x00u
#define UART_PC_IntClock__PM_ACT_CFG CYREG_PM_ACT_CFG2
#define UART_PC_IntClock__PM_ACT_MSK 0x01u
#define UART_PC_IntClock__PM_STBY_CFG CYREG_PM_STBY_CFG2
#define UART_PC_IntClock__PM_STBY_MSK 0x01u

/* Pin_LED0 */
#define Pin_LED0__0__INTTYPE CYREG_PICU2_INTTYPE1
#define Pin_LED0__0__MASK 0x02u
#define Pin_LED0__0__PC CYREG_PRT2_PC1
#define Pin_LED0__0__PORT 2u
#define Pin_LED0__0__SHIFT 1u
#define Pin_LED0__AG CYREG_PRT2_AG
#define Pin_LED0__AMUX CYREG_PRT2_AMUX
#define Pin_LED0__BIE CYREG_PRT2_BIE
#define Pin_LED0__BIT_MASK CYREG_PRT2_BIT_MASK
#define Pin_LED0__BYP CYREG_PRT2_BYP
#define Pin_LED0__CTL CYREG_PRT2_CTL
#define Pin_LED0__DM0 CYREG_PRT2_DM0
#define Pin_LED0__DM1 CYREG_PRT2_DM1
#define Pin_LED0__DM2 CYREG_PRT2_DM2
#define Pin_LED0__DR CYREG_PRT2_DR
#define Pin_LED0__INP_DIS CYREG_PRT2_INP_DIS
#define Pin_LED0__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU2_BASE
#define Pin_LED0__LCD_COM_SEG CYREG_PRT2_LCD_COM_SEG
#define Pin_LED0__LCD_EN CYREG_PRT2_LCD_EN
#define Pin_LED0__MASK 0x02u
#define Pin_LED0__PORT 2u
#define Pin_LED0__PRT CYREG_PRT2_PRT
#define Pin_LED0__PRTDSI__CAPS_SEL CYREG_PRT2_CAPS_SEL
#define Pin_LED0__PRTDSI__DBL_SYNC_IN CYREG_PRT2_DBL_SYNC_IN
#define Pin_LED0__PRTDSI__OE_SEL0 CYREG_PRT2_OE_SEL0
#define Pin_LED0__PRTDSI__OE_SEL1 CYREG_PRT2_OE_SEL1
#define Pin_LED0__PRTDSI__OUT_SEL0 CYREG_PRT2_OUT_SEL0
#define Pin_LED0__PRTDSI__OUT_SEL1 CYREG_PRT2_OUT_SEL1
#define Pin_LED0__PRTDSI__SYNC_OUT CYREG_PRT2_SYNC_OUT
#define Pin_LED0__PS CYREG_PRT2_PS
#define Pin_LED0__SHIFT 1u
#define Pin_LED0__SLW CYREG_PRT2_SLW

/* Pin_LED1 */
#define Pin_LED1__0__INTTYPE CYREG_PICU12_INTTYPE2
#define Pin_LED1__0__MASK 0x04u
#define Pin_LED1__0__PC CYREG_PRT12_PC2
#define Pin_LED1__0__PORT 12u
#define Pin_LED1__0__SHIFT 2u
#define Pin_LED1__AG CYREG_PRT12_AG
#define Pin_LED1__BIE CYREG_PRT12_BIE
#define Pin_LED1__BIT_MASK CYREG_PRT12_BIT_MASK
#define Pin_LED1__BYP CYREG_PRT12_BYP
#define Pin_LED1__DM0 CYREG_PRT12_DM0
#define Pin_LED1__DM1 CYREG_PRT12_DM1
#define Pin_LED1__DM2 CYREG_PRT12_DM2
#define Pin_LED1__DR CYREG_PRT12_DR
#define Pin_LED1__INP_DIS CYREG_PRT12_INP_DIS
#define Pin_LED1__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU12_BASE
#define Pin_LED1__MASK 0x04u
#define Pin_LED1__PORT 12u
#define Pin_LED1__PRT CYREG_PRT12_PRT
#define Pin_LED1__PRTDSI__DBL_SYNC_IN CYREG_PRT12_DBL_SYNC_IN
#define Pin_LED1__PRTDSI__OE_SEL0 CYREG_PRT12_OE_SEL0
#define Pin_LED1__PRTDSI__OE_SEL1 CYREG_PRT12_OE_SEL1
#define Pin_LED1__PRTDSI__OUT_SEL0 CYREG_PRT12_OUT_SEL0
#define Pin_LED1__PRTDSI__OUT_SEL1 CYREG_PRT12_OUT_SEL1
#define Pin_LED1__PRTDSI__SYNC_OUT CYREG_PRT12_SYNC_OUT
#define Pin_LED1__PS CYREG_PRT12_PS
#define Pin_LED1__SHIFT 2u
#define Pin_LED1__SIO_CFG CYREG_PRT12_SIO_CFG
#define Pin_LED1__SIO_DIFF CYREG_PRT12_SIO_DIFF
#define Pin_LED1__SIO_HYST_EN CYREG_PRT12_SIO_HYST_EN
#define Pin_LED1__SIO_REG_HIFREQ CYREG_PRT12_SIO_REG_HIFREQ
#define Pin_LED1__SLW CYREG_PRT12_SLW

/* Pin_LED2 */
#define Pin_LED2__0__INTTYPE CYREG_PICU12_INTTYPE3
#define Pin_LED2__0__MASK 0x08u
#define Pin_LED2__0__PC CYREG_PRT12_PC3
#define Pin_LED2__0__PORT 12u
#define Pin_LED2__0__SHIFT 3u
#define Pin_LED2__AG CYREG_PRT12_AG
#define Pin_LED2__BIE CYREG_PRT12_BIE
#define Pin_LED2__BIT_MASK CYREG_PRT12_BIT_MASK
#define Pin_LED2__BYP CYREG_PRT12_BYP
#define Pin_LED2__DM0 CYREG_PRT12_DM0
#define Pin_LED2__DM1 CYREG_PRT12_DM1
#define Pin_LED2__DM2 CYREG_PRT12_DM2
#define Pin_LED2__DR CYREG_PRT12_DR
#define Pin_LED2__INP_DIS CYREG_PRT12_INP_DIS
#define Pin_LED2__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU12_BASE
#define Pin_LED2__MASK 0x08u
#define Pin_LED2__PORT 12u
#define Pin_LED2__PRT CYREG_PRT12_PRT
#define Pin_LED2__PRTDSI__DBL_SYNC_IN CYREG_PRT12_DBL_SYNC_IN
#define Pin_LED2__PRTDSI__OE_SEL0 CYREG_PRT12_OE_SEL0
#define Pin_LED2__PRTDSI__OE_SEL1 CYREG_PRT12_OE_SEL1
#define Pin_LED2__PRTDSI__OUT_SEL0 CYREG_PRT12_OUT_SEL0
#define Pin_LED2__PRTDSI__OUT_SEL1 CYREG_PRT12_OUT_SEL1
#define Pin_LED2__PRTDSI__SYNC_OUT CYREG_PRT12_SYNC_OUT
#define Pin_LED2__PS CYREG_PRT12_PS
#define Pin_LED2__SHIFT 3u
#define Pin_LED2__SIO_CFG CYREG_PRT12_SIO_CFG
#define Pin_LED2__SIO_DIFF CYREG_PRT12_SIO_DIFF
#define Pin_LED2__SIO_HYST_EN CYREG_PRT12_SIO_HYST_EN
#define Pin_LED2__SIO_REG_HIFREQ CYREG_PRT12_SIO_REG_HIFREQ
#define Pin_LED2__SLW CYREG_PRT12_SLW

/* Pin_LED3 */
#define Pin_LED3__0__INTTYPE CYREG_PICU2_INTTYPE0
#define Pin_LED3__0__MASK 0x01u
#define Pin_LED3__0__PC CYREG_PRT2_PC0
#define Pin_LED3__0__PORT 2u
#define Pin_LED3__0__SHIFT 0u
#define Pin_LED3__AG CYREG_PRT2_AG
#define Pin_LED3__AMUX CYREG_PRT2_AMUX
#define Pin_LED3__BIE CYREG_PRT2_BIE
#define Pin_LED3__BIT_MASK CYREG_PRT2_BIT_MASK
#define Pin_LED3__BYP CYREG_PRT2_BYP
#define Pin_LED3__CTL CYREG_PRT2_CTL
#define Pin_LED3__DM0 CYREG_PRT2_DM0
#define Pin_LED3__DM1 CYREG_PRT2_DM1
#define Pin_LED3__DM2 CYREG_PRT2_DM2
#define Pin_LED3__DR CYREG_PRT2_DR
#define Pin_LED3__INP_DIS CYREG_PRT2_INP_DIS
#define Pin_LED3__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU2_BASE
#define Pin_LED3__LCD_COM_SEG CYREG_PRT2_LCD_COM_SEG
#define Pin_LED3__LCD_EN CYREG_PRT2_LCD_EN
#define Pin_LED3__MASK 0x01u
#define Pin_LED3__PORT 2u
#define Pin_LED3__PRT CYREG_PRT2_PRT
#define Pin_LED3__PRTDSI__CAPS_SEL CYREG_PRT2_CAPS_SEL
#define Pin_LED3__PRTDSI__DBL_SYNC_IN CYREG_PRT2_DBL_SYNC_IN
#define Pin_LED3__PRTDSI__OE_SEL0 CYREG_PRT2_OE_SEL0
#define Pin_LED3__PRTDSI__OE_SEL1 CYREG_PRT2_OE_SEL1
#define Pin_LED3__PRTDSI__OUT_SEL0 CYREG_PRT2_OUT_SEL0
#define Pin_LED3__PRTDSI__OUT_SEL1 CYREG_PRT2_OUT_SEL1
#define Pin_LED3__PRTDSI__SYNC_OUT CYREG_PRT2_SYNC_OUT
#define Pin_LED3__PS CYREG_PRT2_PS
#define Pin_LED3__SHIFT 0u
#define Pin_LED3__SLW CYREG_PRT2_SLW

/* isr_Timer */
#define isr_Timer__INTC_CLR_EN_REG CYREG_NVIC_CLRENA0
#define isr_Timer__INTC_CLR_PD_REG CYREG_NVIC_CLRPEND0
#define isr_Timer__INTC_MASK 0x20000u
#define isr_Timer__INTC_NUMBER 17u
#define isr_Timer__INTC_PRIOR_NUM 7u
#define isr_Timer__INTC_PRIOR_REG CYREG_NVIC_PRI_17
#define isr_Timer__INTC_SET_EN_REG CYREG_NVIC_SETENA0
#define isr_Timer__INTC_SET_PD_REG CYREG_NVIC_SETPEND0

/* Clock_1KHz */
#define Clock_1KHz__CFG0 CYREG_CLKDIST_DCFG1_CFG0
#define Clock_1KHz__CFG1 CYREG_CLKDIST_DCFG1_CFG1
#define Clock_1KHz__CFG2 CYREG_CLKDIST_DCFG1_CFG2
#define Clock_1KHz__CFG2_SRC_SEL_MASK 0x07u
#define Clock_1KHz__INDEX 0x01u
#define Clock_1KHz__PM_ACT_CFG CYREG_PM_ACT_CFG2
#define Clock_1KHz__PM_ACT_MSK 0x02u
#define Clock_1KHz__PM_STBY_CFG CYREG_PM_STBY_CFG2
#define Clock_1KHz__PM_STBY_MSK 0x02u

/* Pin_Button */
#define Pin_Button__0__INTTYPE CYREG_PICU2_INTTYPE2
#define Pin_Button__0__MASK 0x04u
#define Pin_Button__0__PC CYREG_PRT2_PC2
#define Pin_Button__0__PORT 2u
#define Pin_Button__0__SHIFT 2u
#define Pin_Button__AG CYREG_PRT2_AG
#define Pin_Button__AMUX CYREG_PRT2_AMUX
#define Pin_Button__BIE CYREG_PRT2_BIE
#define Pin_Button__BIT_MASK CYREG_PRT2_BIT_MASK
#define Pin_Button__BYP CYREG_PRT2_BYP
#define Pin_Button__CTL CYREG_PRT2_CTL
#define Pin_Button__DM0 CYREG_PRT2_DM0
#define Pin_Button__DM1 CYREG_PRT2_DM1
#define Pin_Button__DM2 CYREG_PRT2_DM2
#define Pin_Button__DR CYREG_PRT2_DR
#define Pin_Button__INP_DIS CYREG_PRT2_INP_DIS
#define Pin_Button__INTTYPE_BASE CYDEV_PICU_INTTYPE_PICU2_BASE
#define Pin_Button__LCD_COM_SEG CYREG_PRT2_LCD_COM_SEG
#define Pin_Button__LCD_EN CYREG_PRT2_LCD_EN
#define Pin_Button__MASK 0x04u
#define Pin_Button__PORT 2u
#define Pin_Button__PRT CYREG_PRT2_PRT
#define Pin_Button__PRTDSI__CAPS_SEL CYREG_PRT2_CAPS_SEL
#define Pin_Button__PRTDSI__DBL_SYNC_IN CYREG_PRT2_DBL_SYNC_IN
#define Pin_Button__PRTDSI__OE_SEL0 CYREG_PRT2_OE_SEL0
#define Pin_Button__PRTDSI__OE_SEL1 CYREG_PRT2_OE_SEL1
#define Pin_Button__PRTDSI__OUT_SEL0 CYREG_PRT2_OUT_SEL0
#define Pin_Button__PRTDSI__OUT_SEL1 CYREG_PRT2_OUT_SEL1
#define Pin_Button__PRTDSI__SYNC_OUT CYREG_PRT2_SYNC_OUT
#define Pin_Button__PS CYREG_PRT2_PS
#define Pin_Button__SHIFT 2u
#define Pin_Button__SLW CYREG_PRT2_SLW

/* Timer_Interrupt */
#define Timer_Interrupt_TimerHW__CAP0 CYREG_TMR0_CAP0
#define Timer_Interrupt_TimerHW__CAP1 CYREG_TMR0_CAP1
#define Timer_Interrupt_TimerHW__CFG0 CYREG_TMR0_CFG0
#define Timer_Interrupt_TimerHW__CFG1 CYREG_TMR0_CFG1
#define Timer_Interrupt_TimerHW__CFG2 CYREG_TMR0_CFG2
#define Timer_Interrupt_TimerHW__CNT_CMP0 CYREG_TMR0_CNT_CMP0
#define Timer_Interrupt_TimerHW__CNT_CMP1 CYREG_TMR0_CNT_CMP1
#define Timer_Interrupt_TimerHW__PER0 CYREG_TMR0_PER0
#define Timer_Interrupt_TimerHW__PER1 CYREG_TMR0_PER1
#define Timer_Interrupt_TimerHW__PM_ACT_CFG CYREG_PM_ACT_CFG3
#define Timer_Interrupt_TimerHW__PM_ACT_MSK 0x01u
#define Timer_Interrupt_TimerHW__PM_STBY_CFG CYREG_PM_STBY_CFG3
#define Timer_Interrupt_TimerHW__PM_STBY_MSK 0x01u
#define Timer_Interrupt_TimerHW__RT0 CYREG_TMR0_RT0
#define Timer_Interrupt_TimerHW__RT1 CYREG_TMR0_RT1
#define Timer_Interrupt_TimerHW__SR0 CYREG_TMR0_SR0

/* Control_Reg_Timer */
#define Control_Reg_Timer_Sync_ctrl_reg__0__MASK 0x01u
#define Control_Reg_Timer_Sync_ctrl_reg__0__POS 0
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_CONTROL_AUX_CTL_REG CYREG_B1_UDB07_08_ACTL
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_CONTROL_CONTROL_REG CYREG_B1_UDB07_08_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_CONTROL_COUNT_REG CYREG_B1_UDB07_08_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_COUNT_CONTROL_REG CYREG_B1_UDB07_08_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_COUNT_COUNT_REG CYREG_B1_UDB07_08_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_MASK_MASK_REG CYREG_B1_UDB07_08_MSK
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_MASK_PERIOD_REG CYREG_B1_UDB07_08_MSK
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_PERIOD_MASK_REG CYREG_B1_UDB07_08_MSK
#define Control_Reg_Timer_Sync_ctrl_reg__16BIT_PERIOD_PERIOD_REG CYREG_B1_UDB07_08_MSK
#define Control_Reg_Timer_Sync_ctrl_reg__CONTROL_AUX_CTL_REG CYREG_B1_UDB07_ACTL
#define Control_Reg_Timer_Sync_ctrl_reg__CONTROL_REG CYREG_B1_UDB07_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__CONTROL_ST_REG CYREG_B1_UDB07_ST_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__COUNT_REG CYREG_B1_UDB07_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__COUNT_ST_REG CYREG_B1_UDB07_ST_CTL
#define Control_Reg_Timer_Sync_ctrl_reg__MASK 0x01u
#define Control_Reg_Timer_Sync_ctrl_reg__MASK_CTL_AUX_CTL_REG CYREG_B1_UDB07_MSK_ACTL
#define Control_Reg_Timer_Sync_ctrl_reg__PER_CTL_AUX_CTL_REG CYREG_B1_UDB07_MSK_ACTL
#define Control_Reg_Timer_Sync_ctrl_reg__PERIOD_REG CYREG_B1_UDB07_MSK

/* Miscellaneous */
#define BCLK__BUS_CLK__HZ 24000000U
#define BCLK__BUS_CLK__KHZ 24000U
#define BCLK__BUS_CLK__MHZ 24U
#define CY_PROJECT_NAME "ReaktionstesterSlave"
#define CY_VERSION "PSoC Creator  4.4"
#define CYDEV_CHIP_DIE_LEOPARD 1u
#define CYDEV_CHIP_DIE_PSOC4A 26u
#define CYDEV_CHIP_DIE_PSOC5LP 2u
#define CYDEV_CHIP_DIE_PSOC5TM 3u
#define CYDEV_CHIP_DIE_TMA4 4u
#define CYDEV_CHIP_DIE_UNKNOWN 0u
#define CYDEV_CHIP_FAMILY_FM0P 5u
#define CYDEV_CHIP_FAMILY_FM3 6u
#define CYDEV_CHIP_FAMILY_FM4 7u
#define CYDEV_CHIP_FAMILY_PSOC3 1u
#define CYDEV_CHIP_FAMILY_PSOC4 2u
#define CYDEV_CHIP_FAMILY_PSOC5 3u
#define CYDEV_CHIP_FAMILY_PSOC6 4u
#define CYDEV_CHIP_FAMILY_UNKNOWN 0u
#define CYDEV_CHIP_FAMILY_USED CYDEV_CHIP_FAMILY_PSOC5
#define CYDEV_CHIP_JTAG_ID 0x2E161069u
#define CYDEV_CHIP_MEMBER_3A 1u
#define CYDEV_CHIP_MEMBER_4A 26u
#define CYDEV_CHIP_MEMBER_4AA 25u
#define CYDEV_CHIP_MEMBER_4AB 30u
#define CYDEV_CHIP_MEMBER_4AC 14u
#define CYDEV_CHIP_MEMBER_4AD 15u
#define CYDEV_CHIP_MEMBER_4AE 16u
#define CYDEV_CHIP_MEMBER_4D 20u
#define CYDEV_CHIP_MEMBER_4E 6u
#define CYDEV_CHIP_MEMBER_4F 27u
#define CYDEV_CHIP_MEMBER_4G 4u
#define CYDEV_CHIP_MEMBER_4H 24u
#define CYDEV_CHIP_MEMBER_4I 32u
#define CYDEV_CHIP_MEMBER_4J 21u
#define CYDEV_CHIP_MEMBER_4K 22u
#define CYDEV_CHIP_MEMBER_4L 31u
#define CYDEV_CHIP_MEMBER_4M 29u
#define CYDEV_CHIP_MEMBER_4N 11u
#define CYDEV_CHIP_MEMBER_4O 8u
#define CYDEV_CHIP_MEMBER_4P 28u
#define CYDEV_CHIP_MEMBER_4Q 17u
#define CYDEV_CHIP_MEMBER_4R 9u
#define CYDEV_CHIP_MEMBER_4S 12u
#define CYDEV_CHIP_MEMBER_4T 10u
#define CYDEV_CHIP_MEMBER_4U 5u
#define CYDEV_CHIP_MEMBER_4V 23u
#define CYDEV_CHIP_MEMBER_4W 13u
#define CYDEV_CHIP_MEMBER_4X 7u
#define CYDEV_CHIP_MEMBER_4Y 18u
#define CYDEV_CHIP_MEMBER_4Z 19u
#define CYDEV_CHIP_MEMBER_5A 3u
#define CYDEV_CHIP_MEMBER_5B 2u
#define CYDEV_CHIP_MEMBER_6A 33u
#define CYDEV_CHIP_MEMBER_FM3 37u
#define CYDEV_CHIP_MEMBER_FM4 38u
#define CYDEV_CHIP_MEMBER_PDL_FM0P_TYPE1 34u
#define CYDEV_CHIP_MEMBER_PDL_FM0P_TYPE2 35u
#define CYDEV_CHIP_MEMBER_PDL_FM0P_TYPE3 36u
#define CYDEV_CHIP_MEMBER_UNKNOWN 0u
#define CYDEV_CHIP_MEMBER_USED CYDEV_CHIP_MEMBER_5B
#define CYDEV_CHIP_DIE_EXPECT CYDEV_CHIP_MEMBER_USED
#define CYDEV_CHIP_DIE_ACTUAL CYDEV_CHIP_DIE_EXPECT
#define CYDEV_CHIP_REV_LEOPARD_ES1 0u
#define CYDEV_CHIP_REV_LEOPARD_ES2 1u
#define CYDEV_CHIP_REV_LEOPARD_ES3 3u
#define CYDEV_CHIP_REV_LEOPARD_PRODUCTION 3u
#define CYDEV_CHIP_REV_PSOC4A_ES0 17u
#define CYDEV_CHIP_REV_PSOC4A_PRODUCTION 17u
#define CYDEV_CHIP_REV_PSOC5LP_ES0 0u
#define CYDEV_CHIP_REV_PSOC5LP_PRODUCTION 0u
#define CYDEV_CHIP_REV_PSOC5TM_ES0 0u
#define CYDEV_CHIP_REV_PSOC5TM_ES1 1u
#define CYDEV_CHIP_REV_PSOC5TM_PRODUCTION 1u
#define CYDEV_CHIP_REV_TMA4_ES 17u
#define CYDEV_CHIP_REV_TMA4_ES2 33u
#define CYDEV_CHIP_REV_TMA4_PRODUCTION 17u
#define CYDEV_CHIP_REVISION_3A_ES1 0u
#define CYDEV_CHIP_REVISION_3A_ES2 1u
#define CYDEV_CHIP_REVISION_3A_ES3 3u
#define CYDEV_CHIP_REVISION_3A_PRODUCTION 3u
#define CYDEV_CHIP_REVISION_4A_ES0 17u
#define CYDEV_CHIP_REVISION_4A_PRODUCTION 17u
#define CYDEV_CHIP_REVISION_4AA_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4AB_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4AC_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4AD_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4AE_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4D_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4E_CCG2_NO_USBPD 0u
#define CYDEV_CHIP_REVISION_4E_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4F_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4F_PRODUCTION_256DMA 0u
#define CYDEV_CHIP_REVISION_4F_PRODUCTION_256K 0u
#define CYDEV_CHIP_REVISION_4G_ES 17u
#define CYDEV_CHIP_REVISION_4G_ES2 33u
#define CYDEV_CHIP_REVISION_4G_PRODUCTION 17u
#define CYDEV_CHIP_REVISION_4H_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4I_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4J_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4K_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4L_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4M_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4N_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4O_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4P_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4Q_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4R_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4S_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4T_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4U_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4V_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4W_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4X_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4Y_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_4Z_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_5A_ES0 0u
#define CYDEV_CHIP_REVISION_5A_ES1 1u
#define CYDEV_CHIP_REVISION_5A_PRODUCTION 1u
#define CYDEV_CHIP_REVISION_5B_ES0 0u
#define CYDEV_CHIP_REVISION_5B_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_6A_ES 17u
#define CYDEV_CHIP_REVISION_6A_NO_UDB 33u
#define CYDEV_CHIP_REVISION_6A_PRODUCTION 33u
#define CYDEV_CHIP_REVISION_FM3_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_FM4_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_PDL_FM0P_TYPE1_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_PDL_FM0P_TYPE2_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_PDL_FM0P_TYPE3_PRODUCTION 0u
#define CYDEV_CHIP_REVISION_USED CYDEV_CHIP_REVISION_5B_PRODUCTION
#define CYDEV_CHIP_REV_EXPECT CYDEV_CHIP_REVISION_USED
#define CYDEV_CONFIG_FASTBOOT_ENABLED 1
#define CYDEV_CONFIG_UNUSED_IO_AllowButWarn 0
#define CYDEV_CONFIG_UNUSED_IO CYDEV_CONFIG_UNUSED_IO_AllowButWarn
#define CYDEV_CONFIG_UNUSED_IO_AllowWithInfo 1
#define CYDEV_CONFIG_UNUSED_IO_Disallowed 2
#define CYDEV_CONFIGURATION_COMPRESSED 1
#define CYDEV_CONFIGURATION_DMA 0
#define CYDEV_CONFIGURATION_ECC 1
#define CYDEV_CONFIGURATION_IMOENABLED CYDEV_CONFIG_FASTBOOT_ENABLED
#define CYDEV_CONFIGURATION_MODE_COMPRESSED 0
#define CYDEV_CONFIGURATION_MODE CYDEV_CONFIGURATION_MODE_COMPRESSED
#define CYDEV_CONFIGURATION_MODE_DMA 2
#define CYDEV_CONFIGURATION_MODE_UNCOMPRESSED 1
#define CYDEV_DEBUG_ENABLE_MASK 0x20u
#define CYDEV_DEBUG_ENABLE_REGISTER CYREG_MLOGIC_DEBUG
#define CYDEV_DEBUGGING_DPS_Disable 3
#define CYDEV_DEBUGGING_DPS_JTAG_4 1
#define CYDEV_DEBUGGING_DPS_JTAG_5 0
#define CYDEV_DEBUGGING_DPS_SWD 2
#define CYDEV_DEBUGGING_DPS_SWD_SWV 6
#define CYDEV_DEBUGGING_DPS CYDEV_DEBUGGING_DPS_SWD_SWV
#define CYDEV_DEBUGGING_ENABLE 1
#define CYDEV_DEBUGGING_XRES 0
#define CYDEV_DMA_CHANNELS_AVAILABLE 24u
#define CYDEV_ECC_ENABLE 0
#define CYDEV_HEAP_SIZE 0x80
#define CYDEV_INSTRUCT_CACHE_ENABLED 1
#define CYDEV_INTR_RISING 0x00000000u
#define CYDEV_IS_EXPORTING_CODE 0
#define CYDEV_IS_IMPORTING_CODE 0
#define CYDEV_PROJ_TYPE 0
#define CYDEV_PROJ_TYPE_BOOTLOADER 1
#define CYDEV_PROJ_TYPE_LAUNCHER 5
#define CYDEV_PROJ_TYPE_LOADABLE 2
#define CYDEV_PROJ_TYPE_LOADABLEANDBOOTLOADER 4
#define CYDEV_PROJ_TYPE_MULTIAPPBOOTLOADER 3
#define CYDEV_PROJ_TYPE_STANDARD 0
#define CYDEV_PROTECTION_ENABLE 0
#define CYDEV_STACK_SIZE 0x0800
#define CYDEV_USE_BUNDLED_CMSIS 1
#define CYDEV_VARIABLE_VDDA 0
#define CYDEV_VDDA 5.0
#define CYDEV_VDDA_MV 5000
#define CYDEV_VDDD 5.0
#define CYDEV_VDDD_MV 5000
#define CYDEV_VDDIO0 5.0
#define CYDEV_VDDIO0_MV 5000
#define CYDEV_VDDIO1 5.0
#define CYDEV_VDDIO1_MV 5000
#define CYDEV_VDDIO2 5.0
#define CYDEV_VDDIO2_MV 5000
#define CYDEV_VDDIO3 5.0
#define CYDEV_VDDIO3_MV 5000
#define CYDEV_VIO0 5.0
#define CYDEV_VIO0_MV 5000
#define CYDEV_VIO1 5.0
#define CYDEV_VIO1_MV 5000
#define CYDEV_VIO2 5.0
#define CYDEV_VIO2_MV 5000
#define CYDEV_VIO3 5.0
#define CYDEV_VIO3_MV 5000
#define CYIPBLOCK_ARM_CM3_VERSION 0
#define CYIPBLOCK_P3_ANAIF_VERSION 0
#define CYIPBLOCK_P3_CAN_VERSION 0
#define CYIPBLOCK_P3_CAPSENSE_VERSION 0
#define CYIPBLOCK_P3_COMP_VERSION 0
#define CYIPBLOCK_P3_DECIMATOR_VERSION 0
#define CYIPBLOCK_P3_DFB_VERSION 0
#define CYIPBLOCK_P3_DMA_VERSION 0
#define CYIPBLOCK_P3_DRQ_VERSION 0
#define CYIPBLOCK_P3_DSM_VERSION 0
#define CYIPBLOCK_P3_EMIF_VERSION 0
#define CYIPBLOCK_P3_I2C_VERSION 0
#define CYIPBLOCK_P3_LCD_VERSION 0
#define CYIPBLOCK_P3_LPF_VERSION 0
#define CYIPBLOCK_P3_OPAMP_VERSION 0
#define CYIPBLOCK_P3_PM_VERSION 0
#define CYIPBLOCK_P3_SCCT_VERSION 0
#define CYIPBLOCK_P3_TIMER_VERSION 0
#define CYIPBLOCK_P3_USB_VERSION 0
#define CYIPBLOCK_P3_VIDAC_VERSION 0
#define CYIPBLOCK_P3_VREF_VERSION 0
#define CYIPBLOCK_S8_GPIO_VERSION 0
#define CYIPBLOCK_S8_IRQ_VERSION 0
#define CYIPBLOCK_S8_SAR_VERSION 0
#define CYIPBLOCK_S8_SIO_VERSION 0
#define CYIPBLOCK_S8_UDB_VERSION 0
#define DMA_CHANNELS_USED__MASK0 0x00000000u
#define CYDEV_BOOTLOADER_ENABLE 0

#endif /* INCLUDED_CYFITTER_H */
