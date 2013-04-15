﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG4NET
{
    internal static class Container
    {
        public const uint GG_WELCOME = 0x0001;
        public const uint GG_LOGIN80 = 0x0031;
        public const uint GG_LOGIN80_OK = 0x0035;
        public const uint GG_LOGIN80_FAILED = 0x0043;
        public const uint GG_DISCONNECTING = 0x000b;
        public const uint GG_NEW_STATUS80 = 0x0038;
        public const uint GG_PING = 0x0008;
        public const uint GG_RECV_MSG80 = 0x002e;
        public const uint GG_RECV_MSG_ACK = 0x0046;
        public const uint GG_SEND_MSG80 = 0x002d;
        public const uint GG_NEED_EMAIL = 0x0014;
        public const uint GG_LIST_EMPTY = 0x0012;

        public const byte GG_LOGIN_HASH_GG32 = 0x01;
        public const byte GG_LOGIN_HASH_SHA1 = 0x02;      

        public const uint GG_STATUS_NOT_AVAIL = 0x0001;
        public const uint GG_STATUS_NOT_AVAIL_DESCR = 0x0015;
        public const uint GG_STATUS_FFC = 0x0017;
        public const uint GG_STATUS_FFC_DESCR = 0x0018;
        public const uint GG_STATUS_AVAIL = 0x0002;
        public const uint GG_STATUS_AVAIL_DESCR = 0x0004;
        public const uint GG_STATUS_BUSY = 0x0003;
        public const uint GG_STATUS_BUSY_DESCR = 0x0005;
        public const uint GG_STATUS_DND = 0x0021;
        public const uint GG_STATUS_DND_DESCR = 0x0022;
        public const uint GG_STATUS_INVISIBLE = 0x0014;
        public const uint GG_STATUS_INVISIBLE_DESCR = 0x0016;
        public const uint GG_STATUS_BLOCKED = 0x0006;
        public const uint GG_STATUS_IMAGE_MASK = 0x0100;
        public const uint GG_STATUS_ADAPT_STATUS_MASK = 0x0400;
        public const uint GG_STATUS_DESCR_MASK = 0x4000;
        public const uint GG_STATUS_FRIENDS_MASK = 0x8000;

        public const uint GG_LOGIN_FLAG_NOTIFYTYPE_77 = 0x00000001;
        public const uint GG_LOGIN_FLAG_MSGTYPE_80 = 0x00000002;
        public const uint GG_LOGIN_FLAG_STATUSTYPE_80 = 0x00000004;
        public const uint GG_LOGIN_FLAG_DNDFFC = 0x00000010;
        public const uint GG_LOGIN_FLAG_GRAPHICSTATUSES = 0x00000020;
        public const uint GG_LOGIN_FLAG_LOGINFAILEDTYPE = 0x00000040;
        public const uint GG_LOGIN_FLAG_UNKNOWN = 0x00000100;
        public const uint GG_LOGIN_FLAG_ADDINFO = 0x00000200;
        public const uint GG_LOGIN_FLAG_SENDMSGACK = 0x00000400;
        public const uint GG_LOGIN_FLAG_TYPINGNOTIF = 0x00002000;
        public const uint GG_LOGIN_FLAG_MULTILOGIN = 0x00004000;

        public const uint GG_STATUS_FLAG_AUDIO = 0x00000001;
        public const uint GG_STATUS_FLAG_VIDEO = 0x00000002;
        public const uint GG_STATUS_FLAG_MOBILE = 0x00100000;
        public const uint GG_STATUS_FLAG_LINKS_FROM_UNKNOWN = 0x00800000;

        public const uint GG_CLASS_CHAT = 0x0008;
    }
}
