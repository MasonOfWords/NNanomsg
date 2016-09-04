using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NNanomsg
{
    public static class NanomsgSymbols
    {
        static NanomsgSymbols()
        {
            Type thisType = typeof(NanomsgSymbols);
            for (int i = 0; ; ++i)
            {
                int value;

                var ptr = Interop.nn_symbol(i, out value);

                string symbolText = Marshal.PtrToStringAnsi(ptr);

                if (symbolText == null)
                    break;

                FieldInfo field = thisType.GetField(symbolText, BindingFlags.Static | BindingFlags.Public);

                if (field != null)
                    field.SetValue(null, value);
                else
                    System.Diagnostics.Debug.Fail("Unused symbol " + symbolText);
            }
        }

        public static readonly int
            NN_TYPE_NONE,
            NN_TYPE_INT,
            NN_TYPE_STR,
            NN_UNIT_NONE,
            NN_UNIT_BYTES,
            NN_UNIT_MILLISECONDS,
            NN_UNIT_PRIORITY,
            NN_UNIT_BOOLEAN,
            NN_NS_EVENT,
            NN_NS_LIMIT,
            NN_NS_ERROR,
            NN_NS_FLAG,
            NN_NS_OPTION_UNIT,
            NN_NS_OPTION_TYPE,
            NN_NS_TRANSPORT_OPTION,
            NN_NS_SOCKET_OPTION,
            NN_NS_OPTION_LEVEL,
            NN_NS_PROTOCOL,
            NN_NS_TRANSPORT,
            NN_NS_DOMAIN,
            NN_NS_VERSION,
            NN_NS_NAMESPACE,
            NN_VERSION_CURRENT,
            NN_VERSION_REVISION,
            NN_VERSION_AGE,
            AF_SP,
            AF_SP_RAW,
            NN_INPROC,
            NN_IPC,
            NN_TCP,
            NN_PAIR,
            NN_PUB,
            NN_SUB,
            NN_REP,
            NN_REQ,
            NN_PUSH,
            NN_PULL,
            NN_SURVEYOR,
            NN_RESPONDENT,
            NN_BUS,
            NN_SOCKADDR_MAX,
            NN_SOL_SOCKET,
            NN_LINGER,
            NN_SNDBUF,
            NN_RCVBUF,
            NN_SNDTIMEO,
            NN_RCVTIMEO,
            NN_RECONNECT_IVL,
            NN_RECONNECT_IVL_MAX,
            NN_SNDPRIO,
            NN_RCVPRIO,
            NN_SNDFD,
            NN_RCVFD,
            NN_DOMAIN,
            NN_PROTOCOL,
            NN_IPV4ONLY,
            NN_SOCKET_NAME,
            NN_SUB_SUBSCRIBE,
            NN_SUB_UNSUBSCRIBE,
            NN_REQ_RESEND_IVL,
            NN_SURVEYOR_DEADLINE,
            NN_TCP_NODELAY,
            NN_DONTWAIT,
            NN_POLLIN,
            NN_POLLOUT,
            NN_UNIT_COUNTER,
            NN_UNIT_MESSAGES,
            NN_WS,
            NN_RCVMAXSIZE,
            NN_WS_MSG_TYPE,
            NN_WS_MSG_TYPE_TEXT,
            NN_WS_MSG_TYPE_BINARY,
            NN_STAT_ESTABLISHED_CONNECTIONS,
            NN_STAT_ACCEPTED_CONNECTIONS,
            NN_STAT_DROPPED_CONNECTIONS,
            NN_STAT_BROKEN_CONNECTIONS,
            NN_STAT_CONNECT_ERRORS,
            NN_STAT_BIND_ERRORS,
            NN_STAT_ACCEPT_ERRORS,
            NN_STAT_MESSAGES_SENT,
            NN_STAT_MESSAGES_RECEIVED,
            NN_STAT_BYTES_SENT,
            NN_STAT_BYTES_RECEIVED,
            NN_STAT_CURRENT_CONNECTIONS,
            NN_STAT_INPROGRESS_CONNECTIONS,
            NN_STAT_CURRENT_SND_PRIORITY,
            NN_STAT_CURRENT_EP_ERRORS,
            EADDRINUSE,
            EADDRNOTAVAIL,
            EAFNOSUPPORT,
            EAGAIN,
            EBADF,
            ECONNREFUSED,
            EFAULT,
            EFSM,
            EINPROGRESS,
            EINTR,
            EINVAL,
            EMFILE,
            ENAMETOOLONG,
            ENETDOWN,
            ENOBUFS,
            ENODEV,
            ENOMEM,
            ENOPROTOOPT,
            ENOTSOCK,
            ENOTSUP,
            EPROTO,
            EPROTONOSUPPORT,
            ETERM,
            ETIMEDOUT,
            EACCES,
            ECONNABORTED,
            ECONNRESET,
            EHOSTUNREACH,
            EMSGSIZE,
            ENETRESET,
            ENETUNREACH,
            ENOTCONN;
    }
}
