﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ServerX.Common
{
	public interface IServerExtension
	{
		string ID { get; }
		string Name { get; }
		string Description { get; }
		//string JsonCall(string name, string data);
		//string Command(string name, string[] args);
		void Run(CancellationToken token);
		bool IsRunning { get; }
	}
}