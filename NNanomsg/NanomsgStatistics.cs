using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NNanomsg
{
    public struct NanomsgStatistics
    {
        int _socket;

        public NanomsgStatistics(int s)
        {
            _socket = s;
        }
        
        public long EstablishedConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_ESTABLISHED_CONNECTIONS);
        public long AcceptedConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_ACCEPTED_CONNECTIONS);
        public long DroppedConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_DROPPED_CONNECTIONS);
        public long BrokenConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_BROKEN_CONNECTIONS);
        public long ConnectErrors => Interop.nn_get_statistic(_socket, Constants.NN_STAT_CONNECT_ERRORS);
        public long BindErrors => Interop.nn_get_statistic(_socket, Constants.NN_STAT_BIND_ERRORS);
        public long AcceptErrors => Interop.nn_get_statistic(_socket, Constants.NN_STAT_ACCEPT_ERRORS);
        public long CurrentConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_CURRENT_CONNECTIONS);
        public long InProgressConnections => Interop.nn_get_statistic(_socket, Constants.NN_STAT_INPROGRESS_CONNECTIONS);
        public long CurrentEndpointErrors => Interop.nn_get_statistic(_socket, Constants.NN_STAT_CURRENT_EP_ERRORS);
        public long MessagesSent => Interop.nn_get_statistic(_socket, Constants.NN_STAT_MESSAGES_SENT);
        public long MessagesReceived => Interop.nn_get_statistic(_socket, Constants.NN_STAT_MESSAGES_RECEIVED);
        public long BytesSent => Interop.nn_get_statistic(_socket, Constants.NN_STAT_BYTES_SENT);
        public long BytesReceived => Interop.nn_get_statistic(_socket, Constants.NN_STAT_BYTES_RECEIVED);
        public long CurrentSendPriority => Interop.nn_get_statistic(_socket, Constants.NN_STAT_CURRENT_SND_PRIORITY);

        public long GetStatistic(Statistics statistic)
        {
            return Interop.nn_get_statistic(_socket, (int)statistic);
        }
    }
}
