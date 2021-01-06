﻿namespace Rebirth.Common.Types
{
    public enum ParcelOps
    {
        ParcelReq_OpenQuickReceive = 0x0,
        ParcelReq_Load = 0x1,
        ParcelReq_Send = 0x2,
        ParcelReq_ConfirmSend = 0x3,
        ParcelReq_Receive = 0x4,
        ParcelReq_Discard = 0x5,
        ParcelReq_Remove = 0x6,
        ParcelReq_Close = 0x7,
        ParcelRes_Loaded = 0x8,
        ParcelRes_SendSuccess = 0x9,
        ParcelRes_SendErr_NotEnoughMoney = 0xA,
        ParcelRes_SendErr_IncorrectRequest = 0xB,
        ParcelRes_SendErr_NoCharacter = 0xC,
        ParcelRes_SendErr_SameAccount = 0xD,
        ParcelRes_SendErr_NoSpaceToPeer = 0xE,
        ParcelRes_SendErr_TargetUserCannotReceive = 0xF,
        ParcelRes_SendErr_TargetHavingOnlyItem = 0x10,
        ParcelRes_SendErr_LimitMoney = 0x11,
        ParcelRes_ConfirmSend_Success = 0x12,
        ParcelRes_ConfirmSend_Failure = 0x13,
        ParcelRes_ReceiveSuccess = 0x14,
        ParcelRes_ReceiveErr_NoEmptySlot = 0x15,
        ParcelRes_ReceiveErr_HavingOnlyItem = 0x16,
        ParcelRes_RemoveSuccess = 0x17,
        ParcelRes_NewParcelSent = 0x18,
        ParcelRes_ReceivedNewParcel = 0x19,
        ParcelRes_OpenQuickSend = 0x1A,
        ParcelRes_DelayedNotify = 0x1B,
        ParcelRes_UnknownError = 0x1C,
        ParcelRes_Expired = 0x1D,
        ParcelRes_ServerMsg = 0x1E,
    }
}
