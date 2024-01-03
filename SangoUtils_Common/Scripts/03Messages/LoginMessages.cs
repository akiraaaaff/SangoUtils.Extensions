﻿using System;

namespace SangoUtils_Common.Messages
{
    [Serializable]
    public class LoginReqMessage
    {
        public LoginReqMessage() { }

        public LoginReqMessage(LoginMode loginMode, string uID, string password)
        {
            LoginMode = loginMode;
            UID = uID;
            Password = password;
        }

        public LoginMode LoginMode { get; set; } = LoginMode.None;
        public string UID { get; set; } = "";
        public string Password { get; set; } = "";
    }

    [Serializable]
    public class LoginRspMessage
    {
        public LoginRspMessage() { }

        public LoginRspMessage(LoginResCode loginResCode, string entityID)
        {
            LoginResCode = loginResCode;
            EntityID = entityID;
        }

        public LoginResCode LoginResCode { get; set; } = LoginResCode.None;
        public string EntityID { get; set; } = "";
    }

    public enum LoginMode
    {
        None,
        Guest,
        UIDAndPassword
    }

    public enum LoginResCode
    {
        None,
        LoginSuccess,
        LoginFailed_AccountHasOnline,
        LoginFailed_UIDAndPasswordNotMatch
    }
}
