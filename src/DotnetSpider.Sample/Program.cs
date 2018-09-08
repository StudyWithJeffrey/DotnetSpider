﻿using DotnetSpider.Common;
using DotnetSpider.Core;
using DotnetSpider.Downloader;
using DotnetSpider.Extension;
using DotnetSpider.Extension.Pipeline;
using DotnetSpider.Extraction;
using DotnetSpider.Extraction.Model;
using DotnetSpider.Extraction.Model.Attribute;
using DotnetSpider.Sample.docs;
using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using static MessagePack.LZ4MessagePackSerializer;

namespace DotnetSpider.Sample
{
	class Program
	{
		static void Main(string[] args)
		{
#if NETCOREAPP
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#else
			ThreadPool.SetMinThreads(256, 256);
#endif
 

			ConfigurableSpider.Run();
		}

 
		/// <summary>
		/// <c>MyTest</c> is a method in the <c>Program</c>
		/// </summary>
		private static void MyTest()
		{

		}
	}
}
