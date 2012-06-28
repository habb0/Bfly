﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database_Manager.Database.Session_Details.Interfaces
{
	interface IDatabaseClient : IDisposable
	{
        void connect();
        void disconnect();
        //void Dispose();
        IQueryAdapter getQueryReactor();
        bool isAvailable();
        void prepare();
        void reportDone();
	}
}
