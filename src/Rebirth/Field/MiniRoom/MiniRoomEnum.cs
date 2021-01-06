﻿namespace Rebirth.Field.MiniRoom
{
    public static class MiniRoomEnum
    {
        public enum MR_Type
        {
            CashTradingRoom = 0x06,
            EntrustedShop = 0x05,
            PersonalShop = 0x04,
            TradingRoom = 0x03,
            MemoryGame = 0x02,
            Omok = 0x01
        }

        public enum MR_LeaveResult
        {
            UserRequest = 0x0,
            WrongPosition = 0x1,
            Closed = 0x2,
            HostOut = 0x3,
            Booked = 0x4,
            Kicked = 0x5,
            OpenTimeOver = 0x6,
            TradeDone = 0x7,
            TradeFail = 0x8,
            TradeFail_OnlyItem = 0x9,
            TradeFail_Expired = 0xA,
            TradeFail_Denied = 0xB,
            FieldError = 0xC,
            ItemCRCFailed = 0xD,
            NoMoreItem = 0xE,
            KickedTimeOver = 0xF,
            Open = 0x10,
            StartManage = 0x11,
            ClosedTimeOver = 0x12,
            EndManage = 0x13,
            DestoryByAdmin = 0x14
        }

        public enum MR_EnterResult
        {
            Success = 0x0,
            NoRoom = 0x1,
            Full = 0x2,
            Busy = 0x3,
            Dead = 0x4,
            Event = 0x5,
            PermissionDenied = 0x6,
            NoTrading = 0x7,
            Etc = 0x8,
            OnlyInSameField = 0x9,
            NearPortal = 0xA,
            CreateCountOver = 0xB,
            CreateIPCountOver = 0xC,
            ExistMiniRoom = 0xD,
            NotAvailableField_Game = 0xE,
            NotAvailableField_PersonalShop = 0xF,
            NotAvailableField_EntrustedShop = 0x10,
            OnBlockedList = 0x11,
            IsManaging = 0x12,
            Tournament = 0x13,
            AlreadyPlaying = 0x14,
            NotEnoughMoney = 0x15,
            InvalidPassword = 0x16,
            NotAvailableField_ShopScanner = 0x17,
            Expired = 0x18,
            TooShortTimeInterval = 0x19
        }

        public enum MR_InviteResult
        {
            Success = 0,
            NoCharacter = 1,
            CannotInvite = 2,
            Rejected = 3,
            Blocked = 4
        }

        /// <summary>
        /// All the non-success types will tell the user to see Fredrick in FM.
        /// </summary>
        public enum MR_WithdrawResult
        {
            Success = 0x0,
            InventoryAndMoneyFailed = 0x1,
            InventoryError = 0x2, // unsure what this is exactly
            InventoryFull = 0x3,
            UnknownError = 0x4,
        }

        public enum MR_Action
        {
            // Generic
            MRP_Create = 0x0,
            MRP_CreateResult = 0x1,
            MRP_Invite = 0x2,
            MRP_InviteResult = 0x3,
            MRP_Enter = 0x4,
            MRP_EnterResult = 0x5,
            MRP_Chat = 0x6,
            MRP_GameMessage = 0x7,
            MRP_UserChat = 0x8,
            MRP_Avatar = 0x9,
            MRP_Leave = 0xA,
            MRP_Balloon = 0xB,
            MRP_NotAvailableField = 0xC,
            MRP_FreeMarketClip = 0xD,
            MRP_CheckSSN2 = 0xE,

            // Trade
            TRP_PutItem = 0xF,
            TRP_PutMoney = 0x10,
            TRP_Trade = 0x11,
            TRP_UnTrade = 0x12,
            TRP_MoveItemToInventory = 0x13,
            TRP_ItemCRC = 0x14,
            TRP_LimitFail = 0x15,

            // Player Shop
            PSP_PutItem = 0x16,
            PSP_BuyItem = 0x17,
            PSP_BuyResult = 0x18,
            PSP_Refresh = 0x19,
            PSP_AddSoldItem = 0x1A,
            PSP_MoveItemToInventory = 0x1B,
            PSP_Ban = 0x1C,
            PSP_KickedTimeOver = 0x1D,
            PSP_DeliverBlackList = 0x1E,
            PSP_AddBlackList = 0x1F,
            PSP_DeleteBlackList = 0x20,

            // Hired Merchant
            ESP_PutItem = 0x21,
            ESP_BuyItem = 0x22,
            ESP_BuyResult = 0x23,
            ESP_Refresh = 0x24,
            ESP_AddSoldItem = 0x25,
            ESP_MoveItemToInventory = 0x26,
            ESP_GoOut = 0x27,
            ESP_ArrangeItem = 0x28,
            ESP_WithdrawAll = 0x29,
            ESP_WithdrawAllResult = 0x2A,
            ESP_WithdrawMoney = 0x2B,
            ESP_WithdrawMoneyResult = 0x2C,
            ESP_AdminChangeTitle = 0x2D,
            ESP_DeliverVisitList = 0x2E,
            ESP_DeliverBlackList = 0x2F,
            ESP_AddBlackList = 0x30,
            ESP_DeleteBlackList = 0x31,

            // MiniGame
            MGRP_TieRequest = 0x32,
            MGRP_TieResult = 0x33,
            MGRP_GiveUpRequest = 0x34,
            MGRP_GiveUpResult = 0x35,
            MGRP_RetreatRequest = 0x36,
            MGRP_RetreatResult = 0x37,
            MGRP_LeaveEngage = 0x38,
            MGRP_LeaveEngageCancel = 0x39,
            MGRP_Ready = 0x3A,
            MGRP_CancelReady = 0x3B,
            MGRP_Ban = 0x3C,
            MGRP_Start = 0x3D,
            MGRP_GameResult = 0x3E,
            MGRP_TimeOver = 0x3F,

            // Omok
            ORP_PutStoneChecker = 0x40,
            ORP_InvalidStonePosition = 0x41,
            ORP_InvalidStonePosition_Normal = 0x42,
            ORP_InvalidStonePosition_By33 = 0x43,

            // Match Card
            MGP_TurnUpCard = 0x44,
            MGP_MatchCard = 0x45
        }
    }
}
