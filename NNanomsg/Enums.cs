﻿using System;

namespace NNanomsg
{
    public enum Domain
    {
        SP = 1,
        SP_RAW = 2
    }

    public enum SocketOption
    {
        LINGER = 1,
        SNDBUF = 2,
        RCVBUF = 3,
        SNDTIMEO = 4,
        RCVTIMEO = 5,
        RECONNECT_IVL = 6,
        RECONNECT_IVL_MAX = 7,
        SNDPRIO = 8,
        SNDFD = 10,
        RCVFD = 11,
        DOMAIN = 12,
        PROTOCOL = 13,
        IPV4ONLY = 14,
        TCP_NODELAY = Constants.NN_TCP_NODELAY,
        SURVEYOR_DEADLINE = Constants.NN_SURVEYOR_DEADLINE,
        REQ_RESEND_IVL = Constants.NN_REQ_RESEND_IVL,
        SUB_SUBSCRIBE = Constants.NN_SUB_SUBSCRIBE,
        SUB_UNSUBSCRIBE = Constants.NN_SUB_UNSUBSCRIBE,
        WS_MSG_TYPE = Constants.NN_WS_MSG_TYPE,
        RCVMAXSIZE = Constants.NN_RCVMAXSIZE
    }

    public enum SocketOptionTcp
    {
        NoDelay = Constants.NN_TCP_NODELAY
    }

    public enum WebSocketType
    {
        Text = Constants.NN_WS_MSG_TYPE_TEXT,
        Binary = Constants.NN_WS_MSG_TYPE_BINARY
    }

    public enum SocketOptionSurvey
    {
        SurveyorDeadline = Constants.NN_SURVEYOR_DEADLINE
    }

    public enum SocketOptionRequest
    {
        RequestResendInterval = Constants.NN_REQ_RESEND_IVL
    }

    public enum SocketOptionSub
    {
        Subscribe = Constants.NN_SUB_SUBSCRIBE,
        Unsubscribe = Constants.NN_SUB_UNSUBSCRIBE
    }

    public enum SocketOptionLevel
    {
        Default = Constants.NN_SOL_SOCKET,
        Ipc = Constants.NN_IPC,
        InProcess = Constants.NN_INPROC,
        Tcp = Constants.NN_TCP,
        Ws = Constants.NN_WS,
        Pair = Constants.NN_PAIR,
        Publish = Constants.NN_PUB,
        Subscribe = Constants.NN_SUB,
        Request = Constants.NN_REQ,
        Reply = Constants.NN_REP,
        Push = Constants.NN_PUSH,
        Pull = Constants.NN_PULL,
        Surveyor = Constants.NN_SURVEYOR,
        Respondent = Constants.NN_RESPONDENT,
        Bus = Constants.NN_BUS
    }

    public enum Protocol
    {
        PAIR = Constants.NN_PAIR,
        PUB = Constants.NN_PUB,
        SUB = Constants.NN_SUB,
        REQ = Constants.NN_REQ,
        REP = Constants.NN_REP,
        PUSH = Constants.NN_PUSH,
        PULL = Constants.NN_PULL,
        SURVEYOR = Constants.NN_SURVEYOR,
        RESPONDENT = Constants.NN_RESPONDENT,
        BUS = Constants.NN_BUS
    }

    public enum Transport
    {
        IPC = Constants.NN_IPC,
        INPROC = Constants.NN_INPROC,
        TCP = Constants.NN_TCP,
        WS = Constants.NN_WS
    }

    public enum SendRecvFlags
    {
        NONE = 0,
        DONTWAIT = 1
    }

    public enum Error
    {
        NONE = 0
    }

    [Flags]
    public enum Events
    {
        POLLIN = 0x01,
        POLLOUT = 0x02
    }

    public enum Statistics
    {
        EstablishedConnections = Constants.NN_STAT_ESTABLISHED_CONNECTIONS,
        AcceptedConnections = Constants.NN_STAT_ACCEPTED_CONNECTIONS,
        DroppedConnections = Constants.NN_STAT_DROPPED_CONNECTIONS,
        BrokenConnections= Constants.NN_STAT_BROKEN_CONNECTIONS,
        ConnectErrors= Constants.NN_STAT_CONNECT_ERRORS,
        BindErrors = Constants.NN_STAT_BIND_ERRORS,
        AcceptErrors = Constants.NN_STAT_ACCEPT_ERRORS,
        CurrentConnections = Constants.NN_STAT_CURRENT_CONNECTIONS,
        InProgressConnections = Constants.NN_STAT_INPROGRESS_CONNECTIONS,
        CurrentEndpointErrors= Constants.NN_STAT_CURRENT_EP_ERRORS,
        MessagesSent = Constants.NN_STAT_MESSAGES_SENT,
        MessagesReceived= Constants.NN_STAT_MESSAGES_RECEIVED,
        BytesSent = Constants.NN_STAT_BYTES_SENT,
        BytesReceived = Constants.NN_STAT_BYTES_RECEIVED,
        CurrentSendPriority = Constants.NN_STAT_CURRENT_SND_PRIORITY
    }

    public class Constants
    {
        public const int

            NN_SOL_SOCKET = 0,

            NN_MSG = -1,

            // pair protocol related constants
            NN_PROTO_PAIR = 1,
            NN_PAIR = NN_PROTO_PAIR * 16 + 0,

            // pubsub protocol related constants
            NN_PROTO_PUBSUB = 2,
            NN_PUB = NN_PROTO_PUBSUB * 16 + 0,
            NN_SUB = NN_PROTO_PUBSUB * 16 + 1,
            NN_SUB_SUBSCRIBE = 1,
            NN_SUB_UNSUBSCRIBE = 2,

            // reqrep protocol related constants
            NN_PROTO_REQREP = 3,
            NN_REQ = NN_PROTO_REQREP * 16 + 0,
            NN_REP = NN_PROTO_REQREP * 16 + 1,
            NN_REQ_RESEND_IVL = 1,

            // pipeline protocol related constants
            NN_PROTO_PIPELINE = 5,
            NN_PUSH = NN_PROTO_PIPELINE * 16 + 0,
            NN_PULL = NN_PROTO_PIPELINE * 16 + 1,

            // survey protocol related constants
            NN_PROTO_SURVEY = 6,
            NN_SURVEYOR = NN_PROTO_SURVEY * 16 + 0,
            NN_RESPONDENT = NN_PROTO_SURVEY * 16 + 1,
            NN_SURVEYOR_DEADLINE = 1,

            // bus protocol related constants
            NN_PROTO_BUS = 7,
            NN_BUS = NN_PROTO_BUS * 16 + 0,

            // tcp transport related constants
            NN_TCP = -3,
            NN_TCP_NODELAY = 1,

            NN_IPC = -2,
            NN_INPROC = -1,

            NN_WS = -4,
            NN_WS_MSG_TYPE = 1,
            NN_WS_MSG_TYPE_TEXT = 0x01,
            NN_WS_MSG_TYPE_BINARY = 0x02,

            NN_STAT_ESTABLISHED_CONNECTIONS = 101,
            NN_STAT_ACCEPTED_CONNECTIONS = 102,
            NN_STAT_DROPPED_CONNECTIONS = 103,
            NN_STAT_BROKEN_CONNECTIONS = 104,
            NN_STAT_CONNECT_ERRORS = 105,
            NN_STAT_BIND_ERRORS = 106,
            NN_STAT_ACCEPT_ERRORS = 107,

            NN_STAT_CURRENT_CONNECTIONS = 201,
            NN_STAT_INPROGRESS_CONNECTIONS = 202,
            NN_STAT_CURRENT_EP_ERRORS = 203,

            /*  The socket-internal statistics  */
            NN_STAT_MESSAGES_SENT = 301,
            NN_STAT_MESSAGES_RECEIVED = 302,
            NN_STAT_BYTES_SENT = 303,
            NN_STAT_BYTES_RECEIVED = 304,
            /*  Protocol statistics  */
            NN_STAT_CURRENT_SND_PRIORITY = 401;
    }


}
